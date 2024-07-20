using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APM
{
    public partial class ItemEvaluationForm : Form
    {
        private string connectionString;

        public ItemEvaluationForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            LoadClients();
            LoadCategory();
        }

        private void LoadClients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ClientID, LastName + ' ' + FirstName + ' ' + MiddleName AS FullName FROM Client";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable clientsTable = new DataTable();
                adapter.Fill(clientsTable);

                comboBoxClients.DataSource = clientsTable;
                comboBoxClients.DisplayMember = "FullName";
                comboBoxClients.ValueMember = "ClientID";

                Utils.TextUpdate(comboBoxClients, clientsTable, "FullName");
            }
        }

        private void LoadCategory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, RTRIM(CategoryName) AS CategoryName FROM Category_Item";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable clientsTable = new DataTable();
                adapter.Fill(clientsTable);

                CategoryComboBox.DataSource = clientsTable;
                CategoryComboBox.DisplayMember = "CategoryName";
                CategoryComboBox.ValueMember = "CategoryID";
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (AddClientForm addClientForm = new AddClientForm(connectionString))
            {
                addClientForm.ShowDialog();
                LoadClients();
            }
        }

        private void btnReceiveItem_Click(object sender, EventArgs e)
        {
            string itemName;
            int categoryId;
            decimal estimatedValue;
            decimal pledgedAmount;
            int clientId;
            int storagePeriod;
            try
            {
                itemName = txtItemName.Text;
                categoryId = (int)CategoryComboBox.SelectedValue;
                estimatedValue = decimal.Parse(txtEstimatedValue.Text);
                pledgedAmount = decimal.Parse(txtPledgedAmount.Text);
                clientId = (int)comboBoxClients.SelectedValue;
                storagePeriod = (int)numericUpDownMonth.Value;
            }
            catch
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryItem = "INSERT INTO Item (ClientID, CategoryID, ItemName, EstimatedValue) VALUES (@ClientID, @CategoryID, @ItemName, @EstimatedValue)";
                        SqlCommand commandItem = new SqlCommand(queryItem, connection, transaction);
                        commandItem.Parameters.AddWithValue("@ClientID", clientId);
                        commandItem.Parameters.AddWithValue("@CategoryID", categoryId);
                        commandItem.Parameters.AddWithValue("@ItemName", itemName);
                        commandItem.Parameters.AddWithValue("@EstimatedValue", estimatedValue);
                        commandItem.ExecuteNonQuery();

                        string query = "SELECT ItemID FROM Item WHERE ItemName LIKE @itemName AND ClientID = @ClientID AND EstimatedValue = @EstimatedValue";
                        SqlCommand command = new SqlCommand(query, connection, transaction);
                        command.Parameters.AddWithValue("@itemName", itemName);
                        command.Parameters.AddWithValue("@ClientID", clientId);
                        command.Parameters.AddWithValue("@EstimatedValue", estimatedValue);
                        int itemID = (int)command.ExecuteScalar();

                        string queryTransaction = "INSERT INTO [Transaction] (ItemID, ClientID, TransactionTypeID, TransactionDate, Amount, StoragePeriod) " +
                                                  "VALUES (@ItemID, @ClientID, 1, GETDATE(), @Amount, @StoragePeriod)";
                        SqlCommand commandTransaction = new SqlCommand(queryTransaction, connection, transaction);
                        commandTransaction.Parameters.AddWithValue("@ItemID", itemID);
                        commandTransaction.Parameters.AddWithValue("@ClientID", clientId);
                        commandTransaction.Parameters.AddWithValue("@Amount", pledgedAmount);
                        commandTransaction.Parameters.AddWithValue("@StoragePeriod", storagePeriod);
                        commandTransaction.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Item successfully received!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error receiving item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
