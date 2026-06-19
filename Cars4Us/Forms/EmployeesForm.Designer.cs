namespace Cars4Us
{
    partial class EmployeesForm
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
            gbEmployeeData = new GroupBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblRole = new Label();
            cbRole = new ComboBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            btnRefresh = new Button();
            btnClear = new Button();
            dgvEmployees = new DataGridView();
            gbEmployeeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(64, 168, 252);
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(130, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Pracownicy";
            // 
            // gbEmployeeData
            // 
            gbEmployeeData.Controls.Add(lblFirstName);
            gbEmployeeData.Controls.Add(txtFirstName);
            gbEmployeeData.Controls.Add(lblLastName);
            gbEmployeeData.Controls.Add(txtLastName);
            gbEmployeeData.Controls.Add(lblRole);
            gbEmployeeData.Controls.Add(cbRole);
            gbEmployeeData.Controls.Add(lblEmail);
            gbEmployeeData.Controls.Add(txtEmail);
            gbEmployeeData.Controls.Add(lblPhone);
            gbEmployeeData.Controls.Add(txtPhone);
            gbEmployeeData.Controls.Add(btnAdd);
            gbEmployeeData.Controls.Add(btnUpdate);
            gbEmployeeData.Controls.Add(btnDeactivate);
            gbEmployeeData.Controls.Add(btnRefresh);
            gbEmployeeData.Controls.Add(btnClear);
            gbEmployeeData.ForeColor = Color.White;
            gbEmployeeData.Location = new Point(20, 50);
            gbEmployeeData.Name = "gbEmployeeData";
            gbEmployeeData.Size = new Size(910, 170);
            gbEmployeeData.TabIndex = 1;
            gbEmployeeData.TabStop = false;
            gbEmployeeData.Text = "Dane pracownika";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(15, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(33, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Imię:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(45, 45, 45);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(90, 28);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(240, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(15, 65);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Nazwisko:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(45, 45, 45);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(90, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(240, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(15, 100);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 15);
            lblRole.TabIndex = 4;
            lblRole.Text = "Rola:";
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.FromArgb(45, 45, 45);
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.ForeColor = Color.White;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Salesperson", "Manager", "ServiceTechnician" });
            cbRole.Location = new Point(90, 97);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(240, 23);
            cbRole.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(380, 30);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(45, 45, 45);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(450, 28);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(380, 65);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 15);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Telefon:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(45, 45, 45);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(450, 62);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 23);
            txtPhone.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(45, 45, 45);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 30);
            btnAdd.TabIndex = 10;
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
            btnUpdate.Location = new Point(120, 130);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 30);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Zaktualizuj";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(45, 45, 45);
            btnDeactivate.Cursor = Cursors.Hand;
            btnDeactivate.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnDeactivate.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(225, 130);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(105, 30);
            btnDeactivate.TabIndex = 12;
            btnDeactivate.Text = "Dezaktywuj";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(45, 45, 45);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(500, 130);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 13;
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
            btnClear.Location = new Point(600, 130);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 30);
            btnClear.TabIndex = 14;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvEmployees.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 168, 252);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.GridColor = Color.FromArgb(60, 60, 60);
            dgvEmployees.Location = new Point(20, 235);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.Size = new Size(910, 305);
            dgvEmployees.TabIndex = 2;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(950, 560);
            Controls.Add(dgvEmployees);
            Controls.Add(gbEmployeeData);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "EmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Zarządzanie Pracownikami";
            gbEmployeeData.ResumeLayout(false);
            gbEmployeeData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox gbEmployeeData;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblRole;
        private ComboBox cbRole;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDeactivate;
        private Button btnRefresh;
        private Button btnClear;
        private DataGridView dgvEmployees;
    }
}
