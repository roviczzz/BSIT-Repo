using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppDev_EA1
{
    public partial class StudentTuition_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtBox1.Text = StudentTuition.studentID.ToString();
            txtBox2.Text = StudentTuition.studentName.ToString();
            txtBox3.Text = StudentTuition.studentCourse.ToString();
            txtBox4.Text = StudentTuition.tuitionFee.ToString();
            txtBox5.Text = StudentTuition.downpayment.ToString();
            txtBox6.Text = StudentTuition.totalBalance.ToString();
        }

        protected void txtBox_StudentID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentTuition.Clear();
            Response.Redirect("StudentTuition-1.aspx");
        }
    }
}