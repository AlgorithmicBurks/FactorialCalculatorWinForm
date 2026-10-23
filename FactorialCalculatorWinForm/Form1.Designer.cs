namespace FactorialCalculatorWinForm
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
            btnCalculate = new Button();
            btnExit = new Button();
            lblNumber = new Label();
            lblFactorial = new Label();
            TxtNumber = new TextBox();
            TxtFactorial = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(87, 251);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(132, 64);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(300, 250);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 65);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(58, 56);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(66, 20);
            lblNumber.TabIndex = 2;
            lblNumber.Text = "Number:";
            lblNumber.Click += lblNumber1_Click;
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(58, 161);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(68, 20);
            lblFactorial.TabIndex = 3;
            lblFactorial.Text = "Factorial:";
            // 
            // TxtNumber
            // 
            TxtNumber.Location = new Point(215, 56);
            TxtNumber.Name = "TxtNumber";
            TxtNumber.Size = new Size(125, 27);
            TxtNumber.TabIndex = 4;
            // 
            // TxtFactorial
            // 
            TxtFactorial.Location = new Point(215, 161);
            TxtFactorial.Name = "TxtFactorial";
            TxtFactorial.Size = new Size(125, 27);
            TxtFactorial.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtFactorial);
            Controls.Add(TxtNumber);
            Controls.Add(lblFactorial);
            Controls.Add(lblNumber);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Factorial Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private Label lblNumber;
        private Label lblFactorial;
        private TextBox TxtNumber;
        private TextBox TxtFactorial;
    }
}
