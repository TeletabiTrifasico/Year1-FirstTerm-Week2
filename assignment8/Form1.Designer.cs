namespace assignment8
{
    partial class Form1
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
            txtStaticNumberShirts = new Label();
            txtStaticNumberJeans = new Label();
            txtbxNumberShirts = new TextBox();
            txtbxNumberJeans = new TextBox();
            btnCalculate = new Button();
            gbxInvoice = new GroupBox();
            txtTimer = new Label();
            txtTotalPrice = new Label();
            txtVat = new Label();
            txtPrice = new Label();
            txtStaticTotalPrice = new Label();
            txtStaticVat = new Label();
            txtStaticPrice = new Label();
            txtStaticDate = new Label();
            gbxInvoice.SuspendLayout();
            SuspendLayout();
            // 
            // txtStaticNumberShirts
            // 
            txtStaticNumberShirts.AutoSize = true;
            txtStaticNumberShirts.Location = new Point(12, 31);
            txtStaticNumberShirts.Name = "txtStaticNumberShirts";
            txtStaticNumberShirts.Size = new Size(204, 20);
            txtStaticNumberShirts.TabIndex = 0;
            txtStaticNumberShirts.Text = "Number of T-shirts (x €30.00):";
            // 
            // txtStaticNumberJeans
            // 
            txtStaticNumberJeans.AutoSize = true;
            txtStaticNumberJeans.Location = new Point(12, 81);
            txtStaticNumberJeans.Name = "txtStaticNumberJeans";
            txtStaticNumberJeans.Size = new Size(198, 20);
            txtStaticNumberJeans.TabIndex = 1;
            txtStaticNumberJeans.Text = "Number of jeans (x €100.00):";
            // 
            // txtbxNumberShirts
            // 
            txtbxNumberShirts.Location = new Point(284, 28);
            txtbxNumberShirts.Name = "txtbxNumberShirts";
            txtbxNumberShirts.Size = new Size(125, 27);
            txtbxNumberShirts.TabIndex = 2;
            // 
            // txtbxNumberJeans
            // 
            txtbxNumberJeans.Location = new Point(284, 78);
            txtbxNumberJeans.Name = "txtbxNumberJeans";
            txtbxNumberJeans.Size = new Size(125, 27);
            txtbxNumberJeans.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Image = Properties.Resources.favicon__2_;
            btnCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalculate.Location = new Point(24, 144);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(373, 59);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // gbxInvoice
            // 
            gbxInvoice.Controls.Add(txtTimer);
            gbxInvoice.Controls.Add(txtTotalPrice);
            gbxInvoice.Controls.Add(txtVat);
            gbxInvoice.Controls.Add(txtPrice);
            gbxInvoice.Controls.Add(txtStaticTotalPrice);
            gbxInvoice.Controls.Add(txtStaticVat);
            gbxInvoice.Controls.Add(txtStaticPrice);
            gbxInvoice.Controls.Add(txtStaticDate);
            gbxInvoice.Location = new Point(12, 234);
            gbxInvoice.Name = "gbxInvoice";
            gbxInvoice.Size = new Size(397, 176);
            gbxInvoice.TabIndex = 5;
            gbxInvoice.TabStop = false;
            gbxInvoice.Text = "Invoice";
            // 
            // txtTimer
            // 
            txtTimer.Anchor = AnchorStyles.Right;
            txtTimer.Location = new Point(174, 38);
            txtTimer.Name = "txtTimer";
            txtTimer.RightToLeft = RightToLeft.Yes;
            txtTimer.Size = new Size(211, 20);
            txtTimer.TabIndex = 7;
            txtTimer.Click += txtTimer_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Anchor = AnchorStyles.Right;
            txtTotalPrice.Location = new Point(306, 133);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.RightToLeft = RightToLeft.No;
            txtTotalPrice.Size = new Size(79, 20);
            txtTotalPrice.TabIndex = 6;
            txtTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtVat
            // 
            txtVat.Anchor = AnchorStyles.Right;
            txtVat.Location = new Point(306, 103);
            txtVat.Name = "txtVat";
            txtVat.RightToLeft = RightToLeft.No;
            txtVat.Size = new Size(79, 20);
            txtVat.TabIndex = 5;
            txtVat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Right;
            txtPrice.Location = new Point(306, 72);
            txtPrice.Name = "txtPrice";
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.Size = new Size(79, 20);
            txtPrice.TabIndex = 4;
            txtPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtStaticTotalPrice
            // 
            txtStaticTotalPrice.AutoSize = true;
            txtStaticTotalPrice.Location = new Point(12, 133);
            txtStaticTotalPrice.Name = "txtStaticTotalPrice";
            txtStaticTotalPrice.Size = new Size(86, 20);
            txtStaticTotalPrice.TabIndex = 3;
            txtStaticTotalPrice.Text = "Total price: ";
            // 
            // txtStaticVat
            // 
            txtStaticVat.AutoSize = true;
            txtStaticVat.Location = new Point(12, 103);
            txtStaticVat.Name = "txtStaticVat";
            txtStaticVat.Size = new Size(41, 20);
            txtStaticVat.TabIndex = 2;
            txtStaticVat.Text = "VAT: ";
            // 
            // txtStaticPrice
            // 
            txtStaticPrice.AutoSize = true;
            txtStaticPrice.Location = new Point(12, 72);
            txtStaticPrice.Name = "txtStaticPrice";
            txtStaticPrice.Size = new Size(48, 20);
            txtStaticPrice.TabIndex = 1;
            txtStaticPrice.Text = "Price: ";
            // 
            // txtStaticDate
            // 
            txtStaticDate.AutoSize = true;
            txtStaticDate.Location = new Point(12, 38);
            txtStaticDate.Name = "txtStaticDate";
            txtStaticDate.Size = new Size(48, 20);
            txtStaticDate.TabIndex = 0;
            txtStaticDate.Text = "Date: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 426);
            Controls.Add(gbxInvoice);
            Controls.Add(btnCalculate);
            Controls.Add(txtbxNumberJeans);
            Controls.Add(txtbxNumberShirts);
            Controls.Add(txtStaticNumberJeans);
            Controls.Add(txtStaticNumberShirts);
            Name = "Form1";
            Text = "Form1";
            gbxInvoice.ResumeLayout(false);
            gbxInvoice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticNumberShirts;
        private Label txtStaticNumberJeans;
        private TextBox txtbxNumberShirts;
        private TextBox txtbxNumberJeans;
        private Button btnCalculate;
        private GroupBox gbxInvoice;
        private Label txtStaticTotalPrice;
        private Label txtStaticVat;
        private Label txtStaticPrice;
        private Label txtStaticDate;
        private Label txtTotalPrice;
        private Label txtVat;
        private Label txtPrice;
        private Label txtTimer;
    }
}