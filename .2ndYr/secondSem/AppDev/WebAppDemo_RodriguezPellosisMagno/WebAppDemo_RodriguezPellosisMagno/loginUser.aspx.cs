using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class loginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUserEmail.Text = Session["Email"].ToString();
            }
        }

        DataAccess.DataAccess myData = new DataAccess.DataAccess();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid && myData.UserLogin(txtUserEmail.Text, txtUserPass.Text))
            {
                lblError.Visible = false;
                Session["UserEmail"] = myData.UserEmail;
                Session["UserName"] = myData.UserName;
                Session["UserPhone"] = myData.UserPhone;
                Session["UserPass"] = myData.UserPass;
                Session["AccountStatus"] = myData.AccountStatus;
                Session["MemType"] = myData.MemType;
                Response.Redirect("userIndex.aspx");
            }
            else
            {
                lblError.Visible = true;
                return;
            }
        }
    }
}