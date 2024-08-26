using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebAppDemo_RodriguezPellosisMagno
{
    public partial class userCart : System.Web.UI.Page
    {
        DataAccess.DataAccess myData = new DataAccess.DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayRecords();
                CalculateTotalPrice();
                CalculateQuantity();
                myData.ComputeTotal(TotalPrice, TotalQuantity, Session["MemType"].ToString());
                lblTotalAmount.Text = myData.TotalAmount.ToString();
                lblVAT.Text = myData.Vat.ToString();
                lblFinalPrice.Text = myData.FinalAmount.ToString();
                Session["FinalAmount"] = myData.FinalAmount.ToString();
            }
        }
        private double totalPrice = 0;
        private double totalQuantity = 0;
        public double TotalQuantity { get => totalQuantity; set => totalQuantity = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public void DisplayRecords()
        {
            try
            {
                if (Session["UserEmail"] != null)
                {
                    GridView1.DataSource = myData.DisplayUserCart(Session["UserEmail"].ToString());
                    GridView1.DataBind();
                    GridView1.HeaderRow.Cells[0].Text = "Price";
                    GridView1.HeaderRow.Cells[1].Text = "Product Name";
                    GridView1.HeaderRow.Cells[2].Text = "Quantity";
                }
                else
                {
                    btnCheckout.Enabled = false;
                    lblError.Enabled = true;
                }
            }
            catch (Exception ex)
            {
            }
        }


        private double CalculateTotalPrice()
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                double price = 0;
                if (double.TryParse(row.Cells[0].Text, out price))
                {
                    TotalPrice += price;
                }
            }
            return TotalPrice;
        }

        private double CalculateQuantity()
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                double quantity = 0;
                if (double.TryParse(row.Cells[2].Text, out quantity))
                {
                    TotalQuantity += quantity;
                }
            }
            return TotalQuantity;
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {

        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        protected void btnCheckout_Click1(object sender, EventArgs e)
        {
            myData.SaveTransaction(Session["UserEmail"].ToString(), Convert.ToDouble(Session["FinalAmount"]));
            Response.Redirect("userCheckoutComplete.aspx");
        }
    }
}