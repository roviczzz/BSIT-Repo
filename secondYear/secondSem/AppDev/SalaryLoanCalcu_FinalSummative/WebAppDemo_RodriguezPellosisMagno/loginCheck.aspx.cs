using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class loginCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataAccess.DataAccess myData = new DataAccess.DataAccess();

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