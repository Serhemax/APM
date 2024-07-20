namespace APM
{
	partial class MainForm
	{

		/// <summary>
		///  Змінна дизайнера.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Button btnReceivingAppraising;
		private Button btnSellingItems;
		private Button btnDirectories;
		private Button btnReports;

		/// <summary>
		///  Звільнити всі використані ресурси.
		/// </summary>
		/// <param name="disposing">true, якщо управляючі ресурси потрібно звільнити, інакше false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Код, згенерований конструктором форм Windows

        /// <summary>
        ///  Метод, необхідний для підтримки конструктора — не редагуйте
        ///  його вміст за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            btnReceivingAppraising = new Button();
            btnSellingItems = new Button();
            btnDirectories = new Button();
            btnReports = new Button();
            SuspendLayout();
            // 
            // btnReceivingAppraising
            // 
            btnReceivingAppraising.Location = new Point(12, 12);
            btnReceivingAppraising.Name = "btnReceivingAppraising";
            btnReceivingAppraising.Size = new Size(150, 50);
            btnReceivingAppraising.TabIndex = 0;
            btnReceivingAppraising.Text = "Receiving and Appraising Items";
            btnReceivingAppraising.UseVisualStyleBackColor = true;
            btnReceivingAppraising.Click += btnReceivingAppraising_Click;
            // 
            // btnSellingItems
            // 
            btnSellingItems.Location = new Point(203, 12);
            btnSellingItems.Name = "btnSellingItems";
            btnSellingItems.Size = new Size(150, 50);
            btnSellingItems.TabIndex = 1;
            btnSellingItems.Text = "Selling and Redeeming Items";
            btnSellingItems.UseVisualStyleBackColor = true;
            btnSellingItems.Click += btnSellingItems_Click;
            // 
            // btnDirectories
            // 
            btnDirectories.Location = new Point(12, 80);
            btnDirectories.Name = "btnDirectories";
            btnDirectories.Size = new Size(150, 50);
            btnDirectories.TabIndex = 2;
            btnDirectories.Text = "Directories";
            btnDirectories.UseVisualStyleBackColor = true;
            btnDirectories.Click += btnDirectories_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(203, 80);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(150, 50);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(365, 142);
            Controls.Add(btnReports);
            Controls.Add(btnDirectories);
            Controls.Add(btnSellingItems);
            Controls.Add(btnReceivingAppraising);
            Name = "MainForm";
            Text = "Pawnshop Management";
            ResumeLayout(false);
        }

        #endregion
    }
}
