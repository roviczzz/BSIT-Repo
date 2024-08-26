using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataHelper;

namespace LongQuiz_RodriguezBIT21
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblEmail.Text = Session["UserName"] as String;
            lblLastName.Text = Session["Lastname"] as String;
            lblFirstName.Text = Session["Firstname"] as String;
            lblMiddleInitial.Text = Session["MiddleInitial"] as String;
            lblPhoneNumber.Text = Session["PhoneNumber"] as String;
            lblAddress.Text = Session["UserAddress"] as String;
            DateTime Birthday = Convert.ToDateTime(Session["Birthday"]);
            lblBirthday.Text = Birthday.ToString("yyyy-MM-dd");
            lblGender.Text = Session["Gender"] as String;
            lblPassword.Text = Session["Password"] as String;
        }

        protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("~/Log-In.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string address = string.IsNullOrEmpty(txtAddress.Text) ? Session["UserAddress"] as string : txtAddress.Text;
            string password = string.IsNullOrEmpty(txtPassword.Text) ? Session["Password"] as string : myData.EncryptData(txtPassword.Text);
            string phonenumber = string.IsNullOrEmpty(txtPhoneNumber.Text) ? Session["PhoneNumber"] as string : txtPhoneNumber.Text;

            Session["UserAddress"] = address;
            Session["Password"] = password;
            Session["PhoneNumber"] = phonenumber;


            myData.ChangeDetails(Convert.ToString(Session["UserName"]), password, address, phonenumber);
            Response.Redirect("Default.aspx");
        }
    }
}