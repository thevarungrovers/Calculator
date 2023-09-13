namespace prjWinCsFinalProject
{
    partial class frmOfflineCurrencyConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCurrencyFrom = new System.Windows.Forms.Label();
            this.lblCurrencyTo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCurrencyTo = new System.Windows.Forms.RadioButton();
            this.radCurrencyFrom = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblSelectedCurrency = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "XCHANGE OFFICE";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(28, 69);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(121, 21);
            this.cboCountry.TabIndex = 1;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // lblCurrencyFrom
            // 
            this.lblCurrencyFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrencyFrom.Location = new System.Drawing.Point(304, 88);
            this.lblCurrencyFrom.Name = "lblCurrencyFrom";
            this.lblCurrencyFrom.Size = new System.Drawing.Size(254, 32);
            this.lblCurrencyFrom.TabIndex = 2;
            this.lblCurrencyFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrencyTo
            // 
            this.lblCurrencyTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrencyTo.Location = new System.Drawing.Point(304, 139);
            this.lblCurrencyTo.Name = "lblCurrencyTo";
            this.lblCurrencyTo.Size = new System.Drawing.Size(254, 32);
            this.lblCurrencyTo.TabIndex = 3;
            this.lblCurrencyTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(28, 328);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(140, 32);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCurrencyTo);
            this.groupBox1.Controls.Add(this.radCurrencyFrom);
            this.groupBox1.Location = new System.Drawing.Point(28, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Type";
            // 
            // radCurrencyTo
            // 
            this.radCurrencyTo.AutoSize = true;
            this.radCurrencyTo.Location = new System.Drawing.Point(18, 56);
            this.radCurrencyTo.Name = "radCurrencyTo";
            this.radCurrencyTo.Size = new System.Drawing.Size(14, 13);
            this.radCurrencyTo.TabIndex = 7;
            this.radCurrencyTo.TabStop = true;
            this.radCurrencyTo.UseVisualStyleBackColor = true;
            this.radCurrencyTo.CheckedChanged += new System.EventHandler(this.radCurrencyTo_CheckedChanged);
            // 
            // radCurrencyFrom
            // 
            this.radCurrencyFrom.AutoSize = true;
            this.radCurrencyFrom.Location = new System.Drawing.Point(18, 28);
            this.radCurrencyFrom.Name = "radCurrencyFrom";
            this.radCurrencyFrom.Size = new System.Drawing.Size(14, 13);
            this.radCurrencyFrom.TabIndex = 6;
            this.radCurrencyFrom.TabStop = true;
            this.radCurrencyFrom.UseVisualStyleBackColor = true;
            this.radCurrencyFrom.CheckedChanged += new System.EventHandler(this.radCurrencyFrom_CheckedChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(323, 245);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(107, 26);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(509, 237);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(92, 21);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(509, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 21);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(509, 291);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(92, 21);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblSelectedCurrency
            // 
            this.lblSelectedCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedCurrency.Location = new System.Drawing.Point(323, 198);
            this.lblSelectedCurrency.Name = "lblSelectedCurrency";
            this.lblSelectedCurrency.Size = new System.Drawing.Size(107, 32);
            this.lblSelectedCurrency.TabIndex = 11;
            this.lblSelectedCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOfflineCurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(657, 388);
            this.Controls.Add(this.lblSelectedCurrency);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCurrencyTo);
            this.Controls.Add(this.lblCurrencyFrom);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "frmOfflineCurrencyConverter";
            this.Text = "Currency Converter - Offline";
            this.Load += new System.EventHandler(this.frmOfflineCurrencyConverter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCurrencyFrom;
        private System.Windows.Forms.Label lblCurrencyTo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCurrencyFrom;
        private System.Windows.Forms.RadioButton radCurrencyTo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblSelectedCurrency;
    }
}