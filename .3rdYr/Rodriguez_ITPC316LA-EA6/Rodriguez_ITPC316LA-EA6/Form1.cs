using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rodriguez_ITPC316LA_EA6
{
    public partial class OrderApplication : Form
    {
        public int Fries = 72, Burger = 58, Spaghetti = 65, Drinks = 39, Chicken = 98;

        private void OrderApplication_Load(object sender, EventArgs e)
        {

        }
        public OrderApplication()
        {
            InitializeComponent();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            labelOrderList.Text = "";

            int qtyFries = Convert.ToInt32(txtFries.Value.ToString()) * Fries;
            int qtyBurger = Convert.ToInt32(txtBurger.Value.ToString()) * Burger;
            int qtySpaghetti = Convert.ToInt32(txtSpaghetti.Value.ToString()) * Spaghetti;
            int qtyDrinks = Convert.ToInt32(txtDrinks.Value.ToString()) * Drinks;
            int qtyChicken = Convert.ToInt32(txtChicken.Value.ToString()) * Chicken;

            double totalAmt = qtyFries + qtyBurger + qtySpaghetti + qtyDrinks + qtyChicken;
            double discount, totalPrice;

            switch (checkedListBox1.SelectedIndex)
            {
                case 0:
                    discount = totalAmt * .20;
                    labelDiscount.Text = "Discount: Php " + discount.ToString();

                    totalPrice = totalAmt - discount;
                    labelTotal.Text = "Total: Php " + totalPrice.ToString();
                    break;

                case 1:
                    discount = totalAmt * .15;
                    labelDiscount.Text = "Discount: Php " + discount.ToString();
                    
                    totalPrice = totalAmt - discount;
                    labelTotal.Text = "Total: Php " + totalPrice.ToString();
                    break;

                case 2:
                    discount = totalAmt * .10;
                    labelDiscount.Text = "Discount: Php " + discount.ToString();
                    
                    totalPrice = totalAmt - discount;
                    labelTotal.Text = "Total: Php " + totalPrice.ToString();
                    break;

                default:
                    labelDiscount.Text = "Discount: Php 0.00";

                    totalPrice = totalAmt;
                    labelTotal.Text = "Total: Php " + totalPrice.ToString();
                    break;
            }

            labelSubtotal.Text = "Subtotal: Php " + totalAmt.ToString();

            if (qtyFries != 0)
                labelOrderList.Text += "\r\n " + "Fries: " + Convert.ToInt32(txtFries.Value.ToString());
            if (qtyBurger != 0)
                labelOrderList.Text += "\r\n " + "Burger: " + Convert.ToInt32(txtBurger.Value.ToString());
            if (qtySpaghetti != 0)
                labelOrderList.Text += "\r\n " + "Spaghetti: " + Convert.ToInt32(txtSpaghetti.Value.ToString());
            if (qtyDrinks != 0)
                labelOrderList.Text += "\r\n " + "Drinks: " + Convert.ToInt32(txtDrinks.Value.ToString());
            if (qtyChicken != 0)
                labelOrderList.Text += "\r\n " + "Chicken: " + Convert.ToInt32(txtChicken.Value.ToString());
        }

        private void buttonRetry_Click(object sender, EventArgs e)
        {
            txtChicken.ResetText();
            txtBurger.ResetText();
            txtSpaghetti.ResetText();
            txtDrinks.ResetText();
            txtChicken.ResetText();
            checkedListBox1.ResetText();
            labelOrderList.Text = "";

            labelSubtotal.Text = "Subtotal: Php 0.00";
            labelDiscount.Text = "Discount: Php 0.00";
            labelTotal.Text = "Total: Php 0.00";
        }
    }
}
