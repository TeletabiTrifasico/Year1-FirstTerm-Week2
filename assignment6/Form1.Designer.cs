namespace assignment6
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
            txtStaticSeconds = new Label();
            txtbxInput = new TextBox();
            btnCalculateTime = new Button();
            txtStaticTimeDisplay = new Label();
            txtTimeOutput = new Label();
            SuspendLayout();
            // 
            // txtStaticSeconds
            // 
            txtStaticSeconds.AutoSize = true;
            txtStaticSeconds.Location = new Point(58, 61);
            txtStaticSeconds.Name = "txtStaticSeconds";
            txtStaticSeconds.Size = new Size(71, 20);
            txtStaticSeconds.TabIndex = 0;
            txtStaticSeconds.Text = "Seconds: ";
            // 
            // txtbxInput
            // 
            txtbxInput.Location = new Point(313, 58);
            txtbxInput.Name = "txtbxInput";
            txtbxInput.Size = new Size(125, 27);
            txtbxInput.TabIndex = 1;
            // 
            // btnCalculateTime
            // 
            btnCalculateTime.Location = new Point(88, 130);
            btnCalculateTime.Name = "btnCalculateTime";
            btnCalculateTime.Size = new Size(323, 29);
            btnCalculateTime.TabIndex = 2;
            btnCalculateTime.Text = "Calculate time";
            btnCalculateTime.UseVisualStyleBackColor = true;
            btnCalculateTime.Click += btnCalculateTime_Click;
            // 
            // txtStaticTimeDisplay
            // 
            txtStaticTimeDisplay.AutoSize = true;
            txtStaticTimeDisplay.Location = new Point(58, 211);
            txtStaticTimeDisplay.Name = "txtStaticTimeDisplay";
            txtStaticTimeDisplay.Size = new Size(172, 20);
            txtStaticTimeDisplay.TabIndex = 3;
            txtStaticTimeDisplay.Text = "hours : minutes : seconds";
            // 
            // txtTimeOutput
            // 
            txtTimeOutput.AutoSize = true;
            txtTimeOutput.Location = new Point(58, 254);
            txtTimeOutput.Name = "txtTimeOutput";
            txtTimeOutput.Size = new Size(0, 20);
            txtTimeOutput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 326);
            Controls.Add(txtTimeOutput);
            Controls.Add(txtStaticTimeDisplay);
            Controls.Add(btnCalculateTime);
            Controls.Add(txtbxInput);
            Controls.Add(txtStaticSeconds);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticSeconds;
        private TextBox txtbxInput;
        private Button btnCalculateTime;
        private Label txtStaticTimeDisplay;
        private Label txtTimeOutput;
    }
}