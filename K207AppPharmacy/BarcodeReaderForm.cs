using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video.DirectShow;
using AForge.Video;
using K207AppPharmacy.Models;

namespace K207AppPharmacy
{
    public partial class BarcodeReaderForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Medicine selectedMedicine;
        PharmacyDB _context = new PharmacyDB();
        public BarcodeReaderForm()
        {
            InitializeComponent();
        }

        private void BarcodeReaderForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cmbCamera.Items.Add(device.Name);
            }
            cmbCamera.SelectedIndex = 0;

        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = result.ToString();
                    selectedMedicine = _context.Medicines.FirstOrDefault(m => m.Barcode == txtBarcode.Text);
                    if (selectedMedicine != null)
                    {
                        SellMedicinePanel.Visible = true;
                        txtBuyMedName.Text = selectedMedicine.Name;
                    }
                }));
            }
            pictureBox.Image = bitmap;
        }

        private void BarcodeReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMedicineList(txtBuyMedName.Text);
        }
        private void AddMedicineList(string t)
        {
            if (!ckBuyMedList.Items.Contains(t))
            {
                ckBuyMedList.Items.Add(t + "-" + nmBuyCount.Value, true);
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

        private void btnBuyMedicine_Click(object sender, EventArgs e)
        {
            string result = "";
            decimal totalPrice = 0;
            for (int i = 0; i < ckBuyMedList.Items.Count; i++)
            {
                string medItem = ckBuyMedList.Items[i].ToString();
                string medname = medItem.Substring(0, medItem.LastIndexOf("-"));
                short count = Convert.ToInt16(medItem.Substring(medItem.LastIndexOf("-") + 1));
                Medicine selectedMed = _context.Medicines.First(m => m.Name == medname);
                _context.Orders.Add(new Order
                {
                    WorkerID = 1,
                    MedicineID = selectedMed.M_ID,
                    Amount = count,
                    PurchaseDate = DateTime.Now,
                    Price = selectedMed.Price * count
                });
                selectedMed.Quantity -= count;
                _context.SaveChanges();
                totalPrice += selectedMed.Price * count;
                result += $"Medicine:{medname}, Count:{count}, Price:{selectedMed.Price} Azn \n";
            }
            MessageBox.Show(result + "\n\n" + $"Total Price:{totalPrice} Azn", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearAfterBuyMed();
        }
        private void ClearAfterBuyMed()
        {
            SellMedicinePanel.Visible = false;
            ckBuyMedList.Items.Clear();
        }

    }
}
