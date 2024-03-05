namespace assignment5
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
            txtStaticNumber1 = new Label();
            txtStaticNumber2 = new Label();
            txtStaticNumber3 = new Label();
            btnCalculate = new Button();
            txtStaticAverage = new Label();
            txtbxNumber1 = new TextBox();
            txtbxNumber2 = new TextBox();
            txtbxNumber3 = new TextBox();
            txtAverageOutput = new Label();
            SuspendLayout();
            // 
            // txtStaticNumber1
            // 
            txtStaticNumber1.AutoSize = true;
            txtStaticNumber1.Location = new Point(47, 58);
            txtStaticNumber1.Name = "txtStaticNumber1";
            txtStaticNumber1.Size = new Size(82, 20);
            txtStaticNumber1.TabIndex = 0;
            txtStaticNumber1.Text = "Number 1: ";
            // 
            // txtStaticNumber2
            // 
            txtStaticNumber2.AutoSize = true;
            txtStaticNumber2.Location = new Point(47, 111);
            txtStaticNumber2.Name = "txtStaticNumber2";
            txtStaticNumber2.Size = new Size(78, 20);
            txtStaticNumber2.TabIndex = 1;
            txtStaticNumber2.Text = "Number 2:";
            // 
            // txtStaticNumber3
            // 
            txtStaticNumber3.AutoSize = true;
            txtStaticNumber3.Location = new Point(47, 168);
            txtStaticNumber3.Name = "txtStaticNumber3";
            txtStaticNumber3.Size = new Size(78, 20);
            txtStaticNumber3.TabIndex = 2;
            txtStaticNumber3.Text = "Number 3:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(67, 246);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(363, 29);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate average";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // txtStaticAverage
            // 
            txtStaticAverage.AutoSize = true;
            txtStaticAverage.Location = new Point(47, 346);
            txtStaticAverage.Name = "txtStaticAverage";
            txtStaticAverage.Size = new Size(71, 20);
            txtStaticAverage.TabIndex = 4;
            txtStaticAverage.Text = "Average: ";
            // 
            // txtbxNumber1
            // 
            txtbxNumber1.Location = new Point(316, 55);
            txtbxNumber1.Name = "txtbxNumber1";
            txtbxNumber1.Size = new Size(125, 27);
            txtbxNumber1.TabIndex = 5;
            // 
            // txtbxNumber2
            // 
            txtbxNumber2.Location = new Point(316, 108);
            txtbxNumber2.Name = "txtbxNumber2";
            txtbxNumber2.Size = new Size(125, 27);
            txtbxNumber2.TabIndex = 6;
            // 
            // txtbxNumber3
            // 
            txtbxNumber3.Location = new Point(316, 165);
            txtbxNumber3.Name = "txtbxNumber3";
            txtbxNumber3.Size = new Size(125, 27);
            txtbxNumber3.TabIndex = 7;
            // 
            // txtAverageOutput
            // 
            txtAverageOutput.AutoSize = true;
            txtAverageOutput.Location = new Point(316, 346);
            txtAverageOutput.Name = "txtAverageOutput";
            txtAverageOutput.Size = new Size(0, 20);
            txtAverageOutput.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(txtAverageOutput);
            Controls.Add(txtbxNumber3);
            Controls.Add(txtbxNumber2);
            Controls.Add(txtbxNumber1);
            Controls.Add(txtStaticAverage);
            Controls.Add(btnCalculate);
            Controls.Add(txtStaticNumber3);
            Controls.Add(txtStaticNumber2);
            Controls.Add(txtStaticNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticNumber1;
        private Label txtStaticNumber2;
        private Label txtStaticNumber3;
        private Button btnCalculate;
        private Label txtStaticAverage;
        private TextBox txtbxNumber1;
        private TextBox txtbxNumber2;
        private TextBox txtbxNumber3;
        private Label txtAverageOutput;
    }
}