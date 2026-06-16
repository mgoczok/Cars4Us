namespace Cars4Us
{
    partial class OptionsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvOptions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nazwa:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 15);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategoria:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Cena:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 23);
            this.txtName.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "SafetyPackage",
            "Multimedia",
            "Wheels",
            "Comfort",
            "Warranty",
            "ExteriorProtection"});
            this.cbCategory.Location = new System.Drawing.Point(100, 67);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 23);
            this.cbCategory.TabIndex = 4;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(100, 108);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(150, 23);
            this.numPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Aktualizuj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(200, 150);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(90, 23);
            this.btnDeactivate.TabIndex = 8;
            this.btnDeactivate.Text = "Dezaktywuj";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(300, 150);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(385, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvOptions
            // 
            this.dgvOptions.AllowUserToAddRows = false;
            this.dgvOptions.AllowUserToDeleteRows = false;
            this.dgvOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOptions.Location = new System.Drawing.Point(30, 190);
            this.dgvOptions.MultiSelect = false;
            this.dgvOptions.Name = "dgvOptions";
            this.dgvOptions.ReadOnly = true;
            this.dgvOptions.RowTemplate.Height = 25;
            this.dgvOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOptions.Size = new System.Drawing.Size(550, 200);
            this.dgvOptions.TabIndex = 11;
            this.dgvOptions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOptions_CellClick);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.dgvOptions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblName);
            this.Name = "OptionsForm";
            this.Text = "Zarządzanie Opcjami";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvOptions;
    }
}
