using DataHelperArrayList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingArrayList
{
    public partial class SearchRecord : System.Web.UI.Page
    {
        DataAccess myData = new DataAccess();
        DataTable dt = new DataTable();

        bool signedIn = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DataAccess.SignedIn)
            {
                Search.Visible = true;
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            bool userFound = false;

            for (int i = 0; i <= DataAccess.CustomerID.Count - 1; i++)
            {
                if (string.Equals(DataAccess.CustomerID[i], txtUsername.Text))
                {
                    userFound = true;
                    lblMessage.Text = "User Found!";
                    dt.Columns.Add("User Name", typeof(string));
                    dt.Columns.Add("Client Name", typeof(string));
                    dt.Columns.Add("Client Password", typeof(string));
                    dt.Columns.Add("Client Type", typeof(string));


                    dt.Rows.Add(DataAccess.CustomerID[i].ToString(),
                               DataAccess.CustomerName[i].ToString(),
                               DataAccess.CustomerPassword[i].ToString(),
                               DataAccess.CustomerType[i].ToString());

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    break;
                }
            }
                if (!userFound){
                    lblMessage.Text = "User not Found!";
                    GridView1.DataSource = null;
                    GridView1.DataBind();

                }
            }
        }
    }
