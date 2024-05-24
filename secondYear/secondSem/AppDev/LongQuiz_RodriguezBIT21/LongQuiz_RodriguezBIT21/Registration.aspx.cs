using DataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LongQuiz_RodriguezBIT21
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DataAccess myData = new DataAccess();

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (myData.CheckType(txtUserName.Text))
            {
                lblSuccess.Visible = false;
                lblUserError.Visible = true;
                Panel2.Visible = false;
                btnRegister.Visible = false;
                return;
            }
            lblUserError.Visible = false;
            Panel2.Visible = true;
            btnRegister.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblSuccess.Visible = true;
            myData.SaveNewAccount(txtUserName.Text, txtPassword.Text, txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text
            , txtPhoneNumber.Text, txtAddress.Text, DateTime.Parse(txtBirthday.Text), txtGender.Text, radioUserType.SelectedItem.Text);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtMiddleInitial.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtBirthday.Text = String.Empty;
            txtGender.Text = String.Empty;
            radioUserType.SelectedIndex = -1;
            lblSuccess.Visible = false;
            Panel2.Visible = false;
            btnRegister.Visible = false;
            lblUserError.Visible = false;
        }

    }
}