namespace APM
{
	partial class ItemEvaluationForm
	{

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private TextBox txtItemName;
		private TextBox txtEstimatedValue;
		private TextBox txtPledgedAmount;
		private ComboBox comboBoxClients;
		private Button btnAddClient;
		private Button btnReceiveItem;
		private Label lblItemName;
		private Label lblEstimatedValue;
		private Label lblPledgedAmount;
		private Label lblClient;

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
            txtItemName = new TextBox();
            txtEstimatedValue = new TextBox();
            txtPledgedAmount = new TextBox();
            comboBoxClients = new ComboBox();
            btnAddClient = new Button();
            btnReceiveItem = new Button();
            lblItemName = new Label();
            lblEstimatedValue = new Label();
            lblPledgedAmount = new Label();
            lblClient = new Label();
            label1 = new Label();
            numericUpDownMonth = new NumericUpDown();
            CategoryComboBox = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonth).BeginInit();
            SuspendLayout();
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(123, 30);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(367, 27);
            txtItemName.TabIndex = 0;
            // 
            // txtEstimatedValue
            // 
            txtEstimatedValue.Location = new Point(183, 108);
            txtEstimatedValue.Name = "txtEstimatedValue";
            txtEstimatedValue.Size = new Size(100, 27);
            txtEstimatedValue.TabIndex = 2;
            // 
            // txtPledgedAmount
            // 
            txtPledgedAmount.Location = new Point(183, 144);
            txtPledgedAmount.Name = "txtPledgedAmount";
            txtPledgedAmount.Size = new Size(100, 27);
            txtPledgedAmount.TabIndex = 3;
            // 
            // comboBoxClients
            // 
            comboBoxClients.Location = new Point(70, 216);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(213, 28);
            comboBoxClients.TabIndex = 4;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(289, 216);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(201, 28);
            btnAddClient.TabIndex = 5;
            btnAddClient.Text = "Add Client";
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnReceiveItem
            // 
            btnReceiveItem.Location = new Point(3, 250);
            btnReceiveItem.Name = "btnReceiveItem";
            btnReceiveItem.Size = new Size(487, 30);
            btnReceiveItem.TabIndex = 6;
            btnReceiveItem.Text = "Receive Item";
            btnReceiveItem.Click += btnReceiveItem_Click;
            // 
            // lblItemName
            // 
            lblItemName.Location = new Point(3, 30);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(126, 20);
            lblItemName.TabIndex = 7;
            lblItemName.Text = "Item Name";
            // 
            // lblEstimatedValue
            // 
            lblEstimatedValue.Location = new Point(3, 111);
            lblEstimatedValue.Name = "lblEstimatedValue";
            lblEstimatedValue.Size = new Size(156, 27);
            lblEstimatedValue.TabIndex = 9;
            lblEstimatedValue.Text = "Estimated Value";
            // 
            // lblPledgedAmount
            // 
            lblPledgedAmount.Location = new Point(3, 147);
            lblPledgedAmount.Name = "lblPledgedAmount";
            lblPledgedAmount.Size = new Size(174, 30);
            lblPledgedAmount.TabIndex = 10;
            lblPledgedAmount.Text = "Pledged Amount";
            // 
            // lblClient
            // 
            lblClient.Location = new Point(3, 219);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(105, 20);
            lblClient.TabIndex = 11;
            lblClient.Text = "Client";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 185);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 12;
            label1.Text = "Storage Term (months):";
            // 
            // numericUpDownMonth
            // 
            numericUpDownMonth.Location = new Point(224, 183);
            numericUpDownMonth.Name = "numericUpDownMonth";
            numericUpDownMonth.Size = new Size(59, 27);
            numericUpDownMonth.TabIndex = 13;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Location = new Point(83, 68);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(407, 28);
            CategoryComboBox.TabIndex = 14;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 15;
            label2.Text = "Category:";
            // 
            // ItemEvaluationForm
            // 
            ClientSize = new Size(501, 289);
            Controls.Add(CategoryComboBox);
            Controls.Add(label2);
            Controls.Add(numericUpDownMonth);
            Controls.Add(label1);
            Controls.Add(txtItemName);
            Controls.Add(txtEstimatedValue);
            Controls.Add(txtPledgedAmount);
            Controls.Add(comboBoxClients);
            Controls.Add(btnAddClient);
            Controls.Add(btnReceiveItem);
            Controls.Add(lblItemName);
            Controls.Add(lblEstimatedValue);
            Controls.Add(lblPledgedAmount);
            Controls.Add(lblClient);
            Name = "ItemEvaluationForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private NumericUpDown numericUpDownMonth;
		private ComboBox CategoryComboBox;
		private Label label2;
	}
}