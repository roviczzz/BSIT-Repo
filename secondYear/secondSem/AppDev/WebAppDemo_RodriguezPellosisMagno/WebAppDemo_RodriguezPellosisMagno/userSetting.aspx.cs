using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class userSetting : System.Web.UI.Page
    {
        DataAccess.DataAccess myData = new DataAccess.DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            lblUserName.Text = Session["UserName"].ToString();
            lblEmail.Text = Session["UserEmail"].ToString();
            lblName.Text = Session["UserName"].ToString();
            lblName.Text = Session["UserPass"].ToString();
            lblMembership.Text = Session["MemType"].ToString();
            lblPhoneNo.Text = Session["UserPhone"].ToString();
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            myData.UpdatePassword(lblEmail.Text, txtChangePass.Text);
            lblSuccess.Visible = true;
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("userTransactions.aspx");
        }
    }
}