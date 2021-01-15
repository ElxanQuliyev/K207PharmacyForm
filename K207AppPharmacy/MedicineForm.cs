using K207AppPharmacy.Helpers;
using K207AppPharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K207AppPharmacy
{
    public partial class MedicineForm : Form
    {
        PharmacyDB _context = new PharmacyDB();

        #region Cunstructor
        public MedicineForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            FillFirmCombo();
            FillTagCombo();
            FillMedicineDataGrid();
        }
        #endregion

        #region Firm Fill Combobox
        private void FillFirmCombo()
        {
            cmbFirms.Items.AddRange(_context.Firms.Select(f => f.Name).ToArray());
        }
        #endregion

        #region Tag Fill Combobox
        private void FillTagCombo()
        {
            cmbTags.Items.AddRange(_context.Tags.Select(f => f.Name).ToArray());
        }
        #endregion

        #region Medicine Click Button
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            
            string medicineName = txtMedicine.Text;
            decimal price = nmPrice.Value;
            short quantity = (short)nmQuantity.Value;
            string barcode = txtBarcode.Text;
            string firmName = cmbFirms.Text;
            string description = rcDesc.Text;
            DateTime proDate = dtProDate.Value;
            DateTime exDate = dtExpDate.Value;
            string[] myArr = { medicineName, firmName, barcode };
            if (Utilities.IsEmpty(myArr))
            {
                if (proDate < exDate)
                {
                    lblError.Visible = false;
                    int firmId=GetFirmID(firmName);
                    Medicine medicine = new Medicine();
                    medicine.Name = medicineName;
                    medicine.Price = price;
                    medicine.Description = description;
                    medicine.Quantity = quantity;
                    medicine.Barcode = barcode;
                    medicine.ProductionDate = proDate;
                    medicine.ExperienceDate = exDate;
                    medicine.FirmID = firmId;
                    medicine.IsReceipt = cbReceipt.Checked ? true : false;
                    _context.Medicines.Add(medicine);
                    _context.SaveChanges();
                    AddTagToMedicine(medicine.M_ID);
                    MessageBox.Show("Medicine added succefully!");
                    FillMedicineDataGrid();
                    ClearAllData();
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Please,Experience date is not valid!";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Please,All the Fiel!";
            }
        }

        #endregion

        #region Only Number Barcode Input   
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57 || txtBarcode.TextLength > 11)
                && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Firm Get ID
        private int GetFirmID(string frName)
        {
            Firm selectedFirm = _context.Firms.FirstOrDefault(f => f.Name == frName);
            if (selectedFirm == null)
            {
                Firm firm = new Firm();
                firm.Name = frName;
                _context.Firms.Add(firm);
                _context.SaveChanges();
                return firm.F_ID;
            }
            return selectedFirm.F_ID;
        }

        #endregion

        #region Tag Method
        private void ckTagList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTag = ckTagList.SelectedIndex;
            if (selectedTag!=-1)
            {
                ckTagList.Items.RemoveAt(selectedTag);
            }
        }

        private void FielTagCheckedList()
        {
            string tagName = cmbTags.Text;
            if (!string.IsNullOrWhiteSpace(tagName))
            {
                if (!ckTagList.Items.Contains(tagName))
                {
                    ckTagList.Items.Add(tagName,true);
                }
            }
        }

        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            FielTagCheckedList();
        }

        private void cmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FielTagCheckedList();
            }
        }

        private int FindTagID(string tgName)
        {
            Tag selectedTag= _context.Tags.FirstOrDefault(f => f.Name == tgName);
            if (selectedTag == null)
            {
                Tag newTag = new Tag();
                newTag.Name = tgName;
                _context.Tags.Add(newTag);
                _context.SaveChanges();
                return newTag.T_ID;
            }
            return selectedTag.T_ID;
        }
        private void AddTagToMedicine(int medId)
        {
            for (int i = 0; i < ckTagList.Items.Count; i++)
            {
                string tagName = ckTagList.Items[i].ToString();
                int tagId= FindTagID(tagName);
                _context.Medicine_To_Tags.Add(new Medicine_To_Tags()
                {
                    MedicineID = medId,
                    TagID = tagId
                });
                _context.SaveChanges();
            }
        }

        #endregion

        #region Clear Form Data
        private void ClearAllData()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox || item is ComboBox || item is RichTextBox)
                {
                    item.Text = "";
                }else if(item is NumericUpDown)
                {
                    NumericUpDown nm = (NumericUpDown)item;
                    nm.Value = 1;
                }else if(item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }else if(item is CheckedListBox)
                {
                    CheckedListBox ck = (CheckedListBox)item;
                    ck.Items.Clear();
                }else if(item is CheckBox)
                {
                    CheckBox ck = (CheckBox)item;
                    ck.Checked = false;
                }
            }
        }


        #endregion


        #region FillMedicineDataGrid
        private void FillMedicineDataGrid()
        {
            dtgMedicineDataGrid.DataSource = _context.Medicines.Select(m=>new { 
                Medicine_Name=m.Name,
                Price=m.Price+" Azn",
                m.Quantity,
                Firm_Name=m.Firm.Name,
                Receipts=m.IsReceipt?"Reseptli":"Reseptsiz",
                m.ProductionDate,
                m.ExperienceDate
            }).ToList();
            dtgMedicineDataGrid.Columns[5].DefaultCellStyle.Format = "dd-MMMM-yyyy / HH:mm:ss";
            dtgMedicineDataGrid.Columns[6].DefaultCellStyle.Format = "dd-MMMM-yyyy / HH:mm:ss";
            for (int i = 0; i < dtgMedicineDataGrid.RowCount; i++)
            {
                if (dtgMedicineDataGrid.Rows[i].Index % 2 == 0)
                {
                    dtgMedicineDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Teal;
                    dtgMedicineDataGrid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        #endregion

    }
}
