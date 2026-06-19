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
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 168, 252);
            lblTitle.Location = new Point(0, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(550, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cars4Us";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 180, 180);
            lblSubtitle.Location = new Point(0, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(550, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Panel zarządzania salonem";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCars
            // 
            btnCars.BackColor = Color.FromArgb(45, 45, 45);
            btnCars.Cursor = Cursors.Hand;
            btnCars.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnCars.FlatStyle = FlatStyle.Flat;
            btnCars.Font = new Font("Segoe UI", 10F);
            btnCars.ForeColor = Color.White;
            btnCars.Location = new Point(55, 120);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(210, 50);
            btnCars.TabIndex = 2;
            btnCars.Text = "Samochody";
            btnCars.UseVisualStyleBackColor = false;
            btnCars.Click += btnCars_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(45, 45, 45);
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10F);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(285, 120);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(210, 50);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Klienci";
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnTestDrives
            // 
            btnTestDrives.BackColor = Color.FromArgb(45, 45, 45);
            btnTestDrives.Cursor = Cursors.Hand;
            btnTestDrives.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnTestDrives.FlatStyle = FlatStyle.Flat;
            btnTestDrives.Font = new Font("Segoe UI", 10F);
            btnTestDrives.ForeColor = Color.White;
            btnTestDrives.Location = new Point(55, 185);
            btnTestDrives.Name = "btnTestDrives";
            btnTestDrives.Size = new Size(210, 50);
            btnTestDrives.TabIndex = 4;
            btnTestDrives.Text = "Jazdy próbne";
            btnTestDrives.UseVisualStyleBackColor = false;
            // 
            // btnPricing
            // 
            btnPricing.BackColor = Color.FromArgb(45, 45, 45);
            btnPricing.Cursor = Cursors.Hand;
            btnPricing.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnPricing.FlatStyle = FlatStyle.Flat;
            btnPricing.Font = new Font("Segoe UI", 10F);
            btnPricing.ForeColor = Color.White;
            btnPricing.Location = new Point(285, 185);
            btnPricing.Name = "btnPricing";
            btnPricing.Size = new Size(210, 50);
            btnPricing.TabIndex = 5;
            btnPricing.Text = "Kalkulator wyceny";
            btnPricing.UseVisualStyleBackColor = false;
            btnPricing.Click += btnPricing_Click;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.FromArgb(45, 45, 45);
            btnOptions.Cursor = Cursors.Hand;
            btnOptions.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Segoe UI", 10F);
            btnOptions.ForeColor = Color.White;
            btnOptions.Location = new Point(55, 250);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(210, 50);
            btnOptions.TabIndex = 6;
            btnOptions.Text = "Opcje i akcesoria";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(45, 45, 45);
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 10F);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(285, 250);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(210, 50);
            btnEmployees.TabIndex = 7;
            btnEmployees.Text = "Pracownicy";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.FromArgb(45, 45, 45);
            btnTransactions.Cursor = Cursors.Hand;
            btnTransactions.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Segoe UI", 10F);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(55, 315);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(440, 50);
            btnTransactions.TabIndex = 8;
            btnTransactions.Text = "Transakcje";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(550, 405);
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
    }
}
