namespace UsingDelegate_Rodriguez
{
    partial class calculatorForm
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
            label1 = new Label();
            label2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            label3 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 51);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Input a number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 91);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 1;
            label2.Text = "Input second number value";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(258, 43);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(123, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(258, 83);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(123, 23);
            txtNum2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(84, 161);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(177, 161);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "SUBTRACT";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(273, 161);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 23);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "DIVIDE";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(369, 161);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 23);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "MULTIPLY";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(336, 124);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "RESULT";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(401, 124);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(13, 15);
            lblResult.TabIndex = 9;
            lblResult.Text = "  ";
            // 
            // calculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "calculatorForm";
            Text = "Calculator Using Delegate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnDivide;
        private Button btnMultiply;
        private Label label3;
        private Label lblResult;
    }
}
