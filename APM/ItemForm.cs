using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace APM
{
    public partial class ItemForm : Form
    {
        private string connectionString;

        public ItemForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            try
            {
                LoadItems();
                LoadClients();
                LoadCategory();
            }
            catch
            {
                MessageBox.Show("Connection lost, or Price for the item, or storage period not set");
            }
        }

        private void LoadItems()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        i.ItemID,
                        i.ItemName,
                        c.LastName + ' ' + c.FirstName AS FullName,
                        cat.CategoryName,
                        i.EstimatedValue
                    FROM 
                        Item i
                    JOIN 
                        Client c ON i.ClientID = c.ClientID
                    JOIN 
                        Category_Item cat ON i.CategoryID = cat.CategoryID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewItems.DataSource = dataTable;
                SetColumnHeaders();
            }
        }

        private void LoadClients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ClientID, LastName + ' ' + FirstName AS FullName FROM Client", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                comboBoxClients.DisplayMember = "FullName";
                comboBoxClients.ValueMember = "ClientID";
                comboBoxClients.DataSource = dataTable;

                Utils.TextUpdate(comboBoxClients, dataTable, "FullName");
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

        private void SetColumnHeaders()
        {
            if (dataGridViewItems.Columns["ItemID"] != null) dataGridViewItems.Columns["ItemID"].HeaderText = "Item ID";
            if (dataGridViewItems.Columns["FullName"] != null) dataGridViewItems.Columns["FullName"].HeaderText = "Client Name";
            if (dataGridViewItems.Columns["CategoryName"] != null) dataGridViewItems.Columns["CategoryName"].HeaderText = "Category";
            if (dataGridViewItems.Columns["ItemName"] != null) dataGridViewItems.Columns["ItemName"].HeaderText = "Item Name";
            if (dataGridViewItems.Columns["EstimatedValue"] != null) dataGridViewItems.Columns["EstimatedValue"].HeaderText = "Estimated Value";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Item (ClientID, ItemName, EstimatedValue, PledgedAmount, PledgeDate, StoragePeriod) " +
                                   "VALUES (@ClientID, @ItemName, @EstimatedValue, @PledgedAmount, @PledgeDate, @StoragePeriod)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClientID", comboBoxClients.SelectedValue);
                    command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                    command.Parameters.AddWithValue("@EstimatedValue", Convert.ToDecimal(txtEstimatedValue.Text));
                    command.Parameters.AddWithValue("@PledgedAmount", Convert.ToDecimal(txtPledgedAmount.Text));
                    command.Parameters.AddWithValue("@PledgeDate", dateTimePickerPledgeDate.Value);
                    command.Parameters.AddWithValue("@StoragePeriod", Convert.ToInt32(txtStoragePeriod.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadItems();
                }
            }
            catch
            {
                MessageBox.Show("Connection lost, or Price for the item, or storage period not set");
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewItems.SelectedRows.Count > 0)
                {
                    int itemId = Convert.ToInt32(dataGridViewItems.SelectedRows[0].Cells["ItemID"].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Item SET ClientID = @ClientID, ItemName = @ItemName, EstimatedValue = @EstimatedValue, " +
                                       "PledgedAmount = @PledgedAmount, PledgeDate = @PledgeDate, StoragePeriod = @StoragePeriod " +
                                       "WHERE ItemID = @ItemID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ClientID", comboBoxClients.SelectedValue);
                        command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                        command.Parameters.AddWithValue("@EstimatedValue", Convert.ToDecimal(txtEstimatedValue.Text));
                        command.Parameters.AddWithValue("@PledgedAmount", Convert.ToDecimal(txtPledgedAmount.Text));
                        command.Parameters.AddWithValue("@PledgeDate", dateTimePickerPledgeDate.Value);
                        command.Parameters.AddWithValue("@StoragePeriod", Convert.ToInt32(txtStoragePeriod.Text));
                        command.Parameters.AddWithValue("@ItemID", itemId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        LoadItems();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Connection lost, or Price for the item, or storage period not set");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dataGridViewItems.SelectedRows[0].Cells["ItemID"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Item WHERE ItemID = @ItemID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ItemID", itemId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadItems();
                }
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Item WHERE ItemName LIKE @Search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewItems.DataSource = dataTable;
                SetColumnHeaders();
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string filePath = "items.csv";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // Write the header row
                    for (int i = 0; i < dataGridViewItems.Columns.Count; i++)
                    {
                        writer.Write(dataGridViewItems.Columns[i].HeaderText);
                        if (i < dataGridViewItems.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Write the data rows
                    foreach (DataGridViewRow row in dataGridViewItems.Rows)
                    {
                        if (!row.IsNewRow) // Ignore the new row placeholder
                        {
                            for (int i = 0; i < dataGridViewItems.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value?.ToString());
                                if (i < dataGridViewItems.Columns.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }
                            writer.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
 