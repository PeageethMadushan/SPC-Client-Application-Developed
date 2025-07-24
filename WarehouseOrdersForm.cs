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
    public partial class WarehouseOrdersForm : Form
    {
        DatabaseManager db = new DatabaseManager();

        public WarehouseOrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string query = "SELECT * FROM orders";
            DataTable dt = db.ExecuteQuery(query);
            dgvOrders.DataSource = dt;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderid"].Value);
                int drugId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["drugid"].Value);
                int quantity = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["quantity"].Value);

                if (CheckStockAvailability(drugId, quantity))
                {
                    ProcessOrder(orderId, "Approved");
                    UpdateStock(drugId, quantity); // Deduct stock

                    MessageBox.Show("Order Approved! Stock Updated.");
                }
                else
                {
                    MessageBox.Show("Insufficient stock to approve this order.");
                }

                LoadOrders();
            }
            else
            {
                MessageBox.Show("Please select an order to approve.");
            }
        }
        
        private bool CheckStockAvailability(int drugId, int quantity)
        {
            string query = "SELECT quantity FROM drug WHERE id = @drugId";
            DataTable dt = db.ExecuteQuery(query, new SqlParameter("@drugId", drugId));

            if (dt.Rows.Count > 0)
            {
                int currentStock = Convert.ToInt32(dt.Rows[0]["quantity"]);
                return currentStock >= quantity;
            }

            return false;
        }
        
        private void UpdateStock(int drugId, int quantity)
        {
            string query = "UPDATE drug SET quantity = quantity - @quantity WHERE id = @drugId";
            db.ExecuteNonQuery(query, new SqlParameter("@quantity", quantity), new SqlParameter("@drugId", drugId));
        }

        public void ProcessOrder(int orderId, string status)
        {
            string query = "UPDATE [orders] SET warehouse_status = @status WHERE orderid = @orderId";
            
            db.ExecuteNonQuery(query, new SqlParameter("@status", status), new SqlParameter("@orderId", orderId));

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderid"].Value);

                ProcessOrder(orderId, "Rejected");

                MessageBox.Show("Order Rejected!");
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Please select an order to reject.");
            }
        }
    }
}
