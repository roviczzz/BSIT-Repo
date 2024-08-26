using DataHelperDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGradesCalculator_FinalAct1_RodriguezBIT21
{
    public partial class LoginStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataAccess myData = new DataAccess();
        protected void btnReg_Click(object sender, EventArgs e)
        {
            if (IsValid && myData.CheckStudentLogin(txtStudentID.Text, txtPass.Text))
            {
                myData.IsLogin = true;

                Session["StudentID"] = myData.StudentID;
                Session["StudentName"] = myData.StudentName;
                Session["Prelims"] = myData.PrelimGrade;
                Session["Midterm"] = myData.MidtermGrade;
                Session["Final"] = myData.FinalGrade;
                Session["Overall"] = myData.OverallFinalGrade;

                Response.Redirect("StudentPortal.aspx");
            }
            else
            {
                txtError.Visible = true;
                return;
            }
        }
    }
}