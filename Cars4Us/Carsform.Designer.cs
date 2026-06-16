namespace Cars4Us
{
    partial class CarsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtVin = new TextBox();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtMileage = new TextBox();
            txtPrice = new TextBox();
            cbEngine = new ComboBox();
            btnAdd = new Button();
            dgvCars = new DataGridView();
            btnDelete = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 263);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Vin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 295);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 329);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 358);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Silnik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 387);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Przebieg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 419);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 5;
            label6.Text = "Cena";
            // 
            // txtVin
            // 
            txtVin.Location = new Point(178, 263);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(100, 23);
            txtVin.TabIndex = 6;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(178, 295);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(178, 321);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 8;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(178, 379);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(100, 23);
            txtMileage.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(178, 411);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 11;
            // 
            // cbEngine
            // 
            cbEngine.FormattingEnabled = true;
            cbEngine.Items.AddRange(new object[] { "Benzyna", "", "Diesel", "", "Elektryczny", "", "Hybryda" });
            cbEngine.Location = new Point(178, 350);
            cbEngine.Name = "cbEngine";
            cbEngine.Size = new Size(100, 23);
            cbEngine.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(178, 449);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Dodaj Auto";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(462, 164);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(499, 226);
            dgvCars.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(272, 449);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Usuń Auto";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 23F);
            label7.Location = new Point(462, 36);
            label7.Name = "label7";
            label7.Size = new Size(125, 42);
            label7.TabIndex = 16;
            label7.Text = "Cars4us";
            label7.Click += label7_Click;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 551);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(dgvCars);
            Controls.Add(btnAdd);
            Controls.Add(cbEngine);
            Controls.Add(txtPrice);
            Controls.Add(txtMileage);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(txtVin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarsForm";
            Text = "Cars4us";
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtVin;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtMileage;
        private TextBox txtPrice;
        private ComboBox cbEngine;
        private Button btnAdd;
        private DataGridView dgvCars;
        private Button btnDelete;
        private Label label7;
    }
}