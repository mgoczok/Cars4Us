using System.Drawing;
using System.Windows.Forms;

namespace Cars4Us
{
    partial class MainForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFooter = new Label();
            btnCars = new Button();
            btnCustomers = new Button();
            btnTestDrives = new Button();
            btnPricing = new Button();
            btnOptions = new Button();
            btnEmployees = new Button();
            btnTransactions = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 168, 252);
            lblTitle.Location = new Point(0, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(850, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cars4Us";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 180, 180);
            lblSubtitle.Location = new Point(0, 90);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(850, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Panel zarządzania salonem";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCars
            // 
            btnCars.BackColor = Color.FromArgb(45, 45, 45);
            btnCars.Cursor = Cursors.Hand;
            btnCars.FlatAppearance.BorderSize = 0;
            btnCars.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnCars.FlatStyle = FlatStyle.Flat;
            btnCars.Font = new Font("Segoe UI", 13F);
            btnCars.ForeColor = Color.White;
            btnCars.Location = new Point(165, 160);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(160, 120);
            btnCars.TabIndex = 2;
            btnCars.Text = "🚗\r\n\r\nSamochody";
            btnCars.UseVisualStyleBackColor = false;
            btnCars.Click += btnCars_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(45, 45, 45);
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 13F);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(255, 160);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Visible = false;
            btnCustomers.Size = new Size(160, 120);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "👤\r\n\r\nKlienci";
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnTestDrives
            // 
            btnTestDrives.BackColor = Color.FromArgb(45, 45, 45);
            btnTestDrives.Cursor = Cursors.Hand;
            btnTestDrives.FlatAppearance.BorderSize = 0;
            btnTestDrives.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnTestDrives.FlatStyle = FlatStyle.Flat;
            btnTestDrives.Font = new Font("Segoe UI", 13F);
            btnTestDrives.ForeColor = Color.White;
            btnTestDrives.Location = new Point(435, 160);
            btnTestDrives.Name = "btnTestDrives";
            btnTestDrives.Visible = false;
            btnTestDrives.Size = new Size(160, 120);
            btnTestDrives.TabIndex = 4;
            btnTestDrives.Text = "📅\r\n\r\nJazdy próbne";
            btnTestDrives.UseVisualStyleBackColor = false;
            // 
            // btnPricing
            // 
            btnPricing.BackColor = Color.FromArgb(45, 45, 45);
            btnPricing.Cursor = Cursors.Hand;
            btnPricing.FlatAppearance.BorderSize = 0;
            btnPricing.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnPricing.FlatStyle = FlatStyle.Flat;
            btnPricing.Font = new Font("Segoe UI", 12F);
            btnPricing.ForeColor = Color.White;
            btnPricing.Location = new Point(255, 300);
            btnPricing.Name = "btnPricing";
            btnPricing.Size = new Size(160, 120);
            btnPricing.TabIndex = 5;
            btnPricing.Text = "🧮\r\n\r\nKalkulator wyceny";
            btnPricing.UseVisualStyleBackColor = false;
            btnPricing.Click += btnPricing_Click;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.FromArgb(45, 45, 45);
            btnOptions.Cursor = Cursors.Hand;
            btnOptions.FlatAppearance.BorderSize = 0;
            btnOptions.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Segoe UI", 12F);
            btnOptions.ForeColor = Color.White;
            btnOptions.Location = new Point(345, 160);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(160, 120);
            btnOptions.TabIndex = 6;
            btnOptions.Text = "⚙\r\n\r\nOpcje i akcesoria";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(45, 45, 45);
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 13F);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(525, 160);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(160, 120);
            btnEmployees.TabIndex = 7;
            btnEmployees.Text = "👥\r\n\r\nPracownicy";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.FromArgb(45, 45, 45);
            btnTransactions.Cursor = Cursors.Hand;
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Segoe UI", 13F);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(435, 300);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(160, 120);
            btnTransactions.TabIndex = 8;
            btnTransactions.Text = "🧾\r\n\r\nTransakcje";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(120, 120, 120);
            lblFooter.Location = new Point(0, 490);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(850, 30);
            lblFooter.TabIndex = 9;
            lblFooter.Text = "Cars4Us • C# WinForms • MySQL";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(850, 550);
            Controls.Add(lblFooter);
            Controls.Add(btnTransactions);
            Controls.Add(btnEmployees);
            Controls.Add(btnOptions);
            Controls.Add(btnPricing);
            Controls.Add(btnTestDrives);
            Controls.Add(btnCustomers);
            Controls.Add(btnCars);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Salon Samochodowy";
            ResumeLayout(false);
        }

        private Button btnCars;
        private Button btnCustomers;
        private Button btnTestDrives;
        private Button btnPricing;
        private Button btnOptions;
        private Button btnEmployees;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnTransactions;
        private Label lblFooter;
    }
}
