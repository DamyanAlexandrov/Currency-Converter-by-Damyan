namespace Currency_Converter
{
    partial class ConversionForm
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
            this.numericUpDowAmmount = new System.Windows.Forms.NumericUpDown();
            this.currency = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowAmmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDowAmmount
            // 
            this.numericUpDowAmmount.DecimalPlaces = 2;
            this.numericUpDowAmmount.Location = new System.Drawing.Point(12, 42);
            this.numericUpDowAmmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDowAmmount.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDowAmmount.Name = "numericUpDowAmmount";
            this.numericUpDowAmmount.Size = new System.Drawing.Size(105, 23);
            this.numericUpDowAmmount.TabIndex = 0;
            this.numericUpDowAmmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(208, 44);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(69, 15);
            this.currency.TabIndex = 1;
            this.currency.Text = "BGN to EUR";
            this.currency.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultLable
            // 
            this.resultLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.resultLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLable.Location = new System.Drawing.Point(12, 79);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(291, 31);
            this.resultLable.TabIndex = 2;
            this.resultLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLable.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(127, 40);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 3;
            this.ResultButton.Text = "Convert";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.numericUpDowAmmount);
            this.Name = "ConversionForm";
            this.Text = "CurrencyConverterByUsername";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowAmmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDowAmmount;
        private Label currency;
        private Label resultLable;
        private Button ResultButton;
    }
}