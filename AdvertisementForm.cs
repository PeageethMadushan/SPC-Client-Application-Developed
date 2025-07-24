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
    public partial class AdvertisementForm : Form
    {
        DatabaseManager db = new DatabaseManager();

        public AdvertisementForm()
        {
            InitializeComponent();
            LoadAdvertisements();
        }

        private void LoadAdvertisements()
        {
            string query = "SELECT drugname, additional_details, advertisementid FROM advertisement";
            DataTable dt = db.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void btnPostAd_Click(object sender, EventArgs e)
        {
            string drugName = txtDrugName.Text;
            string details = txtDetails.Text;

            string query = $"INSERT INTO advertisement (drugname, additional_details) VALUES ('{drugName}', '{details}')";
            db.ExecuteNonQuery(query);
            LoadAdvertisements();
            MessageBox.Show("Advertisement Posted Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int drugId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["advertisementid"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this Advertisement?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM advertisement WHERE advertisementid = @id";
                    db.ExecuteNonQuery(query, new SqlParameter("@id", drugId));

                    MessageBox.Show("Advertisement Deleted Successfully!");
                    LoadAdvertisements();
                }
            }
            else
            {
                MessageBox.Show("Please select an Advertisement to delete.");
            }
        }
    }
}
