using DataHelperDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGradesCalculator_FinalAct1_RodriguezBIT21
{
    public partial class Teacher_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataAccess myData = new DataAccess();
        protected void btnReg_Click(object sender, EventArgs e)
        {
            if (myData.CheckTeacherAccount(txtTeacherID.Text))
            {
                txtError.Visible = true;
                return;
            }
            else
            {
                if (IsValid)
                {
                    txtError.Visible = false;
                    myData.SaveNewTeacherRecord(txtTeacherID.Text, txtName.Text, txtPass.Text);
                    Response.Redirect("RegComplete.aspx");
                }
            }
        }
    }
}