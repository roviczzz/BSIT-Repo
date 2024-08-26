using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataHelper;

namespace Alonzo___Final_Exam
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoanable.Text = Convert.ToString(myData.LoanableAmount(Convert.ToDouble(Session["BasicMonthly"])));
            rangeLoanable.MaximumValue = lblLoanable.Text;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txtLoanAmount.Text) > Convert.ToDouble(lblLoanable.Text))
            {
                return;
            }

            myData.BasicMonthly1 = Convert.ToDouble(Session["BasicMonthly"]);
            myData.CalculateLoan(Convert.ToInt32(txtNumberOfMonths.Text), Convert.ToDouble(txtLoanAmount.Text));
            lblLoanAmount.Text = Convert.ToString(myData.LoanAmount1);
            lblInterest.Text = Convert.ToString(myData.Interest1);
            lblTakeHome.Text = Convert.ToString(myData.TakeHome1);
            lblServiceCharge.Text = Convert.ToString(myData.ServiceCharge1);
            lblMonthly.Text = Convert.ToString(myData.MonthlyAmortization1);

            Session["NumberOfMonths"] = txtNumberOfMonths.Text;
            Session["LoanAmount"] = myData.LoanAmount1;
            Session["Interest"] = myData.Interest1;
            Session["TakeHome"] = myData.TakeHome1;
            Session["ServiceCharge"] = myData.ServiceCharge1;
            Session["MonthlyAmortization"] = myData.MonthlyAmortization1;

         }

    }
}