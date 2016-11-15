namespace BulkCoffeeSales
{
    partial class FormCoffeeBulkSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoffeeBulkSales));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCoffeePrices = new System.Windows.Forms.GroupBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCoffeeType = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxQuantity = new System.Windows.Forms.GroupBox();
            this.radioButtonFullPound = new System.Windows.Forms.RadioButton();
            this.radioButtonHalfPound = new System.Windows.Forms.RadioButton();
            this.radioButtonQuarterPound = new System.Windows.Forms.RadioButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBoxCoffeePrices.SuspendLayout();
            this.groupBoxQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulk Coffee Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anju Chawla";
            // 
            // groupBoxCoffeePrices
            // 
            this.groupBoxCoffeePrices.Controls.Add(this.textBoxPrice);
            this.groupBoxCoffeePrices.Controls.Add(this.comboBoxCoffeeType);
            this.groupBoxCoffeePrices.Controls.Add(this.buttonExit);
            this.groupBoxCoffeePrices.Controls.Add(this.buttonPrint);
            this.groupBoxCoffeePrices.Controls.Add(this.buttonClear);
            this.groupBoxCoffeePrices.Controls.Add(this.buttonFind);
            this.groupBoxCoffeePrices.Controls.Add(this.label4);
            this.groupBoxCoffeePrices.Controls.Add(this.label3);
            this.groupBoxCoffeePrices.Controls.Add(this.groupBoxQuantity);
            this.groupBoxCoffeePrices.Location = new System.Drawing.Point(45, 83);
            this.groupBoxCoffeePrices.Name = "groupBoxCoffeePrices";
            this.groupBoxCoffeePrices.Size = new System.Drawing.Size(441, 234);
            this.groupBoxCoffeePrices.TabIndex = 2;
            this.groupBoxCoffeePrices.TabStop = false;
            this.groupBoxCoffeePrices.Text = "Coffee Prices";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(277, 116);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(121, 22);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.TabStop = false;
            // 
            // comboBoxCoffeeType
            // 
            this.comboBoxCoffeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoffeeType.FormattingEnabled = true;
            this.comboBoxCoffeeType.Items.AddRange(new object[] {
            "Regular",
            "Decaffeinated",
            "Special Blend"});
            this.comboBoxCoffeeType.Location = new System.Drawing.Point(277, 70);
            this.comboBoxCoffeeType.Name = "comboBoxCoffeeType";
            this.comboBoxCoffeeType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCoffeeType.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(340, 184);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(233, 184);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 30);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.Text = "&Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(126, 184);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 30);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(19, 184);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 30);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "&Find Price";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Type";
            // 
            // groupBoxQuantity
            // 
            this.groupBoxQuantity.Controls.Add(this.radioButtonFullPound);
            this.groupBoxQuantity.Controls.Add(this.radioButtonHalfPound);
            this.groupBoxQuantity.Controls.Add(this.radioButtonQuarterPound);
            this.groupBoxQuantity.Location = new System.Drawing.Point(19, 44);
            this.groupBoxQuantity.Name = "groupBoxQuantity";
            this.groupBoxQuantity.Size = new System.Drawing.Size(165, 118);
            this.groupBoxQuantity.TabIndex = 2;
            this.groupBoxQuantity.TabStop = false;
            this.groupBoxQuantity.Text = "Quantity";
            // 
            // radioButtonFullPound
            // 
            this.radioButtonFullPound.AutoSize = true;
            this.radioButtonFullPound.Location = new System.Drawing.Point(22, 80);
            this.radioButtonFullPound.Name = "radioButtonFullPound";
            this.radioButtonFullPound.Size = new System.Drawing.Size(96, 21);
            this.radioButtonFullPound.TabIndex = 2;
            this.radioButtonFullPound.TabStop = true;
            this.radioButtonFullPound.Text = "Fu&ll Pound";
            this.radioButtonFullPound.UseVisualStyleBackColor = true;
            // 
            // radioButtonHalfPound
            // 
            this.radioButtonHalfPound.AutoSize = true;
            this.radioButtonHalfPound.Location = new System.Drawing.Point(22, 53);
            this.radioButtonHalfPound.Name = "radioButtonHalfPound";
            this.radioButtonHalfPound.Size = new System.Drawing.Size(99, 21);
            this.radioButtonHalfPound.TabIndex = 1;
            this.radioButtonHalfPound.TabStop = true;
            this.radioButtonHalfPound.Text = "&Half Pound";
            this.radioButtonHalfPound.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuarterPound
            // 
            this.radioButtonQuarterPound.AutoSize = true;
            this.radioButtonQuarterPound.Location = new System.Drawing.Point(22, 26);
            this.radioButtonQuarterPound.Name = "radioButtonQuarterPound";
            this.radioButtonQuarterPound.Size = new System.Drawing.Size(123, 21);
            this.radioButtonQuarterPound.TabIndex = 0;
            this.radioButtonQuarterPound.TabStop = true;
            this.radioButtonQuarterPound.Text = "&Quarter Pound";
            this.radioButtonQuarterPound.UseVisualStyleBackColor = true;
            this.radioButtonQuarterPound.CheckedChanged += new System.EventHandler(this.radioButtonQuantity_CheckedChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormCoffeeBulkSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 362);
            this.Controls.Add(this.groupBoxCoffeePrices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormCoffeeBulkSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading and Refreshment";
            this.Load += new System.EventHandler(this.FormCoffeeBulkSales_Load);
            this.groupBoxCoffeePrices.ResumeLayout(false);
            this.groupBoxCoffeePrices.PerformLayout();
            this.groupBoxQuantity.ResumeLayout(false);
            this.groupBoxQuantity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCoffeePrices;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxCoffeeType;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxQuantity;
        private System.Windows.Forms.RadioButton radioButtonFullPound;
        private System.Windows.Forms.RadioButton radioButtonHalfPound;
        private System.Windows.Forms.RadioButton radioButtonQuarterPound;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

