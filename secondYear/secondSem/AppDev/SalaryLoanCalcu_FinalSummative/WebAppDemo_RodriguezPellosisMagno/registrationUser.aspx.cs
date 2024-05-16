using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class registrationUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataAccess.DataAccess myData = new DataAccess.DataAccess();
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
                    myData.RegisterUser(txtUserEmail.Text, txtUserName.Text, txtUserPhone.Text, txtUserPassword.Text, ddMemType.SelectedValue);
                    Response.Redirect("registrationComplete.aspx");
                }
            }
        }
    }
}