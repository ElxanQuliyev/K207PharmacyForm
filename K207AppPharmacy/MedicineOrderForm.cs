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
    public partial class MedicineOrderForm : Form
    {
        PharmacyDB _context = new PharmacyDB();
        private string barcode;
        public MedicineOrderForm(string br)
        {
            this.barcode = br;
            InitializeComponent();
        }
        private void AddMedicineToList(string barcode)
        {
            Medicine med = _context.Medicines.FirstOrDefault(x => x.Barcode == barcode);
            //if (!ckBuyMedList.Items.Contains(med.Name))
            //{
                ckBuyMedList.Items.Add(med.Name, true);
            //}
        }
        private void MedicineOrderForm_Load(object sender, EventArgs e)
        {
            AddMedicineToList(barcode);
        }
    }
}
