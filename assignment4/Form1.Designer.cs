namespace assignment4
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
            lblStaticEnterPrice = new Label();
            btnCalculateVat = new Button();
            lblStaticPrice = new Label();
            lblStaticTotal = new Label();
            lblStaticVat = new Label();
            txtbxUsersInput = new TextBox();
            txtPriceOutput = new Label();
            txtVatOutput = new Label();
            txtTotalOutput = new Label();
            SuspendLayout();
            // 
            // lblStaticEnterPrice
            // 
            lblStaticEnterPrice.AccessibleDescription = "";
            lblStaticEnterPrice.AccessibleName = "";
            lblStaticEnterPrice.AutoSize = true;
            lblStaticEnterPrice.Location = new Point(59, 65);
            lblStaticEnterPrice.Name = "lblStaticEnterPrice";
            lblStaticEnterPrice.Size = new Size(99, 20);
            lblStaticEnterPrice.TabIndex = 0;
            lblStaticEnterPrice.Tag = "";
            lblStaticEnterPrice.Text = "Enter a price: ";
            lblStaticEnterPrice.Click += lblStaticEnterPrice_Click;
            // 
            // btnCalculateVat
            // 
            btnCalculateVat.AccessibleDescription = "";
            btnCalculateVat.AccessibleName = "";
            btnCalculateVat.Location = new Point(59, 148);
            btnCalculateVat.Name = "btnCalculateVat";
            btnCalculateVat.Size = new Size(403, 29);
            btnCalculateVat.TabIndex = 2;
            btnCalculateVat.Tag = "";
            btnCalculateVat.Text = "Determine VAT";
            btnCalculateVat.UseVisualStyleBackColor = true;
            btnCalculateVat.Click += btnCalculateVat_Click;
            // 
            // lblStaticPrice
            // 
            lblStaticPrice.AccessibleDescription = "";
            lblStaticPrice.AccessibleName = "";
            lblStaticPrice.AutoSize = true;
            lblStaticPrice.Location = new Point(59, 241);
            lblStaticPrice.Name = "lblStaticPrice";
            lblStaticPrice.Size = new Size(48, 20);
            lblStaticPrice.TabIndex = 3;
            lblStaticPrice.Tag = "";
            lblStaticPrice.Text = "Price: ";
            lblStaticPrice.Click += lblStaticPrice_Click;
            // 
            // lblStaticTotal
            // 
            lblStaticTotal.AutoSize = true;
            lblStaticTotal.Location = new Point(59, 399);
            lblStaticTotal.Name = "lblStaticTotal";
            lblStaticTotal.Size = new Size(49, 20);
            lblStaticTotal.TabIndex = 5;
            lblStaticTotal.Text = "Total: ";
            lblStaticTotal.Click += lblStaticTotal_Click;
            // 
            // lblStaticVat
            // 
            lblStaticVat.AutoSize = true;
            lblStaticVat.Location = new Point(59, 321);
            lblStaticVat.Name = "lblStaticVat";
            lblStaticVat.Size = new Size(41, 20);
            lblStaticVat.TabIndex = 6;
            lblStaticVat.Text = "VAT: ";
            lblStaticVat.Click += lblStaticVat_Click;
            // 
            // txtbxUsersInput
            // 
            txtbxUsersInput.Location = new Point(337, 62);
            txtbxUsersInput.Name = "txtbxUsersInput";
            txtbxUsersInput.Size = new Size(125, 27);
            txtbxUsersInput.TabIndex = 7;
            txtbxUsersInput.TextChanged += txtbxUsersInput_TextChanged;
            // 
            // txtPriceOutput
            // 
            txtPriceOutput.AutoSize = true;
            txtPriceOutput.Location = new Point(369, 241);
            txtPriceOutput.Name = "txtPriceOutput";
            txtPriceOutput.Size = new Size(0, 20);
            txtPriceOutput.TabIndex = 8;
            // 
            // txtVatOutput
            // 
            txtVatOutput.AutoSize = true;
            txtVatOutput.Location = new Point(369, 321);
            txtVatOutput.Name = "txtVatOutput";
            txtVatOutput.Size = new Size(0, 20);
            txtVatOutput.TabIndex = 9;
            // 
            // txtTotalOutput
            // 
            txtTotalOutput.AutoSize = true;
            txtTotalOutput.Location = new Point(369, 399);
            txtTotalOutput.Name = "txtTotalOutput";
            txtTotalOutput.Size = new Size(0, 20);
            txtTotalOutput.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 507);
            Controls.Add(txtTotalOutput);
            Controls.Add(txtVatOutput);
            Controls.Add(txtPriceOutput);
            Controls.Add(txtbxUsersInput);
            Controls.Add(lblStaticVat);
            Controls.Add(lblStaticTotal);
            Controls.Add(lblStaticPrice);
            Controls.Add(btnCalculateVat);
            Controls.Add(lblStaticEnterPrice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStaticEnterPrice;
        private Button btnCalculateVat;
        private Label lblStaticPrice;
        private Label lblStaticTotal;
        private Label lblStaticVat;
        private TextBox txtbxUsersInput;
        private Label txtPriceOutput;
        private Label txtVatOutput;
        private Label txtTotalOutput;
    }
}