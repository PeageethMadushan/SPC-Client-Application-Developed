using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC
{
    public partial class DrugsForm : Form
    {
        DatabaseManager db = new DatabaseManager();

        public DrugsForm()
        {
            InitializeComponent();
            LoadDrugs();
            LoadSUppliers();
        }

        private void LoadDrugs()
        {
            string query = "SELECT * FROM drug";
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewDrugs.DataSource = dt;
        }

        private string connectionString = "Data Source=Aspect9n\\SQLEXPRESS;Initial Catalog=SPC;Integrated Security=True; TrustServerCertificate=True;";

        private void LoadSUppliers()
        {
            string query = "SELECT * from supplier";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable studentTable = new DataTable();
                    adapter.Fill(studentTable);
                    
                    comboBox1.DataSource = studentTable;
                    comboBox1.DisplayMember = "suppliername";
                    comboBox1.ValueMember = "supplierid";       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int supp = Convert.ToInt32(comboBox1.SelectedValue);
            
            string maxIdQuery = "SELECT MAX(id) FROM drug";
            DataTable dt = db.ExecuteQuery(maxIdQuery);
            int newId = 1;
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                newId = Convert.ToInt32(dt.Rows[0][0]) + 1; 
            }
            string query = $"INSERT INTO drug (id, name, price, quantity, supplierid) VALUES ({newId}, '{name}', {price}, {quantity}, {supp})";
            db.ExecuteNonQuery(query);

            MessageBox.Show("Drug Added Successfully!");
            LoadDrugs();
        }
   

        private void btnUpdateDrug_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrugs.SelectedRows.Count > 0)
            {
                int drugId = Convert.ToInt32(dataGridViewDrugs.SelectedRows[0].Cells["id"].Value);
                string name = txtName.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                string query = "UPDATE drug SET name = @name, price = @price, quantity = @quantity WHERE id = @id";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@name", name),
                    new SqlParameter("@price", price),
                    new SqlParameter("@quantity", quantity),
                    new SqlParameter("@id", drugId));

                MessageBox.Show("Drug Updated Successfully!");
                LoadDrugs();
            }
            else
            {
                MessageBox.Show("Please select a drug to update.");
            }
        }

        private void btnDeleteDrug_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrugs.SelectedRows.Count > 0)
            {
                int drugId = Convert.ToInt32(dataGridViewDrugs.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this drug?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM drug WHERE id = @id";
                    db.ExecuteNonQuery(query, new SqlParameter("@id", drugId));

                    MessageBox.Show("Drug Deleted Successfully!");
                    LoadDrugs();
                }
            }
            else
            {
                MessageBox.Show("Please select a drug to delete.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
