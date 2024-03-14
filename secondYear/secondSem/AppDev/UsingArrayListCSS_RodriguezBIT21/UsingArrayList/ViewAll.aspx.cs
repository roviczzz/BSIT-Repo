using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataHelperArrayList;
using System.Data;
using System.Reflection.Emit;


namespace UsingArrayList
{
    public partial class ViewAll : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
       
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DataAccess.SignedIn)
            {
                GridView1.Visible = true;
                Label1.Visible = false;


                dt.Columns.Add("User name", typeof(string));
                dt.Columns.Add("Client name", typeof(string));
                dt.Columns.Add("Client password", typeof(string));
                dt.Columns.Add("Client type", typeof(string));
                for (int i = 0; i <= DataAccess.CustomerID.Count-1; i++)
                {
                    
                    dt.Rows.Add(DataAccess.CustomerID[i].ToString(),
                                DataAccess.CustomerName[i].ToString(),
                                DataAccess.CustomerPassword[i].ToString(),
                                DataAccess.CustomerType[i].ToString());

                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                Label1.Visible = true;
            }
        }
    }
}