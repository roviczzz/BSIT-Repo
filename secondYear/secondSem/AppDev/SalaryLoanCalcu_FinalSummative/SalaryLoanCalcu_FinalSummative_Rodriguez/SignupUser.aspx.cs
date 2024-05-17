using DataHelperDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace SalaryLoanCalcu_FinalSummative_Rodriguez
{
    public partial class signupUser : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (myData.CheckAccount(txtUserEmail.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                if (IsValid)
                {
                    lblError.Visible = false;
                    myData.RegisterUser(txtUserEmail.Text, txtUserFirstname.Text, txtUserLastname.Text, Double.Parse(txtMonthlySalary.Text), txtUserPassword.Text);
                    Response.Redirect("registrationComplete.aspx");
                }
            }
        }
    }
}