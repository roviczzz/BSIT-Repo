using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class registrationAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataAccess.DataAccess myData = new DataAccess.DataAccess();
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (myData.CheckAccount(txtAdminEmail.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                if (IsValid)
                {
                    lblError.Visible = false;
                    myData.RegisterAdmin(txtAdminEmail.Text, txtAdminName.Text, txtAdminPhone.Text, txtAdminPassword.Text);
                    Response.Redirect("registrationComplete.aspx");
                }
            }
        }
    }
}