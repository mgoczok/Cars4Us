using System.Drawing;
using System.Windows.Forms;

namespace Cars4Us
{
    partial class CarsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblSubtitle = new Label();
            txtVin = new TextBox();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtMileage = new TextBox();
            txtPrice = new TextBox();
            cbEngine = new ComboBox();
            labelStatus = new Label();
            cbStatus = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnClear = new Button();
            dgvCars = new DataGridView();
            gbCarData = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            gbCarData.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 168, 252);
            label7.Location = new Point(0, 15);
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label7.Name = "label7";
            label7.Size = new Size(1150, 42);
            label7.TabIndex = 0;
            label7.Text = "Cars4Us";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            
            // lblSubtitle
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 180, 180);
            lblSubtitle.Location = new Point(0, 50);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(1150, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Zarządzanie samochodami";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // gbCarData
            // 
            gbCarData.Controls.Add(label1);
            gbCarData.Controls.Add(txtVin);
            gbCarData.Controls.Add(label2);
            gbCarData.Controls.Add(txtBrand);
            gbCarData.Controls.Add(label3);
            gbCarData.Controls.Add(txtModel);
            gbCarData.Controls.Add(label4);
            gbCarData.Controls.Add(txtMileage);
            gbCarData.Controls.Add(label5);
            gbCarData.Controls.Add(txtPrice);
            gbCarData.Controls.Add(label6);
            gbCarData.Controls.Add(cbEngine);
            gbCarData.Controls.Add(labelStatus);
            gbCarData.Controls.Add(cbStatus);
            gbCarData.Controls.Add(btnRefresh);
            gbCarData.Controls.Add(btnClear);
            gbCarData.Controls.Add(btnAdd);
            gbCarData.Controls.Add(btnDelete);
            gbCarData.ForeColor = Color.White;
            gbCarData.Location = new Point(20, 90);
            gbCarData.Name = "gbCarData";
            gbCarData.Size = new Size(350, 430);
            gbCarData.TabIndex = 1;
            gbCarData.TabStop = false;
            gbCarData.Text = "Dane samochodu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 43);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "VIN:";
            // 
            // txtVin
            // 
            txtVin.BackColor = Color.FromArgb(45, 45, 45);
            txtVin.BorderStyle = BorderStyle.FixedSingle;
            txtVin.ForeColor = Color.White;
            txtVin.Location = new Point(120, 40);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(200, 23);
            txtVin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Marka:";
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.FromArgb(45, 45, 45);
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.ForeColor = Color.White;
            txtBrand.Location = new Point(120, 80);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(200, 23);
            txtBrand.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 123);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.FromArgb(45, 45, 45);
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.ForeColor = Color.White;
            txtModel.Location = new Point(120, 120);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 23);
            txtModel.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 163);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Przebieg:";
            // 
            // txtMileage
            // 
            txtMileage.BackColor = Color.FromArgb(45, 45, 45);
            txtMileage.BorderStyle = BorderStyle.FixedSingle;
            txtMileage.ForeColor = Color.White;
            txtMileage.Location = new Point(120, 160);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(200, 23);
            txtMileage.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 203);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 8;
            label5.Text = "Cena:";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(45, 45, 45);
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.ForeColor = Color.White;
            txtPrice.Location = new Point(120, 200);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 243);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "Silnik:";
            // 
            // cbEngine
            // 
            cbEngine.BackColor = Color.FromArgb(45, 45, 45);
            cbEngine.ForeColor = Color.White;
            cbEngine.FormattingEnabled = true;
            cbEngine.Items.AddRange(new object[] { "Benzyna", "", "Diesel", "", "Elektryczny", "", "Hybryda" });
            cbEngine.Location = new Point(120, 240);
            cbEngine.Name = "cbEngine";
            cbEngine.Size = new Size(200, 23);
            cbEngine.TabIndex = 11;
            // 
            
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(20, 283);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(42, 15);
            labelStatus.TabIndex = 14;
            labelStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.FromArgb(45, 45, 45);
            cbStatus.ForeColor = Color.White;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Available", "OnOrder" });
            cbStatus.Location = new Point(120, 280);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 23);
            cbStatus.TabIndex = 15;
            cbStatus.Text = "Available";
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(45, 45, 45);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 35);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(45, 45, 45);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(175, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 35);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Usuń";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(45, 45, 45);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 375);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(145, 35);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Odśwież";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(45, 45, 45);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(175, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 35);
            btnClear.TabIndex = 17;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // dgvCars
            // 
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvCars.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 168, 252);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCars.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCars.EnableHeadersVisualStyles = false;
            dgvCars.GridColor = Color.FromArgb(60, 60, 60);
            dgvCars.Location = new Point(390, 90);
            dgvCars.Name = "dgvCars";
            dgvCars.RowHeadersVisible = false;
            dgvCars.Size = new Size(740, 430);

            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.RowTemplate.Height = 35;

            dgvCars.TabIndex = 2;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1150, 550);
            Controls.Add(dgvCars);
            Controls.Add(gbCarData);
            Controls.Add(lblSubtitle);
            Controls.Add(label7);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "CarsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Zarządzanie Samochodami";
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            gbCarData.ResumeLayout(false);
            gbCarData.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblSubtitle;
        private TextBox txtVin;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtMileage;
        private TextBox txtPrice;
        private ComboBox cbEngine;
        private Label labelStatus;
        private ComboBox cbStatus;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnClear;
        private DataGridView dgvCars;
        private GroupBox gbCarData;
    }
}