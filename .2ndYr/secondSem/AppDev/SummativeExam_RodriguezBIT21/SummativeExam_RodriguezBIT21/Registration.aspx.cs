using DataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alonzo___Final_Exam
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (myData.UserExists(txtUsername.Text))
            {
                lblUserError.Visible = true;
                lblSuccess.Visible = false;
                return;
            }

            lblUserError.Visible = false;
            myData.SaveRecord(txtUsername.Text, txtFirstName.Text,
                txtLastName.Text, Convert.ToDouble(txtMonthlySalary.Text), txtPassword.Text);
            lblSuccess.Visible = true;
        }
    }
}