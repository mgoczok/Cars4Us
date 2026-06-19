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
            lblSubtitle = new Label();
            pnlEmployeeData = new Panel();
            lblEmployeeDataSection = new Label();
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
            pnlEmployeeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(64, 168, 252);
            lblHeader.Location = new Point(20, 15);
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(130, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Pracownicy";
            // 
            
            // lblSubtitle
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 180, 180);
            lblSubtitle.Location = new Point(20, 50);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(500, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Zarządzanie kadrą salonu";
            // pnlEmployeeData
            // 
            pnlEmployeeData.Controls.Add(lblFirstName);
            pnlEmployeeData.Controls.Add(txtFirstName);
            pnlEmployeeData.Controls.Add(lblLastName);
            pnlEmployeeData.Controls.Add(txtLastName);
            pnlEmployeeData.Controls.Add(lblRole);
            pnlEmployeeData.Controls.Add(cbRole);
            pnlEmployeeData.Controls.Add(lblEmail);
            pnlEmployeeData.Controls.Add(txtEmail);
            pnlEmployeeData.Controls.Add(lblPhone);
            pnlEmployeeData.Controls.Add(txtPhone);
            pnlEmployeeData.Controls.Add(btnAdd);
            pnlEmployeeData.Controls.Add(btnUpdate);
            pnlEmployeeData.Controls.Add(btnDeactivate);
            pnlEmployeeData.Controls.Add(btnRefresh);
            pnlEmployeeData.Controls.Add(btnClear);
            pnlEmployeeData.ForeColor = Color.White;
            pnlEmployeeData.Location = new Point(20, 80);
            pnlEmployeeData.BackColor = Color.FromArgb(40, 40, 40);
            pnlEmployeeData.Name = "gbEmployeeData";
            pnlEmployeeData.Size = new Size(940, 180);
            pnlEmployeeData.TabIndex = 1;
            // lblEmployeeDataSection
            lblEmployeeDataSection.AutoSize = true;
            lblEmployeeDataSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmployeeDataSection.ForeColor = Color.FromArgb(64, 168, 252);
            lblEmployeeDataSection.Location = new Point(15, 10);
            lblEmployeeDataSection.Text = "Dane pracownika";
            pnlEmployeeData.Controls.Add(lblEmployeeDataSection);

                        // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(20, 45);
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
            txtFirstName.Location = new Point(100, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(20, 85);
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
            txtLastName.Location = new Point(100, 82);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(20, 125);
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
            cbRole.Location = new Point(100, 122);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(200, 23);
            cbRole.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(340, 45);
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
            txtEmail.Location = new Point(410, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(340, 85);
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
            txtPhone.Location = new Point(410, 82);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 23);
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
            btnAdd.Location = new Point(700, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.Font = new Font("Segoe UI", 10F);
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
            btnUpdate.Location = new Point(810, 25);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.Font = new Font("Segoe UI", 10F);
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
            btnDeactivate.Location = new Point(700, 75);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(210, 40);
            btnDeactivate.Font = new Font("Segoe UI", 10F);
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
            btnRefresh.Location = new Point(700, 125);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 40);
            btnRefresh.Font = new Font("Segoe UI", 10F);
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
            btnClear.Location = new Point(810, 125);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.Font = new Font("Segoe UI", 10F);
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
            dgvEmployees.Location = new Point(20, 280);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.Size = new Size(940, 260);
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.RowTemplate.Height = 35;
            dgvEmployees.TabIndex = 2;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1000, 580);
            Controls.Add(dgvEmployees);
            Controls.Add(pnlEmployeeData);
            Controls.Add(lblSubtitle);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "EmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Zarządzanie Pracownikami";
            pnlEmployeeData.ResumeLayout(false);
            pnlEmployeeData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblSubtitle;
        private Label lblEmployeeDataSection;
        private Panel pnlEmployeeData;
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
