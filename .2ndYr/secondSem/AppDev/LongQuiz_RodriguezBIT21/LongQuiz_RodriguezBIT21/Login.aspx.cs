using DataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LongQuiz_RodriguezBIT21
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        DataAccess myData = new DataAccess();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (myData.CheckType(txtUserName.Text)) {
               if (myData.CheckUser(txtUserName.Text, myData.EncryptData(txtUserPassword.Text)))
               {
                    Session["UserName"] = myData.UserName;
                    Session["Lastname"] = myData.Lastname;
                    Session["Firstname"] = myData.Firstname;
                    Session["MiddleInitial"] = myData.Middleinitial;
                    Session["PhoneNumber"] = myData.Phonenumber;
                    Session["UserAddress"] = myData.Useraddress;
                    Session["Birthday"] = myData.Birthday;
                    Session["Gender"] = myData.Gender;
                    Session["Password"] = myData.UserPassword;
                    lblIncorrect0.Visible = false;

                    if (myData.Usertype == "User")
                     {
                        FormsAuthentication.RedirectFromLoginPage(Session["UserName"].ToString(), false);
                        Response.Redirect("~/Default.aspx");
                     }

                     if (myData.Usertype == "Admin")
                     {
                        FormsAuthentication.RedirectFromLoginPage(Session["UserName"].ToString(), false);
                        Response.Redirect("~/ViewAll.aspx");
                     }
                    
                }
                else
                {
                    lblIncorrect0.Visible = true;
                }
            }
            else
            {
                Response.Redirect("Registration.aspx");
            }
        }
    }
}