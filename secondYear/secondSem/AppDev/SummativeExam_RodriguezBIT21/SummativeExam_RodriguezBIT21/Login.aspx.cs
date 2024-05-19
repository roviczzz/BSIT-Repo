using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataHelper;

namespace Alonzo___Final_Exam
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }
        DataAccess myData = new DataAccess();
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (myData.UserExists(txtUsername.Text))
            {
                if (myData.CheckUser(txtUsername.Text, txtPassword.Text))
                {
                    lblIncorrect.Visible = false;
                    if (myData.Usertype == "Client")
                    {
                        Session["BasicMonthly"] = myData.BasicMonthly1;
                        Session["Email"] = myData.Email;
                        Response.Redirect("LoanCalculator.aspx");
                    }

                    if (myData.Usertype == "Admin")
                    {
                        Response.Redirect("ViewPending.aspx");
                    }

                }
                else
                {
                    lblIncorrect.Visible = true;
                }
            }
            else
            {
                Response.Redirect("Registration.aspx");
            }
        }
    }
}