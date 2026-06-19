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
            lblSubtitle = new Label();
            pnlTransactionData = new Panel();
            lblTransactionDataSection = new Label();
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
            pnlTransactionData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFinalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(64, 168, 252);
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.Name = "lblHeader";
            lblHeader.AutoSize = false;
            lblHeader.Size = new Size(800, 45);
            lblHeader.Location = new Point(20, 15);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Transakcje";
            // 
            
            // lblSubtitle
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 180, 180);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.AutoSize = false;
            lblSubtitle.Size = new Size(800, 30);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Rejestr sprzedaży pojazdów";
            // pnlTransactionData
            // 
            pnlTransactionData.Controls.Add(lblCar);
            pnlTransactionData.Controls.Add(cbCar);
            pnlTransactionData.Controls.Add(lblCustomer);
            pnlTransactionData.Controls.Add(cbCustomer);
            pnlTransactionData.Controls.Add(lblEmployee);
            pnlTransactionData.Controls.Add(cbEmployee);
            pnlTransactionData.Controls.Add(lblFinalPrice);
            pnlTransactionData.Controls.Add(numFinalPrice);
            pnlTransactionData.Controls.Add(lblFinancingType);
            pnlTransactionData.Controls.Add(cbFinancingType);
            pnlTransactionData.Controls.Add(lblStatus);
            pnlTransactionData.Controls.Add(cbStatus);
            pnlTransactionData.Controls.Add(btnAdd);
            pnlTransactionData.Controls.Add(btnUpdate);
            pnlTransactionData.Controls.Add(btnCancel);
            pnlTransactionData.Controls.Add(btnRefresh);
            pnlTransactionData.Controls.Add(btnClear);
            pnlTransactionData.ForeColor = Color.White;
            pnlTransactionData.Location = new Point(20, 100);
            pnlTransactionData.BackColor = Color.FromArgb(40, 40, 40);
            pnlTransactionData.Name = "gbTransactionData";
            pnlTransactionData.Size = new Size(1040, 190);
            pnlTransactionData.TabIndex = 1;
            // lblTransactionDataSection
            lblTransactionDataSection.AutoSize = true;
            lblTransactionDataSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTransactionDataSection.ForeColor = Color.FromArgb(64, 168, 252);
            lblTransactionDataSection.Location = new Point(15, 15);
            lblTransactionDataSection.Text = "Dane transakcji";
            pnlTransactionData.Controls.Add(lblTransactionDataSection);

                        // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(20, 55);
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
            cbCar.Location = new Point(100, 52);
            cbCar.Name = "cbCar";
            cbCar.Size = new Size(250, 23);
            cbCar.TabIndex = 1;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(20, 95);
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
            cbCustomer.Location = new Point(100, 92);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(250, 23);
            cbCustomer.TabIndex = 3;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(20, 135);
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
            cbEmployee.Location = new Point(100, 132);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(250, 23);
            cbEmployee.TabIndex = 5;
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Location = new Point(380, 55);
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
            numFinalPrice.Location = new Point(480, 52);
            numFinalPrice.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numFinalPrice.Name = "numFinalPrice";
            numFinalPrice.Size = new Size(250, 23);
            numFinalPrice.TabIndex = 7;
            numFinalPrice.ThousandsSeparator = true;
            // 
            // lblFinancingType
            // 
            lblFinancingType.AutoSize = true;
            lblFinancingType.Location = new Point(380, 95);
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
            cbFinancingType.Location = new Point(480, 92);
            cbFinancingType.Name = "cbFinancingType";
            cbFinancingType.Size = new Size(250, 23);
            cbFinancingType.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(380, 135);
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
            cbStatus.Location = new Point(480, 132);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(250, 23);
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
            btnAdd.Location = new Point(780, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 40);
            btnAdd.Font = new Font("Segoe UI", 10F);
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
            btnUpdate.Location = new Point(900, 30);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 40);
            btnUpdate.Font = new Font("Segoe UI", 10F);
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
            btnCancel.Location = new Point(780, 80);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(230, 40);
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.BackColor = Color.FromArgb(160, 40, 40);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 80);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 60, 60);
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
            btnRefresh.Location = new Point(780, 130);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 40);
            btnRefresh.Font = new Font("Segoe UI", 10F);
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
            btnClear.Location = new Point(900, 130);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 40);
            btnClear.Font = new Font("Segoe UI", 10F);
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
            dgvTransactions.Location = new Point(20, 310);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(1040, 360);
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.RowTemplate.Height = 35;
            dgvTransactions.TabIndex = 4;
            dgvTransactions.CellClick += dgvTransactions_CellClick;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1100, 700);
            Controls.Add(dgvTransactions);
            Controls.Add(pnlTransactionData);
            Controls.Add(lblSubtitle);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Zarządzanie Transakcjami";
            pnlTransactionData.ResumeLayout(false);
            pnlTransactionData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFinalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblSubtitle;
        private Label lblTransactionDataSection;
        private Panel pnlTransactionData;
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
