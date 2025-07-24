using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAddDrugs_Click(object sender, EventArgs e)
        {
            DrugsForm drugsForm = new DrugsForm();
            drugsForm.Show();
        }

        private void btnPostAd_Click(object sender, EventArgs e)
        {
            AdvertisementForm adForm = new AdvertisementForm();
            adForm.Show();
        }

        private void btnViewSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliersForm = new SuppliersForm();
            suppliersForm.Show();
        }

        private void btnViewTenders_Click(object sender, EventArgs e)
        {
            TenderRequestsForm tendersForm = new TenderRequestsForm();
            tendersForm.Show();
        }

        private void btnRegisterPharmacy_Click(object sender, EventArgs e)
        {
            PharmacyManagementForm pharmacyForm = new PharmacyManagementForm();
            pharmacyForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }
    }
}
