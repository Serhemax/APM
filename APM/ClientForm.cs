using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace APM
{
	public partial class ClientForm : Form
	{
		private string connectionString;

		public ClientForm(string connectionString)
		{
			try
			{
				InitializeComponent();
				this.connectionString = connectionString;
				LoadClients();
				LoadAddresses();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadAddresses()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT NAME_REG AS Street FROM region " +
							   "UNION " +
							   "SELECT NAME_SR FROM strit";

				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				adressComboBox.DisplayMember = "Street";
				adressComboBox.ValueMember = "Street";
				adressComboBox.DataSource = dataTable;
				Utils.TextUpdate(adressComboBox, dataTable, "Street");
			}
		}

		private void LoadClients()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Client", connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				dataGridViewClients.DataSource = dataTable;
			}
		}

		private string GetRegion(SqlConnection connection)
		{
			string regionQuery = "SELECT r.NAME_REG " +
								 "FROM strit s " +
								 "JOIN region r ON s.CODE_REGBI = r.CODE_REGBI " +
								 "WHERE s.NAME_SR = @StreetName";
			SqlCommand regionCommand = new SqlCommand(regionQuery, connection);
			regionCommand.Parameters.AddWithValue("@StreetName", adressComboBox.Text);

			connection.Open();
			string regionName = (string)regionCommand.ExecuteScalar();
			connection.Close();
			return regionName;
		}

		private void btnAddClient_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "INSERT INTO Client (LastName, FirstName, MiddleName, Region, Street, Building, Flat, Phone1, Phone2) " +
								   "VALUES (@LastName, @FirstName, @MiddleName, @Region, @Street, @Building, @Flat, @Phone1, @Phone2)";
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@LastName", txtLastName.Text);
					command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
					command.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
					command.Parameters.AddWithValue("@Region", GetRegion(connection));
					command.Parameters.AddWithValue("@Street", adressComboBox.Text);
					command.Parameters.AddWithValue("@Building", txtBuilding.Text);
					command.Parameters.AddWithValue("@Flat", txtFlat.Text);
					command.Parameters.AddWithValue("@Phone1", txtPhone1.Text);
					command.Parameters.AddWithValue("@Phone2", txtPhone2.Text);

					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();

					LoadClients();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error adding client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEditClient_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewClients.SelectedRows.Count > 0)
				{
					int clientId = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["ClientID"].Value);
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						string query = "UPDATE Client SET LastName = @LastName, FirstName = @FirstName, " +
									   "MiddleName = @MiddleName, " +
									   "Region = @Region, Street = @Street, Building = @Building, Flat = @Flat, " +
									   "Phone1 = @Phone1, Phone2 = @Phone2 " +
									   "WHERE ClientID = @ClientID";
						SqlCommand command = new SqlCommand(query, connection);
						command.Parameters.AddWithValue("@LastName", txtLastName.Text);
						command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
						command.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
						command.Parameters.AddWithValue("@Region", GetRegion(connection));
						command.Parameters.AddWithValue("@Street", adressComboBox.Text);
						command.Parameters.AddWithValue("@Building", txtBuilding.Text);
						command.Parameters.AddWithValue("@Flat", txtFlat.Text);
						command.Parameters.AddWithValue("@Phone1", txtPhone1.Text);
						command.Parameters.AddWithValue("@Phone2", txtPhone2.Text);
						command.Parameters.AddWithValue("@ClientID", clientId);
						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();

						LoadClients();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error editing client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDeleteClient_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewClients.SelectedRows.Count > 0)
				{
					int clientId = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["ClientID"].Value);
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						string query = "DELETE FROM Client WHERE ClientID = @ClientID";
						SqlCommand command = new SqlCommand(query, connection);
						command.Parameters.AddWithValue("@ClientID", clientId);
						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();

						LoadClients();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error deleting client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSearchClient_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "SELECT * FROM Client WHERE LastName LIKE @Search OR FirstName LIKE @Search";
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					dataGridViewClients.DataSource = dataTable;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error searching clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string filePath = "clients.csv";

			try
			{
				using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
				{
					// Write header row
					for (int i = 0; i < dataGridViewClients.Columns.Count; i++)
					{
						writer.Write(dataGridViewClients.Columns[i].HeaderText);
						if (i < dataGridViewClients.Columns.Count - 1)
						{
							writer.Write(",");
						}
					}
					writer.WriteLine();

					// Write data rows
					foreach (DataGridViewRow row in dataGridViewClients.Rows)
					{
						if (!row.IsNewRow) // Ignore new row
						{
							for (int i = 0; i < dataGridViewClients.Columns.Count; i++)
							{
								writer.Write(row.Cells[i].Value?.ToString());
								if (i < dataGridViewClients.Columns.Count - 1)
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
		private void adressComboBox_TextUpdate(object sender, EventArgs e)
		{
		}

		private void adressComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

