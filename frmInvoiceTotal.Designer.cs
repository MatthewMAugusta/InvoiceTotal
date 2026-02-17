namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            btnCalculate = new Button();
            button2 = new Button();
            invoiceSubTotal = new TextBox();
            txtDiscountPct = new TextBox();
            txtDiscountAmt = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(53, 166);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 28);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 166);
            button2.Name = "button2";
            button2.Size = new Size(85, 28);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // invoiceSubTotal
            // 
            invoiceSubTotal.BorderStyle = BorderStyle.FixedSingle;
            invoiceSubTotal.Location = new Point(144, 27);
            invoiceSubTotal.Name = "invoiceSubTotal";
            invoiceSubTotal.Size = new Size(115, 23);
            invoiceSubTotal.TabIndex = 2;
            // 
            // txtDiscountPct
            // 
            txtDiscountPct.BorderStyle = BorderStyle.FixedSingle;
            txtDiscountPct.Location = new Point(144, 56);
            txtDiscountPct.Name = "txtDiscountPct";
            txtDiscountPct.Size = new Size(115, 23);
            txtDiscountPct.TabIndex = 3;
            // 
            // txtDiscountAmt
            // 
            txtDiscountAmt.BorderStyle = BorderStyle.FixedSingle;
            txtDiscountAmt.Location = new Point(144, 85);
            txtDiscountAmt.Name = "txtDiscountAmt";
            txtDiscountAmt.Size = new Size(115, 23);
            txtDiscountAmt.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(144, 114);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(115, 23);
            txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 58);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 7;
            label2.Text = "Discount Percent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 87);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 8;
            label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 116);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Total:";
            // 
            // frmInvoiceTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 209);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmt);
            Controls.Add(txtDiscountPct);
            Controls.Add(invoiceSubTotal);
            Controls.Add(button2);
            Controls.Add(btnCalculate);
            Name = "frmInvoiceTotal";
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button button2;
        private TextBox invoiceSubTotal;
        private TextBox txtDiscountPct;
        private TextBox txtDiscountAmt;
        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
