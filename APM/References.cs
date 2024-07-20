using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM
{
	public partial class References : Form
	{
		private string connectionString;

		public References(string connectionString)
		{
			InitializeComponent();
			this.connectionString = connectionString;
		}

		private void btnClients_Click(object sender, EventArgs e)
		{
			using (ClientForm clientsForm = new ClientForm(connectionString))
			{
				clientsForm.ShowDialog();
			}
		}

		private void btnItems_Click(object sender, EventArgs e)
		{
			using (ItemForm itemsForm = new ItemForm(connectionString))
			{
				itemsForm.ShowDialog();
			}
		}

		private void btnTransactions_Click(object sender, EventArgs e)
		{
			using (TransactionForm transactionsForm = new TransactionForm(connectionString))
			{
				transactionsForm.ShowDialog();
			}
		}
	}
}
