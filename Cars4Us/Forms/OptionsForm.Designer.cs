namespace Cars4Us
{
    partial class OptionsForm
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
            gbOptionData = new GroupBox();
            lblName = new Label();
            txtName = new TextBox();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            btnRefresh = new Button();
            btnClear = new Button();
            dgvOptions = new DataGridView();
            gbOptionData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOptions).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(64, 168, 252);
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(198, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Opcje i akcesoria";
            // 
            // gbOptionData
            // 
            gbOptionData.Controls.Add(lblName);
            gbOptionData.Controls.Add(txtName);
            gbOptionData.Controls.Add(lblCategory);
            gbOptionData.Controls.Add(cbCategory);
            gbOptionData.Controls.Add(lblPrice);
            gbOptionData.Controls.Add(numPrice);
            gbOptionData.Controls.Add(btnAdd);
            gbOptionData.Controls.Add(btnUpdate);
            gbOptionData.Controls.Add(btnDeactivate);
            gbOptionData.Controls.Add(btnRefresh);
            gbOptionData.Controls.Add(btnClear);
            gbOptionData.ForeColor = Color.White;
            gbOptionData.Location = new Point(20, 50);
            gbOptionData.Name = "gbOptionData";
            gbOptionData.Size = new Size(540, 180);
            gbOptionData.TabIndex = 1;
            gbOptionData.TabStop = false;
            gbOptionData.Text = "Dane opcji";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nazwa:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(45, 45, 45);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(90, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 23);
            txtName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 65);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(60, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Kategoria:";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.FromArgb(45, 45, 45);
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.ForeColor = Color.White;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "SafetyPackage", "Multimedia", "Wheels", "Comfort", "Warranty", "ExteriorProtection" });
            cbCategory.Location = new Point(90, 62);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(240, 23);
            cbCategory.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(15, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(35, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Cena:";
            // 
            // numPrice
            // 
            numPrice.BackColor = Color.FromArgb(45, 45, 45);
            numPrice.DecimalPlaces = 2;
            numPrice.ForeColor = Color.White;
            numPrice.Location = new Point(90, 98);
            numPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(240, 23);
            numPrice.TabIndex = 5;
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
            btnAdd.Size = new Size(95, 30);
            btnAdd.TabIndex = 6;
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
            btnUpdate.Location = new Point(120, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 30);
            btnUpdate.TabIndex = 7;
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
            btnDeactivate.Location = new Point(225, 140);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(105, 30);
            btnDeactivate.TabIndex = 8;
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
            btnRefresh.Location = new Point(335, 140);
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
            btnClear.Location = new Point(430, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 30);
            btnClear.TabIndex = 3;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvOptions
            // 
            dgvOptions.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvOptions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 168, 252);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvOptions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOptions.EnableHeadersVisualStyles = false;
            dgvOptions.GridColor = Color.FromArgb(60, 60, 60);
            dgvOptions.Location = new Point(20, 245);
            dgvOptions.Name = "dgvOptions";
            dgvOptions.RowHeadersVisible = false;
            dgvOptions.Size = new Size(810, 270);
            dgvOptions.TabIndex = 4;
            dgvOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOptions.CellClick += dgvOptions_CellClick;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(850, 530);
            Controls.Add(dgvOptions);
            Controls.Add(gbOptionData);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "OptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Zarządzanie Opcjami";
            gbOptionData.ResumeLayout(false);
            gbOptionData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOptions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox gbOptionData;
        private Label lblName;
        private TextBox txtName;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDeactivate;
        private Button btnRefresh;
        private Button btnClear;
        private DataGridView dgvOptions;
    }
}
