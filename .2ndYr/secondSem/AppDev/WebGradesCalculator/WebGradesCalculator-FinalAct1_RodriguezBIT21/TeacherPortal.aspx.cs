using DataHelperDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGradesCalculator_FinalAct1_RodriguezBIT21
{
    public partial class TeacherPortal : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayRecords();
            }
        }

        public void DisplayRecords()
        {
            GridView1.DataSource = myData.DisplayMyRecords();
            GridView1.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            myData.IsLogin = false;
            Response.Redirect("Home.aspx");
        }

        protected void btnSel_Click(object sender, EventArgs e)
        {
            if (IsValid && myData.CheckStudentAccount(txtStudentID.Text)){
                pnlGrade.Visible = true;
                txtError.Visible = false;

                lblStudentID.Text = myData.StudentID.ToString();
                lblStudentName.Text = myData.StudentName.ToString();
            }
            else
            {
                txtError.Visible = true;
            }
        }

        double prelim, midterm, final, overall;
        public double Prelim { get => prelim; set => prelim = value; }
        public double Midterm { get => midterm; set => midterm = value; }
        public double Final { get => final; set => final = value; }

        protected void btnSubmit0_Click(object sender, EventArgs e)
        {
            pnlGrade.Visible = false;
        }

        public double Overall { get => overall; set => overall = value; }


        protected void txtOverall_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCompute0_Click(object sender, EventArgs e)
        {
            Prelim = double.Parse(txtPrelim.Text);
            Midterm = double.Parse(txtMidterm.Text);
            Final = double.Parse(txtFinals.Text);

            myData.SaveGrade(txtStudentID.Text, Prelim, Midterm, Final);

            txtOverall.Text = Convert.ToString(myData.OverallFinalGrade);
            txtError.Visible = false;
            





        }

    }
}