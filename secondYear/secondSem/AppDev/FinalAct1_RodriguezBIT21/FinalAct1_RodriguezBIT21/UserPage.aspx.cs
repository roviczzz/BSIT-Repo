using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalAct1_RodriguezBIT21
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCustomername.Text = Session["customerName"].ToString();
                lblMemtype.Text = Session["memType"].ToString();
            }
        }
    }
}