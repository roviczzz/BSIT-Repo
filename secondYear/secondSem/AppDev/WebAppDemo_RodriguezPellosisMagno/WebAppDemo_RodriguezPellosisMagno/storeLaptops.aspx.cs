using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class storeLaptops : System.Web.UI.Page
    {
        DataAccess.DataAccess myData = new DataAccess.DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayRecords();
            }
        }
        public void DisplayRecords()
        {
            GridView1.DataSource = myData.DisplayLaptops();
            GridView1.DataBind();
            GridView1.HeaderRow.Cells[0].Text = "Action";
            GridView1.HeaderRow.Cells[1].Text = "Product Name";
            GridView1.HeaderRow.Cells[2].Text = "Price";
            GridView1.HeaderRow.Cells[3].Text = "Product Type";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int rowIndex = GridView1.SelectedIndex;
            if (rowIndex >= 0)
            {
                string productName = GridView1.DataKeys[rowIndex]["ProductName"] as string;
                myData.AddToCart(productName, Session["UserEmail"].ToString(), 1);
            }
        }
    }
}