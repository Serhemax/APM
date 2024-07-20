namespace APM
{
    partial class SellingItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewItems;
        private Button btnSell;
        private CheckBox chkRedeem;
        private GroupBox groupBoxRedeem;
        private ComboBox cmbClients;
        private Button btnRedeem;
        private Label lblSelectClient;

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
            btnSell = new Button();
            chkRedeem = new CheckBox();
            groupBoxRedeem = new GroupBox();
            cmbClients = new ComboBox();
            btnRedeem = new Button();
            lblSelectClient = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            groupBoxRedeem.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(12, 12);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(500, 300);
            dataGridViewItems.TabIndex = 0;
            // 
            // btnSell
            // 
            btnSell.Location = new Point(530, 50);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(100, 30);
            btnSell.TabIndex = 1;
            btnSell.Text = "Sell";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // chkRedeem
            // 
            chkRedeem.AutoSize = true;
            chkRedeem.Location = new Point(530, 20);
            chkRedeem.Name = "chkRedeem";
            chkRedeem.Size = new Size(103, 24);
            chkRedeem.TabIndex = 2;
            chkRedeem.Text = "Redeem Item";
            chkRedeem.UseVisualStyleBackColor = true;
            chkRedeem.CheckedChanged += chkRedeem_CheckedChanged;
            // 
            // groupBoxRedeem
            // 
            groupBoxRedeem.Controls.Add(cmbClients);
            groupBoxRedeem.Controls.Add(btnRedeem);
            groupBoxRedeem.Controls.Add(lblSelectClient);
            groupBoxRedeem.Enabled = false;
            groupBoxRedeem.Location = new Point(530, 90);
            groupBoxRedeem.Name = "groupBoxRedeem";
            groupBoxRedeem.Size = new Size(200, 150);
            groupBoxRedeem.TabIndex = 3;
            groupBoxRedeem.TabStop = false;
            groupBoxRedeem.Text = "Redeem";
            // 
            // cmbClients
            // 
            cmbClients.FormattingEnabled = true;
            cmbClients.Location = new Point(15, 50);
            cmbClients.Name = "cmbClients";
            cmbClients.Size = new Size(170, 28);
            cmbClients.TabIndex = 1;
            cmbClients.SelectedIndexChanged += cmbClients_SelectedIndexChanged;
            // 
            // btnRedeem
            // 
            btnRedeem.Location = new Point(50, 100);
            btnRedeem.Name = "btnRedeem";
            btnRedeem.Size = new Size(100, 30);
            btnRedeem.TabIndex = 0;
            btnRedeem.Text = "Redeem";
            btnRedeem.UseVisualStyleBackColor = true;
            btnRedeem.Click += btnRedeem_Click;
            // 
            // lblSelectClient
            // 
            lblSelectClient.AutoSize = true;
            lblSelectClient.Location = new Point(12, 25);
            lblSelectClient.Name = "lblSelectClient";
            lblSelectClient.Size = new Size(93, 20);
            lblSelectClient.TabIndex = 2;
            lblSelectClient.Text = "Select Client";
            // 
            // SellingItemsForm
            // 
            ClientSize = new Size(750, 330);
            Controls.Add(groupBoxRedeem);
            Controls.Add(chkRedeem);
            Controls.Add(btnSell);
            Controls.Add(dataGridViewItems);
            Name = "SellingItemsForm";
            Text = "Selling and Redeeming Items";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            groupBoxRedeem.ResumeLayout(false);
            groupBoxRedeem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }

    #endregion
}