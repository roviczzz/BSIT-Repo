using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OOPWebAppCSS_RodriguezBIT21
{
    public partial class Transaction_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = Session["fName"].ToString() + " " + Session["lName"].ToString();
            lblID.Text = Session["ID"].ToString();
            lblMemberType.Text = Session["membershipType"].ToString();

            lblq1.Text = Session["q1"].ToString();
            lblq2.Text = Session["q2"].ToString();
            lblq3.Text = Session["q3"].ToString();
            lblq4.Text = Session["q4"].ToString();

            lblp1.Text = Computation.CompP1(Convert.ToInt32(Session["q1"])).ToString("N2");
            lblp2.Text = Computation.CompP2(Convert.ToInt32(Session["q2"])).ToString("N2");
            lblp3.Text = Computation.CompP3(Convert.ToInt32(Session["q3"])).ToString("N2");
            lblp4.Text = Computation.CompP4(Convert.ToInt32(Session["q4"])).ToString("N2");

            lblp5.Text = Computation.CompTotal().ToString("N2");
            lblp6.Text = Computation.CompDiscount(Registration.discount, Session["membershipType"].ToString()).ToString("N2");
            lblp7.Text = Computation.compGrandTotal().ToString("N2");



            if (Registration.discount != true)
            {
                lblDiscount0.Text = "No Discount Applied";
                lblp6.Visible = false;
            }
            else
            {
                switch (lblMemberType.Text)
                {
                    case "Silver":
                        lblDiscount0.Text = "12%";
                        break;

                    case "Gold":
                        lblDiscount0.Text = "15%";
                        break;

                    case "Platinum":
                        lblDiscount0.Text = "20%";
                        break;
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}