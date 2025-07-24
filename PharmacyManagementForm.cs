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
    public partial class PharmacyManagementForm : Form
    {
        DatabaseManager db = new DatabaseManager();

        public PharmacyManagementForm()
        {
            InitializeComponent();
            LoadPharmacies();
        }

        private void LoadPharmacies()
        {
            string query = "SELECT id, name, type, address, contact FROM pharmacy";
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewPharmacies.DataSource = dt;
        }

        private void btnRegisterPharmacy_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contact = txtContact.Text;
            string password = txtPassword.Text;
            string type = radioSPC.Checked ? "SPC" : "Dealer";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = $"INSERT INTO pharmacy (name, type, address, contact, pass) VALUES ('{name}', '{type}', '{address}', '{contact}', '{password}')";
            db.ExecuteNonQuery(query);

            MessageBox.Show("Pharmacy Registered Successfully!");
            LoadPharmacies();
        }

        private void btnDeletePharmacy_Click(object sender, EventArgs e)
        {
            if (dataGridViewPharmacies.SelectedRows.Count > 0)
            {
                int pharmacyId = Convert.ToInt32(dataGridViewPharmacies.SelectedRows[0].Cells["id"].Value);
                string query = $"DELETE FROM pharmacy WHERE id = {pharmacyId}";
                db.ExecuteNonQuery(query);

                MessageBox.Show("Pharmacy Deleted!");
                LoadPharmacies();
            }
            else
            {
                MessageBox.Show("Please select a pharmacy to delete.");
            }
        }

        private void btnUpdatePharmacy_Click(object sender, EventArgs e)
        {
            if (dataGridViewPharmacies.SelectedRows.Count > 0)
            {
                int pharmacyId = Convert.ToInt32(dataGridViewPharmacies.SelectedRows[0].Cells["id"].Value);
                string name = txtName.Text;
                string address = txtAddress.Text;
                string contact = txtContact.Text;
                string password = txtPassword.Text;
                string type = radioSPC.Checked ? "SPC" : "Dealer";

                string query = $"UPDATE pharmacy SET name='{name}', type='{type}', address='{address}', contact='{contact}', pass='{password}' WHERE id={pharmacyId}";
                db.ExecuteNonQuery(query);

                MessageBox.Show("Pharmacy Updated Successfully!");
                LoadPharmacies();
            }
            else
            {
                MessageBox.Show("Please select a pharmacy to update.");
            }
        }
    }
}
