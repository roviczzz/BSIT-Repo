using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataHelper;

namespace Alonzo___Final_Exam
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            myData.GetStatus(Convert.ToString(Session["Email"]));
            if (Convert.ToString(Session["NumberOfMonths"]) != "")
            {
                Panel1.Visible = true;  

            }
            if(myData.Approval == "Pending" || myData.Approval == "Approved")
            {
                Panel1.Visible = false;
            }
           
           lblStatus.Text = myData.Approval;
           lblNumberOfMonths.Text = Convert.ToString(Session["NumberOfMonths"]);
           lblLoanAmount.Text = Convert.ToString(Session["LoanAmount"]);
           lblInterest.Text = Convert.ToString(Session["Interest"]);
           lblTakeHome.Text = Convert.ToString(Session["TakeHome"]);
           lblServiceCharge.Text = Convert.ToString(Session["ServiceCharge"]);
           lblMonthly.Text = Convert.ToString(Session["MonthlyAmortization"]);
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            myData.BasicMonthly1 = Convert.ToDouble(Session["BasicMonthly"]);
            myData.LoanAmount1 = Convert.ToDouble(Session["LoanAmount"]);
            myData.Interest1 = Convert.ToDouble(Session["Interest"]);
            myData.TakeHome1 = Convert.ToDouble(Session["TakeHome"]);
            myData.ServiceCharge1 = Convert.ToDouble(Session["ServiceCharge"]);
            myData.MonthlyAmortization1 = Convert.ToDouble(Session["MonthlyAmortization"]);
            myData.ApplyLoan(Convert.ToString(Session["Email"]));
            Response.Redirect("ProcessApplication.aspx");
           
        }
    }
}