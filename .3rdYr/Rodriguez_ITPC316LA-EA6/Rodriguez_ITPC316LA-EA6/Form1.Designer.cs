namespace Rodriguez_ITPC316LA_EA6
{
    partial class OrderApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.buttonRetry = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelOrderList = new System.Windows.Forms.Label();
            this.txtFries = new System.Windows.Forms.NumericUpDown();
            this.txtBurger = new System.Windows.Forms.NumericUpDown();
            this.txtSpaghetti = new System.Windows.Forms.NumericUpDown();
            this.txtDrinks = new System.Windows.Forms.NumericUpDown();
            this.txtChicken = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpaghetti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChicken)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Burger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spaghetti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Drinks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chicken";
            // 
            // buttonCompute
            // 
            this.buttonCompute.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCompute.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompute.Location = new System.Drawing.Point(129, 286);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(109, 35);
            this.buttonCompute.TabIndex = 13;
            this.buttonCompute.Text = "Compute";
            this.buttonCompute.UseVisualStyleBackColor = false;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // buttonRetry
            // 
            this.buttonRetry.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRetry.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetry.Location = new System.Drawing.Point(129, 333);
            this.buttonRetry.Name = "buttonRetry";
            this.buttonRetry.Size = new System.Drawing.Size(109, 35);
            this.buttonRetry.TabIndex = 14;
            this.buttonRetry.Text = "Clear";
            this.buttonRetry.UseVisualStyleBackColor = false;
            this.buttonRetry.Click += new System.EventHandler(this.buttonRetry_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(330, 247);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(107, 15);
            this.labelSubtotal.TabIndex = 15;
            this.labelSubtotal.Text = "Subtotal: Php 0.00";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(330, 272);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(111, 15);
            this.labelDiscount.TabIndex = 16;
            this.labelDiscount.Text = "Discount: Php 0.00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(330, 297);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(88, 15);
            this.labelTotal.TabIndex = 17;
            this.labelTotal.Text = "Total: Php 0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(674, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Orders:";
            // 
            // labelOrderList
            // 
            this.labelOrderList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderList.Location = new System.Drawing.Point(674, 272);
            this.labelOrderList.Name = "labelOrderList";
            this.labelOrderList.Size = new System.Drawing.Size(114, 108);
            this.labelOrderList.TabIndex = 19;
            // 
            // txtFries
            // 
            this.txtFries.Location = new System.Drawing.Point(138, 75);
            this.txtFries.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtFries.Name = "txtFries";
            this.txtFries.Size = new System.Drawing.Size(109, 20);
            this.txtFries.TabIndex = 20;
            // 
            // txtBurger
            // 
            this.txtBurger.Location = new System.Drawing.Point(138, 118);
            this.txtBurger.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtBurger.Name = "txtBurger";
            this.txtBurger.Size = new System.Drawing.Size(109, 20);
            this.txtBurger.TabIndex = 21;
            // 
            // txtSpaghetti
            // 
            this.txtSpaghetti.Location = new System.Drawing.Point(138, 161);
            this.txtSpaghetti.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtSpaghetti.Name = "txtSpaghetti";
            this.txtSpaghetti.Size = new System.Drawing.Size(109, 20);
            this.txtSpaghetti.TabIndex = 22;
            // 
            // txtDrinks
            // 
            this.txtDrinks.Location = new System.Drawing.Point(138, 204);
            this.txtDrinks.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtDrinks.Name = "txtDrinks";
            this.txtDrinks.Size = new System.Drawing.Size(109, 20);
            this.txtDrinks.TabIndex = 23;
            // 
            // txtChicken
            // 
            this.txtChicken.Location = new System.Drawing.Point(138, 247);
            this.txtChicken.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtChicken.Name = "txtChicken";
            this.txtChicken.Size = new System.Drawing.Size(109, 20);
            this.txtChicken.TabIndex = 24;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Senior/pwd (20%)",
            "Manager discount (15%)",
            "Member\'s Discount (10%)"});
            this.checkedListBox1.Location = new System.Drawing.Point(333, 75);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(170, 84);
            this.checkedListBox1.TabIndex = 25;
            // 
            // OrderApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtChicken);
            this.Controls.Add(this.txtDrinks);
            this.Controls.Add(this.txtSpaghetti);
            this.Controls.Add(this.txtBurger);
            this.Controls.Add(this.txtFries);
            this.Controls.Add(this.labelOrderList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.buttonRetry);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderApplication";
            this.Text = "Order Application";
            this.Load += new System.EventHandler(this.OrderApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpaghetti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChicken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Button buttonRetry;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelOrderList;
        private System.Windows.Forms.NumericUpDown txtFries;
        private System.Windows.Forms.NumericUpDown txtBurger;
        private System.Windows.Forms.NumericUpDown txtSpaghetti;
        private System.Windows.Forms.NumericUpDown txtDrinks;
        private System.Windows.Forms.NumericUpDown txtChicken;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

