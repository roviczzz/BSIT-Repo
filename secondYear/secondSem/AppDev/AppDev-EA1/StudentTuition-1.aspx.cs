using System;
using System.Collections.Generic;
using System.Configuration;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppDev_EA1
{

    public partial class StudentTuition : System.Web.UI.Page
    {
        public static string studentID;
        public static string studentName;
        public static string studentCourse;
        public static int enrolledUnits;
        public static double tuitionFee;
        public static double downpayment;
        public static double totalBalance;
        public static string paymentMethod;

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckBoxList1.Attributes.Add("onclick", "LimitCheckBoxSelection()");
        }

        public static void Clear()
        {
            studentID = string.Empty;
            studentName = string.Empty;
            studentID = string.Empty;
            studentCourse = string.Empty;
            enrolledUnits = 0;
            paymentMethod = string.Empty;
        }


        static float compTuition(int units)
        {
            float compBIT = 1500.00f;
            float compBCS = 1400.00f;
            float compHUB = 1250.00f;
            float compMEB = 1100.00f;
            float compAPM = 950.00f;

            if (studentCourse == "BIT")
            {
                return compBIT * units;
            }
            else if (studentCourse == "BCS")
            {
                return compBCS * units;
            }
            else if (studentCourse == "HUB")
            {
                return compHUB * units;
            }
            else if (studentCourse == "MEB")
            {
                return compMEB * units;
            }
            else if (studentCourse == "APM")
            {
                return compAPM * units;
            }
            else
            {
                return -1;
            }
        }

        static double compDownpayment(double  tuitionfee, string downpayment)
        {
            if (downpayment == "40%")
            {
                return tuitionFee * 0.40;
            }
            if (downpayment == "50%")
            {
                return tuitionFee * 0.50;
            }
            if (downpayment == "Full-payment")
            {
                return tuitionFee;
            }
            else
            {
                return -1;
            }


        }

        static double compBalance(double tuitionfee, double downpayment)
        {
            return tuitionFee - downpayment;
            
        }


        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int checkedCount = 0;
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    checkedCount++;
                    enrolledUnits = checkedCount;
                }
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            txtBox_StudentID.Text = String.Empty;
            txtBox_Name.Text = String.Empty;
            courseList.SelectedIndex = 0;
            downpaymentList.SelectedIndex = 0;
            CheckBoxList1.ClearSelection();
            errorBox_Course.Visible = false;
            errorBox_Downpay.Visible = false;
            errorBox_ID.Visible = false;
            errorBox_Name.Visible = false;
            errorBox_Units.Visible = false;
            Clear();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!string.IsNullOrEmpty(txtBox_StudentID.Text) && int.TryParse(txtBox_StudentID.Text, out parsedValue))
            {// student id
                errorBox_ID.Visible = false;
                studentID = txtBox_StudentID.Text;
            }
            else
            {
                errorBox_ID.Visible = true;
            }

            if (!string.IsNullOrEmpty(txtBox_Name.Text) && System.Text.RegularExpressions.Regex.IsMatch(txtBox_Name.Text, "^[a-zA-Z .]+$"))
            {// student name
                errorBox_Name.Visible = false;
                studentName = txtBox_Name.Text;
            }
            else
            {
                errorBox_Name.Visible = true;
            }

            if (courseList.SelectedIndex != 0)
            {// course
                errorBox_Course.Visible = false;
                string selectedCourse = courseList.SelectedItem.ToString();
                studentCourse = selectedCourse;

            }
            else
            {
                errorBox_Course.Visible = true;
            }


            if (enrolledUnits <= 24 && enrolledUnits > 0)
            {// enrolled units
                errorBox_Units.Visible = false;
            }
            else
            {
                errorBox_Units.Visible=true;
            }

            if (downpaymentList.SelectedIndex != 0)
            {// downpayment method
                errorBox_Downpay.Visible = false;
                string selectedDownpay = downpaymentList.SelectedItem.ToString();
                paymentMethod = selectedDownpay;
            }
            else
            {
                errorBox_Downpay.Visible=true;
            }

            if (!string.IsNullOrEmpty(studentID) && !string.IsNullOrEmpty(studentName) && !string.IsNullOrEmpty(studentCourse) && enrolledUnits <= 24 && enrolledUnits > 0 && !string.IsNullOrEmpty(paymentMethod))
            {// next page
                tuitionFee = compTuition(enrolledUnits);
                downpayment = compDownpayment(tuitionFee, paymentMethod);
                totalBalance = compBalance(tuitionFee, downpayment);
                Response.Redirect("StudentTuition-2.aspx");


            }
            else
            {// failed
                
            }

        }

        protected void txtBox_StudentID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        protected void downpaymentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}