namespace Assignment7
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
            txtStaticStartKm = new Label();
            txtStaticEndKm = new Label();
            txtStaticPriceKm = new Label();
            txtbxStartKm = new TextBox();
            txtbxEndKm = new TextBox();
            txtbxPriceKm = new TextBox();
            btnErase = new Button();
            btnCalculate = new Button();
            txtStaticPriceExcl = new Label();
            txtStaticVat = new Label();
            txtStaticPriceIncl = new Label();
            txtPriceExcl = new Label();
            txtVat = new Label();
            txtPriceIncl = new Label();
            SuspendLayout();
            // 
            // txtStaticStartKm
            // 
            txtStaticStartKm.AutoSize = true;
            txtStaticStartKm.Location = new Point(12, 48);
            txtStaticStartKm.Name = "txtStaticStartKm";
            txtStaticStartKm.Size = new Size(66, 20);
            txtStaticStartKm.TabIndex = 0;
            txtStaticStartKm.Text = "Start Km";
            // 
            // txtStaticEndKm
            // 
            txtStaticEndKm.AutoSize = true;
            txtStaticEndKm.Location = new Point(12, 90);
            txtStaticEndKm.Name = "txtStaticEndKm";
            txtStaticEndKm.Size = new Size(60, 20);
            txtStaticEndKm.TabIndex = 1;
            txtStaticEndKm.Text = "End Km";
            // 
            // txtStaticPriceKm
            // 
            txtStaticPriceKm.AutoSize = true;
            txtStaticPriceKm.Location = new Point(12, 137);
            txtStaticPriceKm.Name = "txtStaticPriceKm";
            txtStaticPriceKm.Size = new Size(75, 20);
            txtStaticPriceKm.TabIndex = 2;
            txtStaticPriceKm.Text = "Price / km";
            // 
            // txtbxStartKm
            // 
            txtbxStartKm.Location = new Point(138, 45);
            txtbxStartKm.Name = "txtbxStartKm";
            txtbxStartKm.Size = new Size(125, 27);
            txtbxStartKm.TabIndex = 3;
            // 
            // txtbxEndKm
            // 
            txtbxEndKm.Location = new Point(138, 87);
            txtbxEndKm.Name = "txtbxEndKm";
            txtbxEndKm.Size = new Size(125, 27);
            txtbxEndKm.TabIndex = 4;
            // 
            // txtbxPriceKm
            // 
            txtbxPriceKm.Location = new Point(138, 134);
            txtbxPriceKm.Name = "txtbxPriceKm";
            txtbxPriceKm.Size = new Size(125, 27);
            txtbxPriceKm.TabIndex = 5;
            // 
            // btnErase
            // 
            btnErase.Location = new Point(313, 39);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(94, 29);
            btnErase.TabIndex = 6;
            btnErase.Text = "Erase";
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(313, 128);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtStaticPriceExcl
            // 
            txtStaticPriceExcl.AutoSize = true;
            txtStaticPriceExcl.Location = new Point(12, 272);
            txtStaticPriceExcl.Name = "txtStaticPriceExcl";
            txtStaticPriceExcl.Size = new Size(100, 20);
            txtStaticPriceExcl.TabIndex = 8;
            txtStaticPriceExcl.Text = "Price excl VAT";
            // 
            // txtStaticVat
            // 
            txtStaticVat.AutoSize = true;
            txtStaticVat.Location = new Point(138, 272);
            txtStaticVat.Name = "txtStaticVat";
            txtStaticVat.Size = new Size(34, 20);
            txtStaticVat.TabIndex = 9;
            txtStaticVat.Text = "VAT";
            // 
            // txtStaticPriceIncl
            // 
            txtStaticPriceIncl.AutoSize = true;
            txtStaticPriceIncl.Location = new Point(313, 272);
            txtStaticPriceIncl.Name = "txtStaticPriceIncl";
            txtStaticPriceIncl.Size = new Size(97, 20);
            txtStaticPriceIncl.TabIndex = 10;
            txtStaticPriceIncl.Text = "Price incl VAT";
            // 
            // txtPriceExcl
            // 
            txtPriceExcl.AutoSize = true;
            txtPriceExcl.Location = new Point(12, 320);
            txtPriceExcl.Name = "txtPriceExcl";
            txtPriceExcl.Size = new Size(0, 20);
            txtPriceExcl.TabIndex = 11;
            // 
            // txtVat
            // 
            txtVat.AutoSize = true;
            txtVat.Location = new Point(138, 320);
            txtVat.Name = "txtVat";
            txtVat.Size = new Size(0, 20);
            txtVat.TabIndex = 12;
            // 
            // txtPriceIncl
            // 
            txtPriceIncl.AutoSize = true;
            txtPriceIncl.Location = new Point(313, 320);
            txtPriceIncl.Name = "txtPriceIncl";
            txtPriceIncl.Size = new Size(0, 20);
            txtPriceIncl.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(txtPriceIncl);
            Controls.Add(txtVat);
            Controls.Add(txtPriceExcl);
            Controls.Add(txtStaticPriceIncl);
            Controls.Add(txtStaticVat);
            Controls.Add(txtStaticPriceExcl);
            Controls.Add(btnCalculate);
            Controls.Add(btnErase);
            Controls.Add(txtbxPriceKm);
            Controls.Add(txtbxEndKm);
            Controls.Add(txtbxStartKm);
            Controls.Add(txtStaticPriceKm);
            Controls.Add(txtStaticEndKm);
            Controls.Add(txtStaticStartKm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticStartKm;
        private Label txtStaticEndKm;
        private Label txtStaticPriceKm;
        private TextBox txtbxStartKm;
        private TextBox txtbxEndKm;
        private TextBox txtbxPriceKm;
        private Button btnErase;
        private Button btnCalculate;
        private Label txtStaticPriceExcl;
        private Label txtStaticVat;
        private Label txtStaticPriceIncl;
        private Label txtPriceExcl;
        private Label txtVat;
        private Label txtPriceIncl;
    }
}