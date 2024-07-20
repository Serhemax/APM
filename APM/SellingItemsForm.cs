using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace APM
{
    public partial class SellingItemsForm : Form
    {
        private string connectionString;

        public SellingItemsForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            LoadItemsForSale();
            LoadClients();
        }

        private void LoadItemsForSale()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT i.ItemID, i.ItemName, t.Amount FROM Item i " +
                               "JOIN [Transaction] t ON i.ItemID = t.ItemID " +
                               "WHERE t.TransactionTypeID = 1 AND " +
                               "DATEADD(DAY, t.StoragePeriod, t.TransactionDate) < GETDATE() AND " +
                               "i.IsSold = 0";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);
                dataGridViewItems.DataSource = itemsTable;
            }
        }

        private void LoadItemsForRedemption()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT i.ItemID, i.ItemName, t.Amount FROM Item i " +
                               "JOIN [Transaction] t ON i.ItemID = t.ItemID " +
                               "WHERE t.TransactionTypeID = 1 AND " +
                               "DATEADD(DAY, t.StoragePeriod, t.TransactionDate) >= GETDATE() AND " +
                               "i.IsSold = 0";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);
                dataGridViewItems.DataSource = itemsTable;
            }
        }

        private void chkRedeem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedeem.Checked)
            {
                groupBoxRedeem.Enabled = true;
                LoadItemsForRedemption();
                LoadClients();
            }
            else
            {
                groupBoxRedeem.Enabled = false;
                LoadItemsForSale();
            }
        }

        private void LoadClients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT c.ClientID, c.LastName + ' ' + c.FirstName AS FullName " +
                               "FROM Client c " +
                               "JOIN [Transaction] t ON c.ClientID = t.ClientID " +
                               "JOIN Item i ON t.ItemID = i.ItemID " +
                               "WHERE t.TransactionTypeID = 1 AND i.IsSold = 0";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable clientsTable = new DataTable();
                adapter.Fill(clientsTable);

                cmbClients.DataSource = clientsTable;
                cmbClients.DisplayMember = "FullName";
                cmbClients.ValueMember = "ClientID";

                Utils.TextUpdate(cmbClients, clientsTable, "FullName");
            }
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClients.SelectedValue != null)
            {
                if (cmbClients.SelectedValue is DataRowView selectedRow)
                {
                    int clientId = Convert.ToInt32(selectedRow["ClientID"]);
                    LoadClientItems(clientId);
                }
                else if (cmbClients.SelectedValue is int clientId)
                {
                    LoadClientItems(clientId);
                }
            }
        }

        private void LoadClientItems(int clientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT i.ItemID, i.ItemName, t.Amount FROM Item i " +
                               "JOIN [Transaction] t ON i.ItemID = t.ItemID " +
                               "WHERE t.TransactionTypeID = 1 AND i.ClientID = @ClientID AND " +
                               "i.IsSold = 0";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", clientId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable clientItemsTable = new DataTable();
                adapter.Fill(clientItemsTable);

                if (clientItemsTable.Rows.Count > 0)
                {
                    dataGridViewItems.DataSource = clientItemsTable;
                }
                else
                {
                    MessageBox.Show("Client has no items in the pawn shop.");
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewItems.SelectedRows)
                {
                    int itemId = (int)row.Cells["ItemID"].Value;
                    CompleteTransaction(itemId, 3); // TransactionTypeID = 3 for sale
                }

                LoadItemsForSale();
                MessageBox.Show("Item(s) sold successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select an item to sell.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRedeem_Click(object sender, EventArgs e)
        {
            if (cmbClients.SelectedValue == null || cmbClients.SelectedIndex == -1)
            {
                MessageBox.Show("Select a client.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                int clientId = (int)cmbClients.SelectedValue;
                foreach (DataGridViewRow row in dataGridViewItems.SelectedRows)
                {
                    int itemId = (int)row.Cells["ItemID"].Value;
                    CompleteTransaction(itemId, 2); // TransactionTypeID = 2 for redemption
                }

                LoadItemsForRedemption();
                MessageBox.Show("Item(s) redeemed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select an item to redeem.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CompleteTransaction(int itemId, int transactionTypeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [Transaction] (ItemID, ClientID, TransactionTypeID, TransactionDate, Amount) " +
                               "SELECT ItemID, ClientID, @TransactionTypeID, GETDATE(), EstimatedValue FROM Item " +
                               "WHERE ItemID = @ItemID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItemID", itemId);
                command.Parameters.AddWithValue("@TransactionTypeID", transactionTypeId);
                connection.Open();
                command.ExecuteNonQuery();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Item SET IsSold = 1 WHERE ItemID = @ItemID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItemID", itemId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
