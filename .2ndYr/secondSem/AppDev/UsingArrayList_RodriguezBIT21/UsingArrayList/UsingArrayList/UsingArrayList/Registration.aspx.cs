using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataHelperArrayList;

namespace UsingArrayList
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DataAccess myData = new DataAccess();
        protected void btnSave_Click(object sender, EventArgs e)
        {
            myData.SaveRecord(txtEmailAdd.Text, txtFname.Text + " " + txtLName.Text, DropDownList1.SelectedValue, TextBox5.Text);
            Response.Redirect("~/Default.aspx");
        }
    }
}