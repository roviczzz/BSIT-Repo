using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.App_Code
{
    public partial class WebForm1 : System.Web.UI.Page

    {
        static string numToBin(int userInput)
        {
            string result = "";

            while (userInput != 0)
            {
                if ((userInput % 2 == 0))
                {
                    result += "0";
                }
                else
                {
                    result += "1";
                }
                userInput /= 2;
            }
            return result;
        }

        static string reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            invalidBox.Visible = false;
            if (!txtDec.Text.Any(Char.IsLetter))
            {
                string dec = txtDec.Text;
                int decInt = Int32.Parse(dec);

                if (!string.IsNullOrEmpty(txtDec.Text))
                {
                    string bin = numToBin(decInt);
                    txtBin.Enabled = true;
                    string result = reverse(bin);

                    txtBin.Text = result;
                }
                else
                {
                    invalidBox.Visible = true;

                }
                }
            else
            {
                invalidBox.Visible = true;

            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtBin.Text = string.Empty;
            txtDec.Text = string.Empty;
            invalidBox.Visible = false;
            txtBin.Enabled = false;
        }
    }
}