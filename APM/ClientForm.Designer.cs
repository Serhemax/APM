namespace APM
{
	partial class ClientForm
	{
		private System.ComponentModel.IContainer components = null;
		private DataGridView dataGridViewClients;
		private Button btnAddClient;
		private Button btnEditClient;
		private Button btnDeleteClient;
		private Button btnSearchClient;
		private TextBox txtLastName;
		private TextBox txtFirstName;
		private TextBox txtMiddleName;
		private TextBox txtPhone1;
		private TextBox txtPhone2;
		private TextBox txtSearch;
		private Label lblLastName;
		private Label lblFirstName;
		private Label lblMiddleName;
		private Label lblAddress;
		private Label lblPhone1;
		private Label lblPhone2;
		private Label lblSearch;

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
            dataGridViewClients = new DataGridView();
            btnAddClient = new Button();
            btnEditClient = new Button();
            btnDeleteClient = new Button();
            btnSearchClient = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtPhone1 = new TextBox();
            txtPhone2 = new TextBox();
            txtSearch = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblAddress = new Label();
            lblPhone1 = new Label();
            lblPhone2 = new Label();
            adressComboBox = new ComboBox();
            lblBuilding = new Label();
            lblFlat = new Label();
            txtBuilding = new TextBox();
            txtFlat = new TextBox();
            lblSearchHint = new Label();
            lblStreet = new Label();
            searchGroup = new GroupBox();
            clientGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            searchGroup.SuspendLayout();
            clientGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(16, 18);
            dataGridViewClients.Margin = new Padding(4, 5, 4, 5);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(1013, 385);
            dataGridViewClients.TabIndex = 0;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(131, 723);
            btnAddClient.Margin = new Padding(4, 5, 4, 5);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(100, 35);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(310, 723);
            btnEditClient.Margin = new Padding(4, 5, 4, 5);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(100, 35);
            btnEditClient.TabIndex = 2;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(500, 723);
            btnDeleteClient.Margin = new Padding(4, 5, 4, 5);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(108, 35);
            btnDeleteClient.TabIndex = 3;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnSearchClient
            // 
            btnSearchClient.Location = new Point(310, 186);
            btnSearchClient.Margin = new Padding(4, 5, 4, 5);
            btnSearchClient.Name = "btnSearchClient";
            btnSearchClient.Size = new Size(100, 35);
            btnSearchClient.TabIndex = 4;
            btnSearchClient.Text = "Search";
            btnSearchClient.UseVisualStyleBackColor = true;
            btnSearchClient.Click += btnSearchClient_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(119, 40);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(478, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(119, 80);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(478, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(119, 120);
            txtMiddleName.Margin = new Padding(4, 5, 4, 5);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(478, 27);
            txtMiddleName.TabIndex = 7;
            // 
            // txtPhone1
            // 
            txtPhone1.Location = new Point(119, 200);
            txtPhone1.Margin = new Padding(4, 5, 4, 5);
            txtPhone1.Name = "txtPhone1";
            txtPhone1.Size = new Size(478, 27);
            txtPhone1.TabIndex = 9;
            // 
            // txtPhone2
            // 
            txtPhone2.Location = new Point(119, 237);
            txtPhone2.Margin = new Padding(4, 5, 4, 5);
            txtPhone2.Name = "txtPhone2";
            txtPhone2.Size = new Size(478, 27);
            txtPhone2.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(7, 24);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(403, 27);
            txtSearch.TabIndex = 11;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(7, 44);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 12;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(7, 84);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 13;
            lblFirstName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(7, 124);
            lblMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(103, 20);
            lblMiddleName.TabIndex = 14;
            lblMiddleName.Text = "Middle Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(7, 165);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Address:";
            // 
            // lblPhone1
            // 
            lblPhone1.AutoSize = true;
            lblPhone1.Location = new Point(7, 204);
            lblPhone1.Margin = new Padding(4, 0, 4, 0);
            lblPhone1.Name = "lblPhone1";
            lblPhone1.Size = new Size(65, 20);
            lblPhone1.TabIndex = 16;
            lblPhone1.Text = "Phone 1:";
            // 
            // lblPhone2
            // 
            lblPhone2.AutoSize = true;
            lblPhone2.Location = new Point(7, 244);
            lblPhone2.Margin = new Padding(4, 0, 4, 0);
            lblPhone2.Name = "lblPhone2";
            lblPhone2.Size = new Size(65, 20);
            lblPhone2.TabIndex = 17;
            lblPhone2.Text = "Phone 2:";
            // 
            // adressComboBox
            // 
            adressComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            adressComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            adressComboBox.FormattingEnabled = true;
            adressComboBox.Location = new Point(165, 157);
            adressComboBox.Name = "adressComboBox";
            adressComboBox.Size = new Size(146, 28);
            adressComboBox.TabIndex = 19;
            adressComboBox.SelectedIndexChanged += adressComboBox_SelectedIndexChanged;
            adressComboBox.TextUpdate += adressComboBox_TextUpdate;
            // 
            // lblBuilding
            // 
            lblBuilding.AutoSize = true;
            lblBuilding.Location = new Point(318, 161);
            lblBuilding.Margin = new Padding(4, 0, 4, 0);
            lblBuilding.Name = "lblBuilding";
            lblBuilding.Size = new Size(67, 20);
            lblBuilding.TabIndex = 20;
            lblBuilding.Text = "Building:";
            // 
            // lblFlat
            // 
            lblFlat.AutoSize = true;
            lblFlat.Location = new Point(488, 160);
            lblFlat.Margin = new Padding(4, 0, 4, 0);
            lblFlat.Name = "lblFlat";
            lblFlat.Size = new Size(36, 20);
            lblFlat.TabIndex = 21;
            lblFlat.Text = "Flat:";
            // 
            // txtBuilding
            // 
            txtBuilding.Location = new Point(528, 158);
            txtBuilding.Margin = new Padding(4, 5, 4, 5);
            txtBuilding.Name = "txtBuilding";
            txtBuilding.Size = new Size(68, 27);
            txtBuilding.TabIndex = 22;
            // 
            // txtFlat
            // 
            txtFlat.Location = new Point(388, 158);
            txtFlat.Margin = new Padding(4, 5, 4, 5);
            txtFlat.Name = "txtFlat";
            txtFlat.Size = new Size(88, 27);
            txtFlat.TabIndex = 23;
            // 
            // lblSearchHint
            // 
            lblSearchHint.AutoSize = true;
            lblSearchHint.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblSearchHint.Location = new Point(210, 59);
            lblSearchHint.Margin = new Padding(4, 0, 4, 0);
            lblSearchHint.Name = "lblSearchHint";
            lblSearchHint.Size = new Size(212, 20);
            lblSearchHint.TabIndex = 24;
            lblSearchHint.Text = "Enter Last Name OR First Name";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(115, 161);
            lblStreet.Margin = new Padding(4, 0, 4, 0);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(51, 20);
            lblStreet.TabIndex = 25;
            lblStreet.Text = "Street:";
            // 
            // searchGroup
            // 
            searchGroup.Controls.Add(txtSearch);
            searchGroup.Controls.Add(btnSearchClient);
            searchGroup.Controls.Add(lblSearchHint);
            searchGroup.Location = new Point(615, 431);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(414, 229);
            searchGroup.TabIndex = 33;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search";
            // 
            // clientGroupBox
            // 
            clientGroupBox.Controls.Add(lblLastName);
            clientGroupBox.Controls.Add(txtLastName);
            clientGroupBox.Controls.Add(lblStreet);
            clientGroupBox.Controls.Add(txtFirstName);
            clientGroupBox.Controls.Add(txtFlat);
            clientGroupBox.Controls.Add(txtMiddleName);
            clientGroupBox.Controls.Add(txtBuilding);
            clientGroupBox.Controls.Add(txtPhone1);
            clientGroupBox.Controls.Add(lblFlat);
            clientGroupBox.Controls.Add(txtPhone2);
            clientGroupBox.Controls.Add(lblBuilding);
            clientGroupBox.Controls.Add(lblFirstName);
            clientGroupBox.Controls.Add(adressComboBox);
            clientGroupBox.Controls.Add(lblMiddleName);
            clientGroupBox.Controls.Add(lblPhone2);
            clientGroupBox.Controls.Add(lblAddress);
            clientGroupBox.Controls.Add(lblPhone1);
            clientGroupBox.Location = new Point(12, 431);
            clientGroupBox.Name = "clientGroupBox";
            clientGroupBox.Size = new Size(606, 275);
            clientGroupBox.TabIndex = 25;
            clientGroupBox.TabStop = false;
            clientGroupBox.Text = "Client";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 772);
            Controls.Add(clientGroupBox);
            Controls.Add(searchGroup);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(dataGridViewClients);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ClientForm";
            Text = "Client Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            clientGroupBox.ResumeLayout(false);
            clientGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        private ComboBox adressComboBox;
        private Label lblSearchHint;
        private Label lblBuilding;
        private TextBox txtBuilding;
        private TextBox txtFlat;
        private Label lblFlat;
		private Label lblStreet;
		private Button saveButton;
		private GroupBox searchGroup;
		private GroupBox clientGroupBox;
	}
}

