namespace Cars4Us
{
    partial class PricingForm
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
            lblCar = new Label();
            cbCar = new ComboBox();
            lblBasePrice = new Label();
            numBasePrice = new NumericUpDown();
            gbFinancing = new GroupBox();
            rbCash = new RadioButton();
            rbLeasing = new RadioButton();
            rbCredit = new RadioButton();
            chkFleetDiscount = new CheckBox();
            chkSeasonalPromotion = new CheckBox();
            lblOptions = new Label();
            clbOptions = new CheckedListBox();
            btnCalculate = new Button();
            lblBreakdownTitle = new Label();
            txtBreakdown = new TextBox();
            lblFinalPriceTitle = new Label();
            lblFinalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)numBasePrice).BeginInit();
            gbFinancing.SuspendLayout();
            SuspendLayout();
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(15, 15);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(69, 15);
            lblCar.TabIndex = 0;
            lblCar.Text = "Samochód:";
            // 
            // cbCar
            // 
            cbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCar.FormattingEnabled = true;
            cbCar.Location = new Point(15, 35);
            cbCar.Name = "cbCar";
            cbCar.Size = new Size(375, 23);
            cbCar.TabIndex = 1;
            cbCar.SelectedIndexChanged += cbCar_SelectedIndexChanged;
            // 
            // lblBasePrice
            // 
            lblBasePrice.AutoSize = true;
            lblBasePrice.Location = new Point(15, 72);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(113, 15);
            lblBasePrice.TabIndex = 2;
            lblBasePrice.Text = "Cena bazowa (PLN):";
            // 
            // numBasePrice
            // 
            numBasePrice.DecimalPlaces = 2;
            numBasePrice.Location = new Point(160, 70);
            numBasePrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            numBasePrice.Name = "numBasePrice";
            numBasePrice.Size = new Size(200, 23);
            numBasePrice.TabIndex = 3;
            numBasePrice.ThousandsSeparator = true;
            // 
            // gbFinancing
            // 
            gbFinancing.Controls.Add(rbCredit);
            gbFinancing.Controls.Add(rbLeasing);
            gbFinancing.Controls.Add(rbCash);
            gbFinancing.Location = new Point(15, 108);
            gbFinancing.Name = "gbFinancing";
            gbFinancing.Size = new Size(375, 60);
            gbFinancing.TabIndex = 4;
            gbFinancing.TabStop = false;
            gbFinancing.Text = "Typ finansowania";
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Checked = true;
            rbCash.Location = new Point(15, 25);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(74, 19);
            rbCash.TabIndex = 0;
            rbCash.TabStop = true;
            rbCash.Text = "Gotówka";
            rbCash.UseVisualStyleBackColor = true;
            // 
            // rbLeasing
            // 
            rbLeasing.AutoSize = true;
            rbLeasing.Location = new Point(130, 25);
            rbLeasing.Name = "rbLeasing";
            rbLeasing.Size = new Size(64, 19);
            rbLeasing.TabIndex = 1;
            rbLeasing.Text = "Leasing";
            rbLeasing.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            rbCredit.AutoSize = true;
            rbCredit.Location = new Point(245, 25);
            rbCredit.Name = "rbCredit";
            rbCredit.Size = new Size(59, 19);
            rbCredit.TabIndex = 2;
            rbCredit.Text = "Kredyt";
            rbCredit.UseVisualStyleBackColor = true;
            // 
            // chkFleetDiscount
            // 
            chkFleetDiscount.AutoSize = true;
            chkFleetDiscount.Location = new Point(15, 182);
            chkFleetDiscount.Name = "chkFleetDiscount";
            chkFleetDiscount.Size = new Size(138, 19);
            chkFleetDiscount.TabIndex = 5;
            chkFleetDiscount.Text = "Rabat flotowy (-5%)";
            chkFleetDiscount.UseVisualStyleBackColor = true;
            // 
            // chkSeasonalPromotion
            // 
            chkSeasonalPromotion.AutoSize = true;
            chkSeasonalPromotion.Location = new Point(15, 208);
            chkSeasonalPromotion.Name = "chkSeasonalPromotion";
            chkSeasonalPromotion.Size = new Size(167, 19);
            chkSeasonalPromotion.TabIndex = 6;
            chkSeasonalPromotion.Text = "Promocja sezonowa (-3%)";
            chkSeasonalPromotion.UseVisualStyleBackColor = true;
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(420, 15);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(96, 15);
            lblOptions.TabIndex = 7;
            lblOptions.Text = "Dostępne opcje:";
            // 
            // clbOptions
            // 
            clbOptions.CheckOnClick = true;
            clbOptions.FormattingEnabled = true;
            clbOptions.Location = new Point(420, 35);
            clbOptions.Name = "clbOptions";
            clbOptions.Size = new Size(440, 256);
            clbOptions.TabIndex = 8;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculate.Location = new Point(15, 248);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(200, 35);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Oblicz wycenę";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblBreakdownTitle
            // 
            lblBreakdownTitle.AutoSize = true;
            lblBreakdownTitle.Location = new Point(15, 300);
            lblBreakdownTitle.Name = "lblBreakdownTitle";
            lblBreakdownTitle.Size = new Size(87, 15);
            lblBreakdownTitle.TabIndex = 10;
            lblBreakdownTitle.Text = "Rozbicie ceny:";
            // 
            // txtBreakdown
            // 
            txtBreakdown.Font = new Font("Consolas", 9.75F);
            txtBreakdown.Location = new Point(15, 320);
            txtBreakdown.Multiline = true;
            txtBreakdown.Name = "txtBreakdown";
            txtBreakdown.ReadOnly = true;
            txtBreakdown.ScrollBars = ScrollBars.Vertical;
            txtBreakdown.Size = new Size(845, 220);
            txtBreakdown.TabIndex = 11;
            // 
            // lblFinalPriceTitle
            // 
            lblFinalPriceTitle.AutoSize = true;
            lblFinalPriceTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFinalPriceTitle.Location = new Point(15, 555);
            lblFinalPriceTitle.Name = "lblFinalPriceTitle";
            lblFinalPriceTitle.Size = new Size(120, 20);
            lblFinalPriceTitle.TabIndex = 12;
            lblFinalPriceTitle.Text = "Cena końcowa:";
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFinalPrice.ForeColor = Color.DarkGreen;
            lblFinalPrice.Location = new Point(145, 550);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(88, 25);
            lblFinalPrice.TabIndex = 13;
            lblFinalPrice.Text = "0,00 PLN";
            // 
            // PricingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 590);
            Controls.Add(lblFinalPrice);
            Controls.Add(lblFinalPriceTitle);
            Controls.Add(txtBreakdown);
            Controls.Add(lblBreakdownTitle);
            Controls.Add(btnCalculate);
            Controls.Add(clbOptions);
            Controls.Add(lblOptions);
            Controls.Add(chkSeasonalPromotion);
            Controls.Add(chkFleetDiscount);
            Controls.Add(gbFinancing);
            Controls.Add(numBasePrice);
            Controls.Add(lblBasePrice);
            Controls.Add(cbCar);
            Controls.Add(lblCar);
            Name = "PricingForm";
            Text = "Cars4Us - Kalkulator Wyceny";
            ((System.ComponentModel.ISupportInitialize)numBasePrice).EndInit();
            gbFinancing.ResumeLayout(false);
            gbFinancing.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCar;
        private ComboBox cbCar;
        private Label lblBasePrice;
        private NumericUpDown numBasePrice;
        private GroupBox gbFinancing;
        private RadioButton rbCash;
        private RadioButton rbLeasing;
        private RadioButton rbCredit;
        private CheckBox chkFleetDiscount;
        private CheckBox chkSeasonalPromotion;
        private Label lblOptions;
        private CheckedListBox clbOptions;
        private Button btnCalculate;
        private Label lblBreakdownTitle;
        private TextBox txtBreakdown;
        private Label lblFinalPriceTitle;
        private Label lblFinalPrice;
    }
}
