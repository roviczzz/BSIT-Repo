using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataHelper;

namespace FinalAct1_RodriguezBIT21
{
    public partial class Registration : System.Web.UI.Page
    {
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

        DataAccess myData = new DataAccess();
        protected void btnSave_Click(object sender, EventArgs e)
        {

            //error trap

            if (myData.CheckStudentAccount(txtStudentNo.Text))
            {
                txtError.Visible = true;
                return;
            }
            else
            {
                txtError.Visible = false;
                myData.SaveNewRecord(txtStudentNo.Text, txtName.Text, txtPassword.Text);
                DisplayRecords();
            }
        }
    }
}