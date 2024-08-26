using DataHelperDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGradesCalculator_FinalAct1_RodriguezBIT21
{
    public partial class StudentPortal : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {

        

            lblStudentID.Text = Session["StudentID"] as String;
            lblStudentName.Text = Session["StudentName"] as String;
            lblPrelim.Text = Convert.ToString(Session["Prelims"]);
            lblMidterm.Text = Convert.ToString(Session["Midterm"]);
            lblFinals.Text = Convert.ToString(Session["Final"]);
            lblOverall.Text = Convert.ToString(Session["Overall"]);

                if (Convert.ToDouble(lblOverall.Text) >= 60)
                {
                    lblRemark.Text = "Passed";
                }
                else
                {
                    lblRemark.Text = "Failed";
                }

            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            myData.isLogin = false;
            Response.Redirect("Home.aspx");
        }
    }
}