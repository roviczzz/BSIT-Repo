namespace GradeCalculator_RodriguezBIT33
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
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            txtCourseSection = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtFinal = new TextBox();
            txtMid = new TextBox();
            button1 = new Button();
            lblAvgGrade = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtCourseSection);
            groupBox1.Controls.Add(txtLname);
            groupBox1.Controls.Add(txtFname);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(48, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Details";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(123, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtCourseSection
            // 
            txtCourseSection.Location = new Point(123, 119);
            txtCourseSection.Name = "txtCourseSection";
            txtCourseSection.Size = new Size(88, 23);
            txtCourseSection.TabIndex = 6;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(123, 61);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(153, 23);
            txtLname.TabIndex = 5;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(123, 31);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(153, 23);
            txtFname.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 127);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Course & Section";
            label4.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Birthday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(txtFinal);
            groupBox2.Controls.Add(txtMid);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(lblAvgGrade);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(542, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(225, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Grade Details";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(65, 53);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(88, 23);
            txtFinal.TabIndex = 10;
            // 
            // txtMid
            // 
            txtMid.Location = new Point(65, 23);
            txtMid.Name = "txtMid";
            txtMid.Size = new Size(88, 23);
            txtMid.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(74, 146);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 8;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblAvgGrade
            // 
            lblAvgGrade.AutoSize = true;
            lblAvgGrade.Location = new Point(99, 107);
            lblAvgGrade.Name = "lblAvgGrade";
            lblAvgGrade.Size = new Size(0, 15);
            lblAvgGrade.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 107);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 6;
            label7.Text = "Average Grade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 61);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 5;
            label6.Text = "Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 31);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Midterm";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label lblAvgGrade;
        private Label label7;
        private Label label6;
        private TextBox txtCourseSection;
        private TextBox txtLname;
        private TextBox txtFname;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtFinal;
        private TextBox txtMid;
    }
}
