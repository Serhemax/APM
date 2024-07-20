namespace APM
{
	partial class ReportsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private DateTimePicker dateTimePickerStart;
		private DateTimePicker dateTimePickerEnd;
		private Button btnGenerateReport;

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
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            btnGenerateReport = new Button();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(12, 12);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 27);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(218, 12);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 27);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(424, 10);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(136, 29);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // ReportsForm
            // 
            ClientSize = new Size(569, 44);
            Controls.Add(btnGenerateReport);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "ReportsForm";
            Text = "Reports";
            ResumeLayout(false);
        }
        #endregion

    }
}