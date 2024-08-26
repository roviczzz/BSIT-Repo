using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DataHelper;

namespace Alonzo___Final_Exam
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = myData.GrantLoans();
                GridView1.DataBind();
            }
        }
        DataAccess myData = new DataAccess();
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    RadioButtonList radioButtonList = (RadioButtonList)row.FindControl("RadioButtonList1");
                    if (radioButtonList.SelectedItem != null)
                    {
                        string secondColumnData = row.Cells[1].Text;
                        string selectedValue = radioButtonList.SelectedValue;
                        myData.SetApproval(secondColumnData, selectedValue);
                        GridView1.DataSource = myData.GrantLoans();
                        GridView1.DataBind();
                        Response.Redirect("ViewPending.aspx");
                    }
                    else
                    {
                        // Both options are not selected, continue to the next row
                        continue;   
                    }
                }
            }
        }

 
    }
}