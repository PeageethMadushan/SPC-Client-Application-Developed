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
    public partial class Form1 : Form
    {
        DatabaseManager db = new DatabaseManager();

        public Form1()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            string queryAdmin = $"SELECT * FROM admin WHERE username = '{username}' AND pass = '{password}'";
            DataTable dtAdmin = db.ExecuteQuery(queryAdmin);

            if (dtAdmin.Rows.Count > 0)
            {
                MessageBox.Show("Admin Login Successful");
                AdminDashboard adminForm = new AdminDashboard();
                this.Hide();
                adminForm.Show();
                return;
            }
            
            string queryWarehouse = $"SELECT * FROM warehouse WHERE username = '{username}' AND password = '{password}'";
            DataTable dtWarehouse = db.ExecuteQuery(queryWarehouse);

            if (dtWarehouse.Rows.Count > 0)
            {
                MessageBox.Show("Warehouse Login Successful");
                WarehouseDashboard warehouseForm = new WarehouseDashboard();
                this.Hide();
                warehouseForm.Show();
                return;
            }

            MessageBox.Show("Invalid username or password.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
