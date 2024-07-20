namespace APM
{
	partial class TransactionForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        private void InitializeComponent()
        {
            dataGridViewTransactions = new DataGridView();
            comboBoxItems = new ComboBox();
            comboBoxClients = new ComboBox();
            dateTimePickerTransactionDate = new DateTimePicker();
            txtAmount = new TextBox();
            btnAddTransaction = new Button();
            btnEditTransaction = new Button();
            btnDeleteTransaction = new Button();
            btnSearchTransaction = new Button();
            txtSearch = new TextBox();
            lblTransactionType = new Label();
            lblTransactionDate = new Label();
            lblAmount = new Label();
            lblItem = new Label();
            lblClient = new Label();
            lblSearch = new Label();
            transactionTypeComboBox = new ComboBox();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(16, 18);
            dataGridViewTransactions.Margin = new Padding(4, 5, 4, 5);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.Size = new Size(1307, 508);
            dataGridViewTransactions.TabIndex = 0;
            // 
            // comboBoxItems
            // 
            comboBoxItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxItems.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(16, 561);
            comboBoxItems.Margin = new Padding(4, 5, 4, 5);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(265, 28);
            comboBoxItems.TabIndex = 1;
            // 
            // comboBoxClients
            // 
            comboBoxClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClients.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(352, 561);
            comboBoxClients.Margin = new Padding(4, 5, 4, 5);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(265, 28);
            comboBoxClients.TabIndex = 2;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged;
            // 
            // dateTimePickerTransactionDate
            // 
            dateTimePickerTransactionDate.Location = new Point(890, 559);
            dateTimePickerTransactionDate.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            dateTimePickerTransactionDate.Size = new Size(265, 27);
            dateTimePickerTransactionDate.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(1223, 561);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 27);
            txtAmount.TabIndex = 5;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Location = new Point(16, 612);
            btnAddTransaction.Margin = new Padding(4, 5, 4, 5);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(100, 35);
            btnAddTransaction.TabIndex = 6;
            btnAddTransaction.Text = "Add";
            btnAddTransaction.UseVisualStyleBackColor = true;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // btnEditTransaction
            // 
            btnEditTransaction.Location = new Point(124, 612);
            btnEditTransaction.Margin = new Padding(4, 5, 4, 5);
            btnEditTransaction.Name = "btnEditTransaction";
            btnEditTransaction.Size = new Size(100, 35);
            btnEditTransaction.TabIndex = 7;
            btnEditTransaction.Text = "Edit";
            btnEditTransaction.UseVisualStyleBackColor = true;
            btnEditTransaction.Click += btnEditTransaction_Click;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.Location = new Point(232, 612);
            btnDeleteTransaction.Margin = new Padding(4, 5, 4, 5);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(100, 35);
            btnDeleteTransaction.TabIndex = 8;
            btnDeleteTransaction.Text = "Delete";
            btnDeleteTransaction.UseVisualStyleBackColor = true;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnSearchTransaction
            // 
            btnSearchTransaction.Location = new Point(1223, 615);
            btnSearchTransaction.Margin = new Padding(4, 5, 4, 5);
            btnSearchTransaction.Name = "btnSearchTransaction";
            btnSearchTransaction.Size = new Size(100, 35);
            btnSearchTransaction.TabIndex = 9;
            btnSearchTransaction.Text = "Search";
            btnSearchTransaction.UseVisualStyleBackColor = true;
            btnSearchTransaction.Click += btnSearchTransaction_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1021, 619);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 27);
            txtSearch.TabIndex = 10;
            txtSearch.Text = "Search by Transaction Type";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new Point(680, 535);
            lblTransactionType.Margin = new Padding(4, 0, 4, 0);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(122, 20);
            lblTransactionType.TabIndex = 11;
            lblTransactionType.Text = "Transaction Type:";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.Location = new Point(886, 534);
            lblTransactionDate.Margin = new Padding(4, 0, 4, 0);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(123, 20);
            lblTransactionDate.TabIndex = 12;
            lblTransactionDate.Text = "Transaction Date:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(1223, 536);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(65, 20);
            lblAmount.TabIndex = 13;
            lblAmount.Text = "Amount:";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(12, 536);
            lblItem.Margin = new Padding(4, 0, 4, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(42, 20);
            lblItem.TabIndex = 14;
            lblItem.Text = "Item:";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new Point(348, 536);
            lblClient.Margin = new Padding(4, 0, 4, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(50, 20);
            lblClient.TabIndex = 15;
            lblClient.Text = "Client:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(953, 622);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search:";
            // 
            // transactionTypeComboBox
            // 
            transactionTypeComboBox.FormattingEnabled = true;
            transactionTypeComboBox.Location = new Point(683, 560);
            transactionTypeComboBox.Margin = new Padding(4, 5, 4, 5);
            transactionTypeComboBox.Name = "transactionTypeComboBox";
            transactionTypeComboBox.Size = new Size(135, 28);
            transactionTypeComboBox.TabIndex = 17;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(428, 618);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(214, 29);
            saveButton.TabIndex = 30;
            saveButton.Text = "Save to File";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 657);
            Controls.Add(saveButton);
            Controls.Add(transactionTypeComboBox);
            Controls.Add(lblSearch);
            Controls.Add(lblClient);
            Controls.Add(lblItem);
            Controls.Add(lblAmount);
            Controls.Add(lblTransactionDate);
            Controls.Add(lblTransactionType);
            Controls.Add(txtSearch);
            Controls.Add(btnSearchTransaction);
            Controls.Add(btnDeleteTransaction);
            Controls.Add(btnEditTransaction);
            Controls.Add(btnAddTransaction);
            Controls.Add(txtAmount);
            Controls.Add(dateTimePickerTransactionDate);
            Controls.Add(comboBoxClients);
            Controls.Add(comboBoxItems);
            Controls.Add(dataGridViewTransactions);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TransactionForm";
            Text = "Transaction Form";
            Load += TransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewTransactions;
		private System.Windows.Forms.ComboBox comboBoxItems;
		private System.Windows.Forms.ComboBox comboBoxClients;
		private System.Windows.Forms.DateTimePicker dateTimePickerTransactionDate;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Button btnAddTransaction;
		private System.Windows.Forms.Button btnEditTransaction;
		private System.Windows.Forms.Button btnDeleteTransaction;
		private System.Windows.Forms.Button btnSearchTransaction;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblTransactionType;
		private System.Windows.Forms.Label lblTransactionDate;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Label lblItem;
		private System.Windows.Forms.Label lblClient;
		private System.Windows.Forms.Label lblSearch;
		private ComboBox transactionTypeComboBox;
		private Button saveButton;
	}
}

