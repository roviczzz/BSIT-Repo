using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class adminIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = Session["AdminName"] as String;
        }

        DataAccess.DataAccess myData = new DataAccess.DataAccess();

        protected void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                myData.SaveNewProduct(txtProdID.Text,txtProdName.Text, drpProdType.SelectedValue, int.Parse(txtProdPrice.Text), int.Parse(txtProdStock.Text));
                lblSuccess.Visible = true;
            }
        }

        protected void btnViewProd_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminViewProd.aspx");

        }

        protected void btnViewMemberRecord_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminViewMemRecord.aspx");

        }

        protected void btnTransactions_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminViewTransaction.aspx");

        }

        protected void txtProdID_TextChanged(object sender, EventArgs e)
        {
        }

        protected void txtProdName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtProdPrice_TextChanged(object sender, EventArgs e)
        {
        }
    }
}