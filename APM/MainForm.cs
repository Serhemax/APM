using System.Windows.Forms;

namespace APM
{
	public partial class MainForm : Form
	{
		private const string serverName = "SERHEMAX";
		private const string connectionString = $"Data Source={serverName};Initial Catalog=Lombard;Integrated Security=True;";

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnReceivingAppraising_Click(object sender, EventArgs e)
		{
			ItemEvaluationForm itemEvaluation = new ItemEvaluationForm(connectionString);
			itemEvaluation.Show();
		}

		private void btnSellingItems_Click(object sender, EventArgs e)
		{
			SellingItemsForm sellingItemsForm = new SellingItemsForm(connectionString);
			sellingItemsForm.Show();
		}

		private void btnDirectories_Click(object sender, EventArgs e)
		{
			References references = new References(connectionString);
			references.Show();
		}

		private void btnReports_Click(object sender, EventArgs e)
		{
			ReportsForm reportsForm = new ReportsForm(connectionString);
			reportsForm.Show();
		}
	}
}

