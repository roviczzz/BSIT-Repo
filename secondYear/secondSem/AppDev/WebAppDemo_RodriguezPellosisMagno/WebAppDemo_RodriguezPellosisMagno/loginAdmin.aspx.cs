using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class loginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtAdminEmail.Text = Session["Email"].ToString();
            }
        }

        DataAccess.DataAccess myData = new DataAccess.DataAccess();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid && myData.AdminLogin(txtAdminEmail.Text, txtAdminPass.Text))
            {
                lblError.Visible = false;
                Session["AdminEmail"] = myData.AdminEmail;
                Session["AdminName"] = myData.AdminName;
                Session["AdminPhone"] = myData.AdminPhone;
                Session["AdminPass"] = myData.AdminPass;
                Session["AccountStatus"] = myData.AccountStatus;
                Response.Redirect("adminIndex.aspx");
            }
            else
            {
                lblError.Visible = true;
                return;
            }
        }
    }
}