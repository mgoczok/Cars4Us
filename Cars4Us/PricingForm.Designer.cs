namespace Cars4Us
{
    partial class PricingForm
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
            lblHeader = new Label();
            gbCar = new GroupBox();
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
            gbOptions = new GroupBox();
            clbOptions = new CheckedListBox();
            btnCalculate = new Button();
            gbResult = new GroupBox();
            txtBreakdown = new TextBox();
            lblFinalPriceTitle = new Label();
            lblFinalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)numBasePrice).BeginInit();
            gbCar.SuspendLayout();
            gbFinancing.SuspendLayout();
            gbOptions.SuspendLayout();
            gbResult.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(64, 168, 252);
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(225, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Kalkulator wyceny";
            // 
            // gbCar
            // 
            gbCar.Controls.Add(lblCar);
            gbCar.Controls.Add(cbCar);
            gbCar.Controls.Add(lblBasePrice);
            gbCar.Controls.Add(numBasePrice);
            gbCar.ForeColor = Color.White;
            gbCar.Location = new Point(20, 55);
            gbCar.Name = "gbCar";
            gbCar.Size = new Size(400, 120);
            gbCar.TabIndex = 1;
            gbCar.TabStop = false;
            gbCar.Text = "Samochód i cena";
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(15, 28);
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
            cbCar.Location = new Point(15, 48);
            cbCar.Name = "cbCar";
            cbCar.Size = new Size(370, 23);
            cbCar.TabIndex = 1;
            cbCar.SelectedIndexChanged += cbCar_SelectedIndexChanged;
            // 
            // lblBasePrice
            // 
            lblBasePrice.AutoSize = true;
            lblBasePrice.Location = new Point(15, 84);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(113, 15);
            lblBasePrice.TabIndex = 2;
            lblBasePrice.Text = "Cena bazowa (PLN):";
            // 
            // numBasePrice
            // 
            numBasePrice.BackColor = Color.FromArgb(45, 45, 45);
            numBasePrice.DecimalPlaces = 2;
            numBasePrice.ForeColor = Color.White;
            numBasePrice.Location = new Point(155, 82);
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
            gbFinancing.Controls.Add(rbCash);
            gbFinancing.Controls.Add(rbLeasing);
            gbFinancing.Controls.Add(rbCredit);
            gbFinancing.Controls.Add(chkFleetDiscount);
            gbFinancing.Controls.Add(chkSeasonalPromotion);
            gbFinancing.ForeColor = Color.White;
            gbFinancing.Location = new Point(20, 185);
            gbFinancing.Name = "gbFinancing";
            gbFinancing.Size = new Size(400, 120);
            gbFinancing.TabIndex = 2;
            gbFinancing.TabStop = false;
            gbFinancing.Text = "Finansowanie i rabaty";
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Checked = true;
            rbCash.Location = new Point(15, 28);
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
            rbLeasing.Location = new Point(130, 28);
            rbLeasing.Name = "rbLeasing";
            rbLeasing.Size = new Size(64, 19);
            rbLeasing.TabIndex = 1;
            rbLeasing.Text = "Leasing";
            rbLeasing.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            rbCredit.AutoSize = true;
            rbCredit.Location = new Point(245, 28);
            rbCredit.Name = "rbCredit";
            rbCredit.Size = new Size(59, 19);
            rbCredit.TabIndex = 2;
            rbCredit.Text = "Kredyt";
            rbCredit.UseVisualStyleBackColor = true;
            // 
            // chkFleetDiscount
            // 
            chkFleetDiscount.AutoSize = true;
            chkFleetDiscount.Location = new Point(15, 60);
            chkFleetDiscount.Name = "chkFleetDiscount";
            chkFleetDiscount.Size = new Size(138, 19);
            chkFleetDiscount.TabIndex = 3;
            chkFleetDiscount.Text = "Rabat flotowy (-5%)";
            chkFleetDiscount.UseVisualStyleBackColor = true;
            // 
            // chkSeasonalPromotion
            // 
            chkSeasonalPromotion.AutoSize = true;
            chkSeasonalPromotion.Location = new Point(15, 88);
            chkSeasonalPromotion.Name = "chkSeasonalPromotion";
            chkSeasonalPromotion.Size = new Size(167, 19);
            chkSeasonalPromotion.TabIndex = 4;
            chkSeasonalPromotion.Text = "Promocja sezonowa (-3%)";
            chkSeasonalPromotion.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            gbOptions.Controls.Add(clbOptions);
            gbOptions.ForeColor = Color.White;
            gbOptions.Location = new Point(440, 55);
            gbOptions.Name = "gbOptions";
            gbOptions.Size = new Size(430, 250);
            gbOptions.TabIndex = 3;
            gbOptions.TabStop = false;
            gbOptions.Text = "Dostępne opcje i akcesoria";
            // 
            // clbOptions
            // 
            clbOptions.BackColor = Color.FromArgb(45, 45, 45);
            clbOptions.BorderStyle = BorderStyle.FixedSingle;
            clbOptions.CheckOnClick = true;
            clbOptions.ForeColor = Color.White;
            clbOptions.FormattingEnabled = true;
            clbOptions.Location = new Point(10, 22);
            clbOptions.Name = "clbOptions";
            clbOptions.Size = new Size(410, 218);
            clbOptions.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(45, 45, 45);
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(20, 318);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(400, 40);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Oblicz wycenę";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // gbResult
            // 
            gbResult.Controls.Add(txtBreakdown);
            gbResult.Controls.Add(lblFinalPriceTitle);
            gbResult.Controls.Add(lblFinalPrice);
            gbResult.ForeColor = Color.White;
            gbResult.Location = new Point(20, 370);
            gbResult.Name = "gbResult";
            gbResult.Size = new Size(850, 250);
            gbResult.TabIndex = 5;
            gbResult.TabStop = false;
            gbResult.Text = "Wynik wyceny";
            // 
            // txtBreakdown
            // 
            txtBreakdown.BackColor = Color.FromArgb(45, 45, 45);
            txtBreakdown.BorderStyle = BorderStyle.FixedSingle;
            txtBreakdown.Font = new Font("Consolas", 10F);
            txtBreakdown.ForeColor = Color.White;
            txtBreakdown.Location = new Point(10, 25);
            txtBreakdown.Multiline = true;
            txtBreakdown.Name = "txtBreakdown";
            txtBreakdown.ReadOnly = true;
            txtBreakdown.ScrollBars = ScrollBars.Vertical;
            txtBreakdown.Size = new Size(830, 175);
            txtBreakdown.TabIndex = 0;
            // 
            // lblFinalPriceTitle
            // 
            lblFinalPriceTitle.AutoSize = true;
            lblFinalPriceTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFinalPriceTitle.ForeColor = Color.White;
            lblFinalPriceTitle.Location = new Point(10, 212);
            lblFinalPriceTitle.Name = "lblFinalPriceTitle";
            lblFinalPriceTitle.Size = new Size(128, 21);
            lblFinalPriceTitle.TabIndex = 1;
            lblFinalPriceTitle.Text = "Cena końcowa:";
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblFinalPrice.ForeColor = Color.LimeGreen;
            lblFinalPrice.Location = new Point(145, 205);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(106, 30);
            lblFinalPrice.TabIndex = 2;
            lblFinalPrice.Text = "0,00 PLN";
            // 
            // PricingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(890, 635);
            Controls.Add(gbResult);
            Controls.Add(btnCalculate);
            Controls.Add(gbOptions);
            Controls.Add(gbFinancing);
            Controls.Add(gbCar);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "PricingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Kalkulator Wyceny";
            ((System.ComponentModel.ISupportInitialize)numBasePrice).EndInit();
            gbCar.ResumeLayout(false);
            gbCar.PerformLayout();
            gbFinancing.ResumeLayout(false);
            gbFinancing.PerformLayout();
            gbOptions.ResumeLayout(false);
            gbResult.ResumeLayout(false);
            gbResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox gbCar;
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
        private GroupBox gbOptions;
        private CheckedListBox clbOptions;
        private Button btnCalculate;
        private GroupBox gbResult;
        private TextBox txtBreakdown;
        private Label lblFinalPriceTitle;
        private Label lblFinalPrice;
    }
}
