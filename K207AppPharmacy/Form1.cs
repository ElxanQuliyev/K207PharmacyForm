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
    public partial class Form1 : Form
    {
        PharmacyDB _context = new PharmacyDB();
        private string barcode;
        public Form1()
        {
            InitializeComponent();

        }
        public Form1(string barcode)
        {

            this.barcode = barcode;
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineForm mdF = new MedicineForm();
            mdF.ShowDialog();
        }

        private void MedicineComboFill()
        {
            cmbMedicine.Items.AddRange(_context.Medicines.Select(m => m.Name).ToArray());
        }
        private void TagComboFill()
        {
            cmbTags.Items.AddRange(_context.Tags.Select(m => m.Name).ToArray());
        }
        private void FillMedicineDataGrid()
        {
            dtgMedicineList.DataSource = _context.Medicine_To_Tags
                .Where(m => m.Medicine.Name.Contains(cmbMedicine.Text) &&
                 m.Tag.Name.Contains(cmbTags.Text))
                .Select(md => new
                {
                    md.MedicineID,
                    Medicine_Name = md.Medicine.Name,
                    md.Medicine.Price,
                    md.Medicine.Quantity,
                    Receipt = md.Medicine.IsReceipt ? "Reseptli" : "Resptsiz",
                    Firm_Name = md.Medicine.Firm.Name,
                    ProductionDate = md.Medicine.ProductionDate,
                    md.Medicine.ExperienceDate
                }).Distinct().ToList();
            dtgMedicineList.Columns[0].Visible = false;
            dtgMedicineList.Columns[5].DefaultCellStyle.Format = "dddd, dd MMMM yyyy";
            dtgMedicineList.Columns[6].DefaultCellStyle.Format = "dddd, dd MMMM yyyy";
            for (int i = 0; i < dtgMedicineList.RowCount; i++)
            {
                short quantity = (short)dtgMedicineList.Rows[i].Cells[3].Value;
                DateTime exDate = (DateTime)dtgMedicineList.Rows[i].Cells[7].Value;
                if (exDate < DateTime.Now)
                {
                    dtgMedicineList.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    dtgMedicineList.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                if (quantity <= 0)
                {
                    dtgMedicineList.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                    dtgMedicineList.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
                if (quantity <= 0 && exDate < DateTime.Now)
                {
                    dtgMedicineList.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                    dtgMedicineList.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MedicineComboFill();
            TagComboFill();
            FillMedicineDataGrid();
        }

        private void cmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMedicineDataGrid();
        }

        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMedicineDataGrid();
        }

        private void cmbMedicine_KeyUp(object sender, KeyEventArgs e)
        {
            FillMedicineDataGrid();
        }

        private void cmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            FillMedicineDataGrid();
        }

        private void dtgMedicineList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int medId = (int)dtgMedicineList.Rows[e.RowIndex].Cells[0].Value;
            Medicine selectedMedicine = _context.Medicines.First(m => m.M_ID == medId);
            if(selectedMedicine.ExperienceDate>DateTime.Now && selectedMedicine.Quantity != 0)
            {
                txtBuyMedName.Text = selectedMedicine.Name;
                SellMedicinePanel.Visible = true;
                nmBuyCount.Maximum = selectedMedicine.Quantity;
                nmBuyCount.Value = 1;
            }
        }
        
        private void btnBuyMedicine_Click(object sender, EventArgs e)
        {
            string result = "";
            decimal totalPrice=0;
            for (int i = 0; i < ckBuyMedList.Items.Count; i++)
            {
                string medItem=ckBuyMedList.Items[i].ToString();
                string medname = medItem.Substring(0, medItem.LastIndexOf("-"));
                short count =Convert.ToInt16(medItem.Substring(medItem.LastIndexOf("-")+1));
                Medicine selectedMed = _context.Medicines.First(m => m.Name == medname);
                _context.Orders.Add(new Order
                {
                    WorkerID=1,
                    MedicineID= selectedMed.M_ID,
                    Amount=count,
                    PurchaseDate=DateTime.Now,
                    Price=selectedMed.Price*count
                });
                selectedMed.Quantity -= count;
                _context.SaveChanges();
                totalPrice += selectedMed.Price * count;
                result += $"Medicine:{medname}, Count:{count}, Price:{selectedMed.Price} Azn \n";
            }
            MessageBox.Show(result +"\n\n"+$"Total Price:{totalPrice} Azn", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillMedicineDataGrid();
            ClearAfterBuyMed();
        }

        private void ClearAfterBuyMed()
        {
            SellMedicinePanel.Visible = false;
            ckBuyMedList.Items.Clear();
        }

        private void btnOpenBarcode_Click(object sender, EventArgs e)
        {
            BarcodeReaderForm rdb = new BarcodeReaderForm();
            rdb.ShowDialog();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineList(txtBuyMedName.Text);
        }
        private void AddMedicineList(string t)
        {
            if (!ckBuyMedList.Items.Contains(t))
            {
                ckBuyMedList.Items.Add(t+"-"+nmBuyCount.Value,true);
            }
        }

        private void ckBuyMedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTag = ckBuyMedList.SelectedIndex;
            if (selectedTag != -1)
            {
                ckBuyMedList.Items.RemoveAt(selectedTag);
            }
        }
    }
}
