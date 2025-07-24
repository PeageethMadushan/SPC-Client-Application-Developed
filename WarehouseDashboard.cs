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
    public partial class WarehouseDashboard : Form
    {
        public WarehouseDashboard()
        {
            InitializeComponent();
        }

        private void btnAddDrugs_Click(object sender, EventArgs e)
        {
            DrugsForm drugsForm = new DrugsForm();
            drugsForm.Show();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            WarehouseOrdersForm drugsForm = new WarehouseOrdersForm();
            drugsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }
    }
}
