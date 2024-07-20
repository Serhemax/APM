using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace APM
{
	public partial class ReportsForm : Form
	{
		private string connectionString;

		public ReportsForm(string connectionString)
		{
			InitializeComponent();
			this.connectionString = connectionString;
		}

		private void btnGenerateReport_Click(object sender, EventArgs e)
		{
			DateTime startDate = dateTimePickerStart.Value.Date;
			DateTime endDate = dateTimePickerEnd.Value.Date;

			(int totalItemsReceived, decimal totalMoneyReceived) = GetTotalItemsAndMoneyWithType(startDate, endDate, 1);
			(int totalItemsRedeemed, decimal totalMoneyRedeemed) = GetTotalItemsAndMoneyWithType(startDate, endDate, 2);
			(int totalItemsSold, decimal totalMoneySold) = GetTotalItemsAndMoneyWithType(startDate, endDate, 3);
			decimal profit = totalMoneySold - (totalMoneyReceived + totalMoneyRedeemed);

			DisplayReport(startDate, endDate, totalItemsReceived, totalMoneyReceived, totalItemsRedeemed, totalMoneyRedeemed, totalItemsSold, totalMoneySold, profit);
		}

		private (int, decimal) GetTotalItemsAndMoneyWithType(DateTime startDate, DateTime endDate, int type)
		{
			int totalItems = 0;
			decimal totalMoney = 0;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT COUNT(*) FROM [Transaction] WHERE TransactionDate BETWEEN @StartDate AND @EndDate AND TransactionTypeID = @type";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@StartDate", startDate);
				command.Parameters.AddWithValue("@EndDate", endDate);
				command.Parameters.AddWithValue("@type", type);
				connection.Open();
				totalItems = (int)command.ExecuteScalar();
			}
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT SUM(Amount) FROM [Transaction] WHERE TransactionDate BETWEEN @StartDate AND @EndDate AND TransactionTypeID = @type";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@StartDate", startDate);
				command.Parameters.AddWithValue("@EndDate", endDate);
				command.Parameters.AddWithValue("@type", type);
				connection.Open();
				object result = command.ExecuteScalar();
				if (result != DBNull.Value)
				{
					totalMoney = (decimal)result;
				}
			}
			return (totalItems, totalMoney);
		}

		private void DisplayReport(DateTime startDate, DateTime endDate, int totalItemsReceived, decimal totalMoneyReceived,
								   int totalItemsRedeemed, decimal totalMoneyRedeemed, int totalItemsSold, decimal totalMoneySold, decimal profit)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Report for the period from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}");
			sb.AppendLine();
			sb.AppendLine($"Total items received: {totalItemsReceived}");
			sb.AppendLine($"Total value of received items: {totalMoneyReceived:C}");
			sb.AppendLine($"Total items redeemed: {totalItemsRedeemed}");
			sb.AppendLine($"Total value of redeemed items: {totalMoneyRedeemed:C}");
			sb.AppendLine($"Total items sold: {totalItemsSold}");
			sb.AppendLine($"Total sales amount: {totalMoneySold:C}");
			sb.AppendLine($"Profit: {profit:C}");

			MessageBox.Show(sb.ToString(), "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

    }
}
