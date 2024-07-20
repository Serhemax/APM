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

namespace APM
{
	public partial class AddClientForm : Form
	{
		private string connectionString;
		public AddClientForm(string connectionString)
		{
			try
			{
				InitializeComponent();
				this.connectionString = connectionString;
				LoadAddresses();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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

					MessageBox.Show("Client added succesfuly!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error adding client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                adressComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                adressComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

				adressComboBox.DisplayMember = "Street";
				adressComboBox.ValueMember = "Street";
				adressComboBox.DataSource = dataTable;

				Utils.TextUpdate(adressComboBox, dataTable, "Street");

			}
		}
	}
}
