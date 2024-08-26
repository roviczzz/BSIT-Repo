using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DataHelper;

namespace Alonzo___Final_Exam
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = myData.GrantLoans();
                GridView1.DataBind();

                GridView2.DataSource = myData.ViewApproved();
                GridView2.DataBind();
            }
        }
    }
}