using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataHelper;

namespace FinalAct1_RodriguezBIT21
{
    public partial class myLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataAccess myData = new DataAccess();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (myData.CheckUserAccount(txtUsername.Text, txtPassword.Text))
            {
                Session["customerName"] = myData.FirstName + " " + myData.LastName;
                Session["memType"] = myData.MembershipType;
                Response.Redirect("UserPage.aspx");
            }

        }
    }
}