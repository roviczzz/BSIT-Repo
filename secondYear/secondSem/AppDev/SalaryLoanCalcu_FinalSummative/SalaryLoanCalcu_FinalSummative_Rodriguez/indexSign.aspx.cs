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
    public partial class indexSign : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email;
            if (IsValid)
            {
                email = txtUserName.Text;
                if (myData.CheckAccount(email) == true)
                {
                    Session["Email"] = txtUserName.Text;
                    if (myData.AccType == true)
                    {
                        Response.Redirect("loginUser.aspx");
                    }//false admin, true user
                    else
                    {
                        Response.Redirect("loginAdmin.aspx");
                    }
                }
                else
                {
                    Response.Redirect("registration.aspx");
                }

            }
        }
    }
}