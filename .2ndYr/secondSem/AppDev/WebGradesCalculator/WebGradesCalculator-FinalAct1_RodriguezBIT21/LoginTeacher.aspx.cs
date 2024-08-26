using DataHelperDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebGradesCalculator_FinalAct1_RodriguezBIT21
{
    public partial class LoginTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataAccess myData = new DataAccess();
        protected void btnReg_Click(object sender, EventArgs e)
        {
            if (IsValid && myData.CheckTeacherLogin(txtTeacherID.Text, txtPass.Text))
            {
                myData.IsLogin = true;
                Response.Redirect("TeacherPortal.aspx");
            }
            else
            {
                txtError.Visible = true;
                return;
            }
        }
    }
}