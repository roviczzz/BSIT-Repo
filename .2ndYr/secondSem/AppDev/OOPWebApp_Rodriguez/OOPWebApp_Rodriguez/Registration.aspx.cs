using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OOPWebApp_Rodriguez
{
    public partial class Registration : System.Web.UI.Page
    {
        public static bool discount;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                Session.Add("fName", txtFirstname.Text);
                Session.Add("lName", txtLastname.Text);
                Session.Add("bDay", txtBirthday.Text);
                Session.Add("membershipType", membershipType.SelectedValue);
                lblID.Text = Generation.memberIDGen(txtFirstname.Text, txtLastname.Text);
                Session.Add("ID", lblID.Text);
                TransactionPanel.Visible = true;
            }
        }

        protected void membershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (membershipType.SelectedIndex == 1)
            {
                lblDiscount.Text = "Silver - 12% Discount";
            }
            else if (membershipType.SelectedIndex == 2)
            {
                lblDiscount.Text = "Gold - 15% Discount";
            }

            else if (membershipType.SelectedIndex == 3)
            {
                lblDiscount.Text = "Platinum - 20% Discount";
            }
            else
            {
                lblDiscount.Text = string.Empty;
            }
        }

        protected void btnAddCart_Click(object sender, EventArgs e)
        {
            int prod1 = Convert.ToInt32(Label1.Text);
            int prod2 = Convert.ToInt32(Label2.Text);
            int prod3 = Convert.ToInt32(Label3.Text);
            int prod4 = Convert.ToInt32(Label4.Text);
            switch (DropDownProductList.SelectedIndex)
            {
                case 1:
                    prod1++;
                    Label1.Text = prod1.ToString();
                    break;

                case 2:
                    prod2++;
                    Label2.Text = prod2.ToString();
                    break;

                case 3:
                    prod3++;
                    Label3.Text = prod3.ToString();
                    break;

                case 4:
                    prod4++;
                    Label4.Text = prod4.ToString();
                    break;
            }

            
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            int prod1 = Convert.ToInt32(Label1.Text);
            int prod2 = Convert.ToInt32(Label2.Text);
            int prod3 = Convert.ToInt32(Label3.Text);
            int prod4 = Convert.ToInt32(Label4.Text);
            if (prod1 + prod2 + prod3 + prod4 >= 3)
            {
                discount = true;
            }
            else
            {
                discount = false;
            }

            Session.Add("q1", prod1.ToString());
            Session.Add("q2", prod2.ToString());
            Session.Add("q3", prod3.ToString());
            Session.Add("q4", prod4.ToString());
            Response.Redirect("Transaction-Page.aspx");
        }
    }
}