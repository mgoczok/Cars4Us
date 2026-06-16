namespace Cars4Us
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCars = new Button();
            btnCustomers = new Button();
            btnTestDrives = new Button();
            btnPricing = new Button();
            btnOptions = new Button();
            btnEmployees = new Button();
            SuspendLayout();
            // 
            // btnCars
            // 
            btnCars.Location = new Point(195, 283);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(75, 23);
            btnCars.TabIndex = 0;
            btnCars.Text = "Auta";
            btnCars.UseVisualStyleBackColor = true;
            btnCars.Click += btnCars_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(287, 283);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(75, 23);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Klienci";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnTestDrives
            // 
            btnTestDrives.Location = new Point(379, 283);
            btnTestDrives.Name = "btnTestDrives";
            btnTestDrives.Size = new Size(125, 23);
            btnTestDrives.TabIndex = 2;
            btnTestDrives.Text = "Jazdy próbne";
            btnTestDrives.UseVisualStyleBackColor = true;
            // 
            // btnPricing
            // 
            btnPricing.Location = new Point(519, 283);
            btnPricing.Name = "btnPricing";
            btnPricing.Size = new Size(75, 23);
            btnPricing.TabIndex = 3;
            btnPricing.Text = "wycena";
            btnPricing.UseVisualStyleBackColor = true;
            btnPricing.Click += btnPricing_Click;
            // 
            // btnOptions
            // 
            btnOptions.Location = new Point(609, 283);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(85, 23);
            btnOptions.TabIndex = 4;
            btnOptions.Text = "Opcje";
            btnOptions.UseVisualStyleBackColor = true;
            btnOptions.Click += btnOptions_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(709, 283);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(95, 23);
            btnEmployees.TabIndex = 5;
            btnEmployees.Text = "Pracownicy";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(btnEmployees);
            Controls.Add(btnOptions);
            Controls.Add(btnPricing);
            Controls.Add(btnTestDrives);
            Controls.Add(btnCustomers);
            Controls.Add(btnCars);
            Name = "MainForm";
            Text = "Cars4Us - Salon Samochodowy";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCars;
        private Button btnCustomers;
        private Button btnTestDrives;
        private Button btnPricing;
        private Button btnOptions;
        private Button btnEmployees;
    }
}
