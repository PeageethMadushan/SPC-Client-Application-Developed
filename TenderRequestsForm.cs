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
    public partial class TenderRequestsForm : Form
    {
        DatabaseManager db = new DatabaseManager();

        public TenderRequestsForm()
        {
            InitializeComponent();
            LoadTenders();
        }

        // Load Tender Requests
        private void LoadTenders()
        {
            string query = "SELECT id, suppliername, drugid, drugname, drugprice, accepted FROM tender";
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewTenders.DataSource = dt;
        }

        private void btnApproveTender_Click(object sender, EventArgs e)
        {
            if (dataGridViewTenders.SelectedRows.Count > 0)
            {
                int tenderId = Convert.ToInt32(dataGridViewTenders.SelectedRows[0].Cells["id"].Value);

                string query = $"UPDATE tender SET accepted = 1 WHERE id = {tenderId}";
                db.ExecuteNonQuery(query);

                MessageBox.Show("Tender Approved!");
                LoadTenders();
            }
            else
            {
                MessageBox.Show("Please select a tender to approve.");
            }
        }

        private void btnRejectTender_Click(object sender, EventArgs e)
        {
            if (dataGridViewTenders.SelectedRows.Count > 0)
            {
                int tenderId = Convert.ToInt32(dataGridViewTenders.SelectedRows[0].Cells["id"].Value);

                string query = $"DELETE FROM tender WHERE id = {tenderId}";
                db.ExecuteNonQuery(query);

                MessageBox.Show("Tender Rejected!");
                LoadTenders();
            }
            else
            {
                MessageBox.Show("Please select a tender to reject.");
            }
        }
    }
}
