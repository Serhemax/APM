namespace APM
{
	partial class References
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClients = new Button();
            btnItems = new Button();
            btnTransactions = new Button();
            SuspendLayout();
            // 
            // btnClients
            // 
            btnClients.Location = new Point(12, 12);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(124, 30);
            btnClients.TabIndex = 0;
            btnClients.Text = "Clients";
            btnClients.Click += btnClients_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(12, 48);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(124, 30);
            btnItems.TabIndex = 1;
            btnItems.Text = "Items";
            btnItems.Click += btnItems_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Location = new Point(12, 84);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(124, 30);
            btnTransactions.TabIndex = 2;
            btnTransactions.Text = "Transactions";
            btnTransactions.Click += btnTransactions_Click;
            // 
            // References
            // 
            ClientSize = new Size(148, 118);
            Controls.Add(btnClients);
            Controls.Add(btnItems);
            Controls.Add(btnTransactions);
            Name = "References";
            ResumeLayout(false);
        }


        private Button btnClients;
		private Button btnItems;
		private Button btnTransactions;

		#endregion
	}
}