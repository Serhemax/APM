using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace APM
{
	public partial class TransactionForm : Form
	{
		private string connectionString;

		public TransactionForm(string connectionString)
		{
			InitializeComponent();
			try
			{
				this.connectionString = connectionString;
				LoadTransactions();
				LoadItems();
				LoadClients();
				LoadTransactionTypes();
			}
			catch { MessageBox.Show("З'єднання розірвано"); }
		}

		private void LoadTransactions()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				// Запит, що об'єднує таблиці Transaction і TransactionType для отримання назв операцій
				string query = "SELECT t.TransactionID, i.ItemName, c.LastName + ' ' + c.FirstName AS ClientFullName, " +
							   "tt.Description AS TransactionType, t.TransactionDate, t.Amount, t.StoragePeriod " +
							   "FROM [Transaction] t " +
							   "JOIN Item i ON t.ItemID = i.ItemID " +
							   "JOIN Client c ON t.ClientID = c.ClientID " +
							   "JOIN TransactionType tt ON t.TransactionTypeID = tt.TransactionTypeID";

				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				dataGridViewTransactions.DataSource = dataTable;
			}
		}

		private void LoadItems()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter("SELECT ItemID, ItemName FROM Item", connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				comboBoxItems.DisplayMember = "ItemName";
				comboBoxItems.ValueMember = "ItemID";
				comboBoxItems.DataSource = dataTable;
				Utils.TextUpdate(comboBoxItems, dataTable, "ItemName");
			}
		}

		private void LoadTransactionTypes()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter("SELECT TransactionTypeID, Description FROM TransactionType", connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				transactionTypeComboBox.DisplayMember = "Description";
				transactionTypeComboBox.ValueMember = "TransactionTypeID";
				transactionTypeComboBox.DataSource = dataTable;
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

		private void btnAddTransaction_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{

					string query = "INSERT INTO [Transaction] (ItemID, ClientID, TransactionTypeID, TransactionDate, Amount) " +
								   "VALUES (@ItemID, @ClientID, @TransactionType, @TransactionDate, @Amount)";
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ItemID", comboBoxItems.SelectedValue);
					command.Parameters.AddWithValue("@ClientID", comboBoxClients.SelectedValue);
					command.Parameters.AddWithValue("@TransactionType", transactionTypeComboBox.SelectedValue);
					command.Parameters.AddWithValue("@TransactionDate", dateTimePickerTransactionDate.Value);
					command.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text));
					connection.Open();
					command.ExecuteNonQuery();

					LoadTransactions();
				}
			}
			catch { MessageBox.Show("З'єднання розірвано, або Ціна не заданf"); }
		}

		private void btnEditTransaction_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewTransactions.SelectedRows.Count > 0)
				{
					int transactionId = Convert.ToInt32(dataGridViewTransactions.SelectedRows[0].Cells["TransactionID"].Value);
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						string query = "UPDATE [Transaction] SET ItemID = @ItemID, ClientID = @ClientID, " +
									   "TransactionTypeID = @TransactionType, TransactionDate = @TransactionDate, Amount = @Amount " +
									   "WHERE TransactionID = @TransactionID";
						SqlCommand command = new SqlCommand(query, connection);
						command.Parameters.AddWithValue("@ItemID", comboBoxItems.SelectedValue);
						command.Parameters.AddWithValue("@ClientID", comboBoxClients.SelectedValue);
						command.Parameters.AddWithValue("@TransactionType", transactionTypeComboBox.SelectedValue);
						command.Parameters.AddWithValue("@TransactionDate", dateTimePickerTransactionDate.Value);
						command.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text));
						command.Parameters.AddWithValue("@TransactionID", transactionId);
						connection.Open();
						command.ExecuteNonQuery();
						LoadTransactions();
					}
				}
			}
			catch { MessageBox.Show("З'єднання розірвано, або Ціна не задана"); }
		}

		private void btnDeleteTransaction_Click(object sender, EventArgs e)
		{
			if (dataGridViewTransactions.SelectedRows.Count > 0)
			{
				int transactionId = Convert.ToInt32(dataGridViewTransactions.SelectedRows[0].Cells["TransactionID"].Value);
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "DELETE FROM [Transaction] WHERE TransactionID = @TransactionID";
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@TransactionID", transactionId);
					connection.Open();
					command.ExecuteNonQuery();
					LoadTransactions();
				}
			}
		}

		private void btnSearchTransaction_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM [Transaction] WHERE TransactionType LIKE @Search";
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				dataGridViewTransactions.DataSource = dataTable;
			}
		}

		private void TransactionForm_Load(object sender, EventArgs e)
		{

		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string filePath = "transaction.csv";
			try
			{
				using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
				{
					// Write the header row
					for (int i = 0; i < dataGridViewTransactions.Columns.Count; i++)
					{
						writer.Write(dataGridViewTransactions.Columns[i].HeaderText);
						if (i < dataGridViewTransactions.Columns.Count - 1)
						{
							writer.Write(",");
						}
					}
					writer.WriteLine();

					// Write the data rows
					foreach (DataGridViewRow row in dataGridViewTransactions.Rows)
					{
						if (!row.IsNewRow) // Ignore the new row placeholder
						{
							for (int i = 0; i < dataGridViewTransactions.Columns.Count; i++)
							{
								writer.Write(row.Cells[i].Value?.ToString());
								if (i < dataGridViewTransactions.Columns.Count - 1)
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
