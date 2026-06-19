namespace Cars4Us
{
    partial class TransactionsForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblHeader = new Label();
            gbTransactionData = new GroupBox();
            lblCar = new Label();
            cbCar = new ComboBox();
            lblCustomer = new Label();
            cbCustomer = new ComboBox();
            lblEmployee = new Label();
            cbEmployee = new ComboBox();
            lblFinalPrice = new Label();
            numFinalPrice = new NumericUpDown();
            lblFinancingType = new Label();
            cbFinancingType = new ComboBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnRefresh = new Button();
            btnClear = new Button();
            dgvTransactions = new DataGridView();
            gbTransactionData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFinalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(64, 168, 252);
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(136, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Transakcje";
            // 
            // gbTransactionData
            // 
            gbTransactionData.Controls.Add(lblCar);
            gbTransactionData.Controls.Add(cbCar);
            gbTransactionData.Controls.Add(lblCustomer);
            gbTransactionData.Controls.Add(cbCustomer);
            gbTransactionData.Controls.Add(lblEmployee);
            gbTransactionData.Controls.Add(cbEmployee);
            gbTransactionData.Controls.Add(lblFinalPrice);
            gbTransactionData.Controls.Add(numFinalPrice);
            gbTransactionData.Controls.Add(lblFinancingType);
            gbTransactionData.Controls.Add(cbFinancingType);
            gbTransactionData.Controls.Add(lblStatus);
            gbTransactionData.Controls.Add(cbStatus);
            gbTransactionData.Controls.Add(btnAdd);
            gbTransactionData.Controls.Add(btnUpdate);
            gbTransactionData.Controls.Add(btnCancel);
            gbTransactionData.Controls.Add(btnRefresh);
            gbTransactionData.Controls.Add(btnClear);
            gbTransactionData.ForeColor = Color.White;
            gbTransactionData.Location = new Point(20, 55);
            gbTransactionData.Name = "gbTransactionData";
            gbTransactionData.Size = new Size(940, 210);
            gbTransactionData.TabIndex = 1;
            gbTransactionData.TabStop = false;
            gbTransactionData.Text = "Dane transakcji";
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(15, 30);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(69, 15);
            lblCar.TabIndex = 0;
            lblCar.Text = "Samochód:";
            // 
            // cbCar
            // 
            cbCar.BackColor = Color.FromArgb(45, 45, 45);
            cbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCar.ForeColor = Color.White;
            cbCar.FormattingEnabled = true;
            cbCar.Location = new Point(105, 27);
            cbCar.Name = "cbCar";
            cbCar.Size = new Size(340, 23);
            cbCar.TabIndex = 1;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(15, 65);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(42, 15);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Klient:";
            // 
            // cbCustomer
            // 
            cbCustomer.BackColor = Color.FromArgb(45, 45, 45);
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.ForeColor = Color.White;
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(105, 62);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(340, 23);
            cbCustomer.TabIndex = 3;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(15, 100);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(71, 15);
            lblEmployee.TabIndex = 4;
            lblEmployee.Text = "Handlowiec:";
            // 
            // cbEmployee
            // 
            cbEmployee.BackColor = Color.FromArgb(45, 45, 45);
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.ForeColor = Color.White;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(105, 97);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(340, 23);
            cbEmployee.TabIndex = 5;
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Location = new Point(500, 30);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(93, 15);
            lblFinalPrice.TabIndex = 6;
            lblFinalPrice.Text = "Cena końcowa:";
            // 
            // numFinalPrice
            // 
            numFinalPrice.BackColor = Color.FromArgb(45, 45, 45);
            numFinalPrice.DecimalPlaces = 2;
            numFinalPrice.ForeColor = Color.White;
            numFinalPrice.Location = new Point(620, 27);
            numFinalPrice.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numFinalPrice.Name = "numFinalPrice";
            numFinalPrice.Size = new Size(290, 23);
            numFinalPrice.TabIndex = 7;
            numFinalPrice.ThousandsSeparator = true;
            // 
            // lblFinancingType
            // 
            lblFinancingType.AutoSize = true;
            lblFinancingType.Location = new Point(500, 65);
            lblFinancingType.Name = "lblFinancingType";
            lblFinancingType.Size = new Size(86, 15);
            lblFinancingType.TabIndex = 8;
            lblFinancingType.Text = "Finansowanie:";
            // 
            // cbFinancingType
            // 
            cbFinancingType.BackColor = Color.FromArgb(45, 45, 45);
            cbFinancingType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFinancingType.ForeColor = Color.White;
            cbFinancingType.FormattingEnabled = true;
            cbFinancingType.Items.AddRange(new object[] { "Cash", "Leasing", "Credit" });
            cbFinancingType.Location = new Point(620, 62);
            cbFinancingType.Name = "cbFinancingType";
            cbFinancingType.Size = new Size(290, 23);
            cbFinancingType.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(500, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.FromArgb(45, 45, 45);
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.ForeColor = Color.White;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Created", "Reserved", "CreditVerification", "Insurance", "ReadyForRelease", "Completed", "Cancelled" });
            cbStatus.Location = new Point(620, 97);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(290, 23);
            cbStatus.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(45, 45, 45);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(45, 45, 45);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(150, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Zaktualizuj";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(45, 45, 45);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(285, 140);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Anuluj transakcję";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(45, 45, 45);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(730, 140);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Odśwież";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(45, 45, 45);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(835, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 30);
            btnClear.TabIndex = 3;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvTransactions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 168, 252);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.GridColor = Color.FromArgb(60, 60, 60);
            dgvTransactions.Location = new Point(20, 280);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(940, 310);
            dgvTransactions.TabIndex = 4;
            dgvTransactions.CellClick += dgvTransactions_CellClick;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(980, 605);
            Controls.Add(dgvTransactions);
            Controls.Add(gbTransactionData);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Zarządzanie Transakcjami";
            gbTransactionData.ResumeLayout(false);
            gbTransactionData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFinalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox gbTransactionData;
        private Label lblCar;
        private ComboBox cbCar;
        private Label lblCustomer;
        private ComboBox cbCustomer;
        private Label lblEmployee;
        private ComboBox cbEmployee;
        private Label lblFinalPrice;
        private NumericUpDown numFinalPrice;
        private Label lblFinancingType;
        private ComboBox cbFinancingType;
        private Label lblStatus;
        private ComboBox cbStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnRefresh;
        private Button btnClear;
        private DataGridView dgvTransactions;
    }
}
