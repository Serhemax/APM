namespace APM
{
	partial class ItemForm
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
            dataGridViewItems = new DataGridView();
            comboBoxClients = new ComboBox();
            btnAddItem = new Button();
            btnEditItem = new Button();
            btnDeleteItem = new Button();
            btnSearchItem = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblClient = new Label();
            lblItemName = new Label();
            lblPledgedAmount = new Label();
            lblPledgeDate = new Label();
            lblStoragePeriod = new Label();
            txtItemName = new TextBox();
            txtPledgedAmount = new TextBox();
            dateTimePickerPledgeDate = new DateTimePicker();
            txtStoragePeriod = new TextBox();
            saveButton = new Button();
            lblEstimatedValue = new Label();
            txtEstimatedValue = new TextBox();
            CategoryComboBox = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(16, 18);
            dataGridViewItems.Margin = new Padding(4, 5, 4, 5);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(1320, 385);
            dataGridViewItems.TabIndex = 0;
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(171, 432);
            comboBoxClients.Margin = new Padding(4, 5, 4, 5);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(160, 28);
            comboBoxClients.TabIndex = 1;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(16, 597);
            btnAddItem.Margin = new Padding(4, 5, 4, 5);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(100, 35);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(124, 597);
            btnEditItem.Margin = new Padding(4, 5, 4, 5);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(100, 35);
            btnEditItem.TabIndex = 3;
            btnEditItem.Text = "Edit";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(232, 597);
            btnDeleteItem.Margin = new Padding(4, 5, 4, 5);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(100, 35);
            btnDeleteItem.TabIndex = 4;
            btnDeleteItem.Text = "Delete";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnSearchItem
            // 
            btnSearchItem.Location = new Point(1232, 427);
            btnSearchItem.Margin = new Padding(4, 5, 4, 5);
            btnSearchItem.Name = "btnSearchItem";
            btnSearchItem.Size = new Size(100, 35);
            btnSearchItem.TabIndex = 5;
            btnSearchItem.Text = "Search";
            btnSearchItem.UseVisualStyleBackColor = true;
            btnSearchItem.Click += btnSearchItem_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1017, 430);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(205, 27);
            txtSearch.TabIndex = 6;
            txtSearch.Text = "Search by name";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(954, 435);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(55, 20);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Search";
            lblSearch.Click += lblSearch_Click;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new Point(16, 437);
            lblClient.Margin = new Padding(4, 0, 4, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(47, 20);
            lblClient.TabIndex = 8;
            lblClient.Text = "Client";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(16, 494);
            lblItemName.Margin = new Padding(4, 0, 4, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(83, 20);
            lblItemName.TabIndex = 9;
            lblItemName.Text = "Item Name";
            // 
            // lblPledgedAmount
            // 
            lblPledgedAmount.AutoSize = true;
            lblPledgedAmount.Location = new Point(328, 494);
            lblPledgedAmount.Margin = new Padding(4, 0, 4, 0);
            lblPledgedAmount.Name = "lblPledgedAmount";
            lblPledgedAmount.Size = new Size(119, 20);
            lblPledgedAmount.TabIndex = 11;
            lblPledgedAmount.Text = "Pledged Amount";
            // 
            // lblPledgeDate
            // 
            lblPledgeDate.AutoSize = true;
            lblPledgeDate.Location = new Point(328, 540);
            lblPledgeDate.Margin = new Padding(4, 0, 4, 0);
            lblPledgeDate.Name = "lblPledgeDate";
            lblPledgeDate.Size = new Size(88, 20);
            lblPledgeDate.TabIndex = 12;
            lblPledgeDate.Text = "Pledge Date";
            // 
            // lblStoragePeriod
            // 
            lblStoragePeriod.AutoSize = true;
            lblStoragePeriod.Location = new Point(659, 494);
            lblStoragePeriod.Margin = new Padding(4, 0, 4, 0);
            lblStoragePeriod.Name = "lblStoragePeriod";
            lblStoragePeriod.Size = new Size(194, 20);
            lblStoragePeriod.TabIndex = 13;
            lblStoragePeriod.Text = "Storage Period (months)";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(171, 489);
            txtItemName.Margin = new Padding(4, 5, 4, 5);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(132, 27);
            txtItemName.TabIndex = 14;
            // 
            // txtPledgedAmount
            // 
            txtPledgedAmount.Location = new Point(464, 489);
            txtPledgedAmount.Margin = new Padding(4, 5, 4, 5);
            txtPledgedAmount.Name = "txtPledgedAmount";
            txtPledgedAmount.Size = new Size(132, 27);
            txtPledgedAmount.TabIndex = 16;
            // 
            // dateTimePickerPledgeDate
            // 
            dateTimePickerPledgeDate.Location = new Point(464, 534);
            dateTimePickerPledgeDate.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerPledgeDate.Name = "dateTimePickerPledgeDate";
            dateTimePickerPledgeDate.Size = new Size(265, 27);
            dateTimePickerPledgeDate.TabIndex = 17;
            // 
            // txtStoragePeriod
            // 
            txtStoragePeriod.Location = new Point(872, 491);
            txtStoragePeriod.Margin = new Padding(4, 5, 4, 5);
            txtStoragePeriod.Name = "txtStoragePeriod";
            txtStoragePeriod.Size = new Size(132, 27);
            txtStoragePeriod.TabIndex = 18;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1122, 597);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(214, 35);
            saveButton.TabIndex = 31;
            saveButton.Text = "Save to File";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // lblEstimatedValue
            // 
            lblEstimatedValue.AutoSize = true;
            lblEstimatedValue.Location = new Point(16, 540);
            lblEstimatedValue.Margin = new Padding(4, 0, 4, 0);
            lblEstimatedValue.Name = "lblEstimatedValue";
            lblEstimatedValue.Size = new Size(123, 20);
            lblEstimatedValue.TabIndex = 10;
            lblEstimatedValue.Text = "Estimated Value";
            // 
            // txtEstimatedValue
            // 
            txtEstimatedValue.Location = new Point(171, 535);
            txtEstimatedValue.Margin = new Padding(4, 5, 4, 5);
            txtEstimatedValue.Name = "txtEstimatedValue";
            txtEstimatedValue.Size = new Size(132, 27);
            txtEstimatedValue.TabIndex = 15;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Location = new Point(457, 429);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(407, 28);
            CategoryComboBox.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 437);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 33;
            label2.Text = "Category:";
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 640);
            Controls.Add(CategoryComboBox);
            Controls.Add(label2);
            Controls.Add(saveButton);
            Controls.Add(txtStoragePeriod);
            Controls.Add(dateTimePickerPledgeDate);
            Controls.Add(txtPledgedAmount);
            Controls.Add(txtEstimatedValue);
            Controls.Add(txtItemName);
            Controls.Add(lblStoragePeriod);
            Controls.Add(lblPledgeDate);
            Controls.Add(lblPledgedAmount);
            Controls.Add(lblEstimatedValue);
            Controls.Add(lblItemName);
            Controls.Add(lblClient);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearchItem);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnEditItem);
            Controls.Add(btnAddItem);
            Controls.Add(comboBoxClients);
            Controls.Add(dataGridViewItems);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ItemForm";
            Text = "Item Form";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
		private System.Windows.Forms.ComboBox comboBoxClients;
		private System.Windows.Forms.Button btnAddItem;
		private System.Windows.Forms.Button btnEditItem;
		private System.Windows.Forms.Button btnDeleteItem;
		private System.Windows.Forms.Button btnSearchItem;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Label lblClient;
		private System.Windows.Forms.Label lblItemName;
		private System.Windows.Forms.Label lblPledgedAmount;
		private System.Windows.Forms.Label lblPledgeDate;
		private System.Windows.Forms.Label lblStoragePeriod;
		private System.Windows.Forms.TextBox txtItemName;
		private System.Windows.Forms.TextBox txtPledgedAmount;
		private System.Windows.Forms.DateTimePicker dateTimePickerPledgeDate;
		private System.Windows.Forms.TextBox txtStoragePeriod;
		private Button saveButton;
		private Label lblEstimatedValue;
		private TextBox txtEstimatedValue;
		private ComboBox CategoryComboBox;
		private Label label2;
	}
}
