using DataHelperArrayList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingArrayList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataAccess myData = new DataAccess();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!DataAccess.CustomerID.Contains(txtUsername.Text))
            {
                lblEmail.Visible = true;
                return;
            }
            else if (!Equals(DataAccess.CustomerPassword[DataAccess.CustomerID.IndexOf(txtUsername.Text)], txtPassword.Text))
            {
                lblPassword.Visible = true;
                return;
            }
            Session["Name"] = DataAccess.CustomerName[DataAccess.CustomerID.IndexOf(txtUsername.Text)];
            myData.userSignedIn();
            Response.Redirect("~/Default.aspx");
        }
    }
}