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
            pnlCar = new Panel();
            lblCarSection = new Label();
            lblCar = new Label();
            cbCar = new ComboBox();
            lblBasePrice = new Label();
            numBasePrice = new NumericUpDown();
            pnlFinancing = new Panel();
            lblFinancingSection = new Label();
            rbCash = new RadioButton();
            rbLeasing = new RadioButton();
            rbCredit = new RadioButton();
            chkFleetDiscount = new CheckBox();
            chkSeasonalPromotion = new CheckBox();
            pnlOptions = new Panel();
            lblOptionsSection = new Label();
            clbOptions = new CheckedListBox();
            btnCalculate = new Button();
            pnlResult = new Panel();
            lblResultSection = new Label();
            txtBreakdown = new TextBox();
            lblFinalPriceTitle = new Label();
            lblFinalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)numBasePrice).BeginInit();
            pnlCar.SuspendLayout();
            pnlFinancing.SuspendLayout();
            pnlOptions.SuspendLayout();
            pnlResult.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(64, 168, 252);
            lblHeader.Name = "lblHeader";
            lblHeader.AutoSize = false;
            lblHeader.Size = new Size(800, 45);
            lblHeader.Location = new Point(20, 15);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Kalkulator wyceny";
            // 
            // gbCar
            // 
            pnlCar.Controls.Add(lblCar);
            pnlCar.Controls.Add(cbCar);
            pnlCar.Controls.Add(lblBasePrice);
            pnlCar.Controls.Add(numBasePrice);
            pnlCar.ForeColor = Color.White;
            pnlCar.Location = new Point(20, 60);
            pnlCar.BackColor = Color.FromArgb(40, 40, 40);
            pnlCar.Name = "gbCar";
            pnlCar.Size = new Size(400, 140);
            pnlCar.TabIndex = 1;
                        // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(15, 45);
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
            cbCar.Location = new Point(15, 65);
            cbCar.Name = "cbCar";
            cbCar.Size = new Size(360, 23);
            cbCar.TabIndex = 1;
            cbCar.SelectedIndexChanged += cbCar_SelectedIndexChanged;
            // 
            // lblBasePrice
            // 
            lblBasePrice.AutoSize = true;
            lblBasePrice.Location = new Point(15, 100);
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
            numBasePrice.Location = new Point(155, 98);
            numBasePrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            numBasePrice.Name = "numBasePrice";
            numBasePrice.Size = new Size(220, 23);
            numBasePrice.TabIndex = 3;
            numBasePrice.ThousandsSeparator = true;
            // 
            // gbFinancing
            // 
            pnlFinancing.Controls.Add(rbCash);
            pnlFinancing.Controls.Add(rbLeasing);
            pnlFinancing.Controls.Add(rbCredit);
            pnlFinancing.Controls.Add(chkFleetDiscount);
            pnlFinancing.Controls.Add(chkSeasonalPromotion);
            pnlFinancing.ForeColor = Color.White;
            pnlFinancing.Location = new Point(20, 220);
            pnlFinancing.BackColor = Color.FromArgb(40, 40, 40);
            pnlFinancing.Name = "gbFinancing";
            pnlFinancing.Size = new Size(400, 160);
            pnlFinancing.TabIndex = 2;
                        // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Checked = true;
            rbCash.Location = new Point(15, 45);
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
            rbLeasing.Location = new Point(130, 45);
            rbLeasing.Name = "rbLeasing";
            rbLeasing.Size = new Size(64, 19);
            rbLeasing.TabIndex = 1;
            rbLeasing.Text = "Leasing";
            rbLeasing.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            rbCredit.AutoSize = true;
            rbCredit.Location = new Point(245, 45);
            rbCredit.Name = "rbCredit";
            rbCredit.Size = new Size(59, 19);
            rbCredit.TabIndex = 2;
            rbCredit.Text = "Kredyt";
            rbCredit.UseVisualStyleBackColor = true;
            // 
            // chkFleetDiscount
            // 
            chkFleetDiscount.AutoSize = true;
            chkFleetDiscount.Location = new Point(15, 85);
            chkFleetDiscount.Name = "chkFleetDiscount";
            chkFleetDiscount.Size = new Size(138, 19);
            chkFleetDiscount.TabIndex = 3;
            chkFleetDiscount.Text = "Rabat flotowy (-5%)";
            chkFleetDiscount.UseVisualStyleBackColor = true;
            // 
            // chkSeasonalPromotion
            // 
            chkSeasonalPromotion.AutoSize = true;
            chkSeasonalPromotion.Location = new Point(15, 115);
            chkSeasonalPromotion.Name = "chkSeasonalPromotion";
            chkSeasonalPromotion.Size = new Size(167, 19);
            chkSeasonalPromotion.TabIndex = 4;
            chkSeasonalPromotion.Text = "Promocja sezonowa (-3%)";
            chkSeasonalPromotion.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            pnlOptions.Controls.Add(clbOptions);
            pnlOptions.ForeColor = Color.White;
            pnlOptions.Location = new Point(440, 60);
            pnlOptions.BackColor = Color.FromArgb(40, 40, 40);
            pnlOptions.Name = "gbOptions";
            pnlOptions.Size = new Size(480, 320);
            pnlOptions.TabIndex = 3;
                        // 
            // clbOptions
            // 
            clbOptions.BackColor = Color.FromArgb(45, 45, 45);
            clbOptions.Font = new Font("Segoe UI", 10F);
            clbOptions.Padding = new Padding(10);
            clbOptions.BorderStyle = BorderStyle.FixedSingle;
            clbOptions.CheckOnClick = true;
            clbOptions.ForeColor = Color.White;
            clbOptions.FormattingEnabled = true;
            clbOptions.Location = new Point(20, 55);
            clbOptions.Name = "clbOptions";
            clbOptions.Size = new Size(440, 240);
            clbOptions.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(64, 168, 252);
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.BorderColor = Color.FromArgb(64, 168, 252);
            btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 168, 252);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(20, 400);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(900, 50);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Oblicz wycenę";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // gbResult
            // 
            pnlResult.Controls.Add(txtBreakdown);
            pnlResult.Controls.Add(lblFinalPriceTitle);
            pnlResult.Controls.Add(lblFinalPrice);
            pnlResult.ForeColor = Color.White;
            pnlResult.Location = new Point(20, 470);
            pnlResult.BackColor = Color.FromArgb(40, 40, 40);
            pnlResult.Name = "gbResult";
            pnlResult.Size = new Size(900, 210);
            pnlResult.TabIndex = 5;
            // lblCarSection
            lblCarSection.AutoSize = true;
            lblCarSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarSection.ForeColor = Color.FromArgb(64, 168, 252);
            lblCarSection.Location = new Point(15, 10);
            lblCarSection.Text = "Samochód i cena";
            pnlCar.Controls.Add(lblCarSection);
            
            // lblFinancingSection
            lblFinancingSection.AutoSize = true;
            lblFinancingSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFinancingSection.ForeColor = Color.FromArgb(64, 168, 252);
            lblFinancingSection.Location = new Point(15, 10);
            lblFinancingSection.Text = "Finansowanie i rabaty";
            pnlFinancing.Controls.Add(lblFinancingSection);
            
            // lblOptionsSection
            lblOptionsSection.AutoSize = true;
            lblOptionsSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOptionsSection.ForeColor = Color.FromArgb(64, 168, 252);
            lblOptionsSection.Location = new Point(15, 10);
            lblOptionsSection.Text = "Dostępne opcje i akcesoria";
            pnlOptions.Controls.Add(lblOptionsSection);
            
            // lblResultSection
            lblResultSection.AutoSize = true;
            lblResultSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResultSection.ForeColor = Color.FromArgb(64, 168, 252);
            lblResultSection.Location = new Point(15, 10);
            lblResultSection.Text = "Wynik wyceny";
            pnlResult.Controls.Add(lblResultSection);

                        // 
            // txtBreakdown
            // 
            txtBreakdown.BackColor = Color.FromArgb(45, 45, 45);
            txtBreakdown.BorderStyle = BorderStyle.FixedSingle;
            txtBreakdown.Font = new Font("Consolas", 10F);
            txtBreakdown.ForeColor = Color.White;
            txtBreakdown.Location = new Point(15, 45);
            txtBreakdown.Multiline = true;
            txtBreakdown.Name = "txtBreakdown";
            txtBreakdown.ReadOnly = true;
            txtBreakdown.ScrollBars = ScrollBars.Vertical;
            txtBreakdown.Size = new Size(440, 150);
            txtBreakdown.TabIndex = 0;
            // 
            // lblFinalPriceTitle
            // 
            lblFinalPriceTitle.AutoSize = true;
            lblFinalPriceTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFinalPriceTitle.ForeColor = Color.White;
            lblFinalPriceTitle.Location = new Point(480, 45);
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
            lblFinalPrice.Location = new Point(480, 80);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(106, 30);
            lblFinalPrice.TabIndex = 2;
            lblFinalPrice.Text = "Wybierz opcje\naby obliczyć.";
            lblFinalPrice.ForeColor = Color.FromArgb(180, 180, 180);
            // 
            // PricingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(950, 700);
            Controls.Add(pnlResult);
            Controls.Add(btnCalculate);
            Controls.Add(pnlOptions);
            Controls.Add(pnlFinancing);
            Controls.Add(pnlCar);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "PricingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars4Us - Kalkulator Wyceny";
            ((System.ComponentModel.ISupportInitialize)numBasePrice).EndInit();
            pnlCar.ResumeLayout(false);
            pnlCar.PerformLayout();
            pnlFinancing.ResumeLayout(false);
            pnlFinancing.PerformLayout();
            pnlOptions.ResumeLayout(false);
            pnlResult.ResumeLayout(false);
            pnlResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblCarSection;
        private Label lblFinancingSection;
        private Label lblOptionsSection;
        private Label lblResultSection;
        private Panel pnlCar;
        private Label lblCar;
        private ComboBox cbCar;
        private Label lblBasePrice;
        private NumericUpDown numBasePrice;
        private Panel pnlFinancing;
        private RadioButton rbCash;
        private RadioButton rbLeasing;
        private RadioButton rbCredit;
        private CheckBox chkFleetDiscount;
        private CheckBox chkSeasonalPromotion;
        private Panel pnlOptions;
        private CheckedListBox clbOptions;
        private Button btnCalculate;
        private Panel pnlResult;
        private TextBox txtBreakdown;
        private Label lblFinalPriceTitle;
        private Label lblFinalPrice;
    }
}
