namespace APM
{
	partial class AddClientForm
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
            clientGroupBox = new GroupBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblStreet = new Label();
            txtFirstName = new TextBox();
            txtFlat = new TextBox();
            txtMiddleName = new TextBox();
            txtBuilding = new TextBox();
            txtPhone1 = new TextBox();
            lblFlat = new Label();
            txtPhone2 = new TextBox();
            lblBuilding = new Label();
            lblFirstName = new Label();
            adressComboBox = new ComboBox();
            lblMiddleName = new Label();
            lblPhone2 = new Label();
            lblAddress = new Label();
            lblPhone1 = new Label();
            btnAddClient = new Button();
            clientGroupBox.SuspendLayout();
            SuspendLayout();
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
            clientGroupBox.Location = new Point(12, 12);
            clientGroupBox.Name = "clientGroupBox";
            clientGroupBox.Size = new Size(606, 275);
            clientGroupBox.TabIndex = 27;
            clientGroupBox.TabStop = false;
            clientGroupBox.Text = "Client";
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
            // txtLastName
            // 
            txtLastName.Location = new Point(119, 40);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(478, 27);
            txtLastName.TabIndex = 5;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(119, 165);
            lblStreet.Margin = new Padding(4, 0, 4, 0);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(51, 20);
            lblStreet.TabIndex = 25;
            lblStreet.Text = "Street:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(119, 80);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(478, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtFlat
            // 
            txtFlat.Location = new Point(382, 161);
            txtFlat.Margin = new Padding(4, 5, 4, 5);
            txtFlat.Name = "txtFlat";
            txtFlat.Size = new Size(75, 27);
            txtFlat.TabIndex = 23;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(119, 120);
            txtMiddleName.Margin = new Padding(4, 5, 4, 5);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(478, 27);
            txtMiddleName.TabIndex = 7;
            // 
            // txtBuilding
            // 
            txtBuilding.Location = new Point(507, 162);
            txtBuilding.Margin = new Padding(4, 5, 4, 5);
            txtBuilding.Name = "txtBuilding";
            txtBuilding.Size = new Size(92, 27);
            txtBuilding.TabIndex = 22;
            // 
            // txtPhone1
            // 
            txtPhone1.Location = new Point(119, 200);
            txtPhone1.Margin = new Padding(4, 5, 4, 5);
            txtPhone1.Name = "txtPhone1";
            txtPhone1.Size = new Size(478, 27);
            txtPhone1.TabIndex = 9;
            // 
            // lblFlat
            // 
            lblFlat.AutoSize = true;
            lblFlat.Location = new Point(465, 165);
            lblFlat.Margin = new Padding(4, 0, 4, 0);
            lblFlat.Name = "lblFlat";
            lblFlat.Size = new Size(36, 20);
            lblFlat.TabIndex = 21;
            lblFlat.Text = "Flat:";
            // 
            // txtPhone2
            // 
            txtPhone2.Location = new Point(119, 240);
            txtPhone2.Margin = new Padding(4, 5, 4, 5);
            txtPhone2.Name = "txtPhone2";
            txtPhone2.Size = new Size(478, 27);
            txtPhone2.TabIndex = 10;
            // 
            // lblBuilding
            // 
            lblBuilding.AutoSize = true;
            lblBuilding.Location = new Point(318, 164);
            lblBuilding.Margin = new Padding(4, 0, 4, 0);
            lblBuilding.Name = "lblBuilding";
            lblBuilding.Size = new Size(67, 20);
            lblBuilding.TabIndex = 20;
            lblBuilding.Text = "Building:";
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
            // adressComboBox
            // 
            adressComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            adressComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            adressComboBox.FormattingEnabled = true;
            adressComboBox.Location = new Point(177, 161);
            adressComboBox.Name = "adressComboBox";
            adressComboBox.Size = new Size(134, 28);
            adressComboBox.TabIndex = 19;
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
            // btnAddClient
            // 
            btnAddClient.Location = new Point(12, 295);
            btnAddClient.Margin = new Padding(4, 5, 4, 5);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(606, 35);
            btnAddClient.TabIndex = 26;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 344);
            Controls.Add(clientGroupBox);
            Controls.Add(btnAddClient);
            Name = "AddClientForm";
            Text = "Add Client";
            clientGroupBox.ResumeLayout(false);
            clientGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox clientGroupBox;
		private Label lblLastName;
		private TextBox txtLastName;
		private Label lblStreet;
		private TextBox txtFirstName;
		private TextBox txtFlat;
		private TextBox txtMiddleName;
		private TextBox txtBuilding;
		private TextBox txtPhone1;
		private Label lblBuilding;
		private TextBox txtPhone2;
		private Label lblFlat;
		private Label lblFirstName;
		private ComboBox adressComboBox;
		private Label lblMiddleName;
		private Label lblPhone2;
		private Label lblAddress;
		private Label lblPhone1;
		private Button btnAddClient;
	}
}