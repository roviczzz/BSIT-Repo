using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class adminViewTransaction : System.Web.UI.Page
    {
        DataAccess.DataAccess myData = new DataAccess.DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }
        public void DisplayRecords()
        {
            GridView1.DataSource = myData.DisplayTransactions();
            GridView1.DataBind();
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminIndex.aspx");
        }
    }
}