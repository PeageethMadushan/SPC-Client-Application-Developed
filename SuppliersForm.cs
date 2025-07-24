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
    public partial class SuppliersForm : Form
    {
        DatabaseManager db = new DatabaseManager();

        public SuppliersForm()
        {
            InitializeComponent();
            LoadSuppliers();
        }
        
        private void LoadSuppliers()
        {
            string query = "SELECT supplierid, suppliername, email FROM supplier";
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewSuppliers.DataSource = dt;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string query = $"INSERT INTO supplier (suppliername, email, password) VALUES ('{name}', '{email}', '{password}')";
            db.ExecuteNonQuery(query);
            MessageBox.Show("Supplier Added Successfully!");
            LoadSuppliers();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt32(txtSupplierID.Text);
            string name = txtSupplierName.Text;
            string email = txtEmail.Text;

            string query = $"UPDATE supplier SET suppliername = '{name}', email = '{email}' WHERE supplierid = {supplierId}";
            db.ExecuteNonQuery(query);
            MessageBox.Show("Supplier Updated!");
            LoadSuppliers();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt32(txtSupplierID.Text);

            string query = $"DELETE FROM supplier WHERE supplierid = {supplierId}";
            db.ExecuteNonQuery(query);
            MessageBox.Show("Supplier Deleted!");
            LoadSuppliers();
        }
    }
}
