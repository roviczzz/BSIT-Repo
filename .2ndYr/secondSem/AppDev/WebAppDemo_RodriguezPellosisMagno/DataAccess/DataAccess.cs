using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccess
    {
        //Connection String
        static string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rovic\source\repos\WebAppDemo_RodriguezPellosisMagno\WebAppDemo_RodriguezPellosisMagno\App_Data\StoreMasterFile.mdf;Integrated Security=True";
        //Connection Object
        SqlConnection myConn = new SqlConnection(ConnStr);

        public bool isLogin = false;

        public void RegisterAdmin(string adminEmail, string adminName, string adminPhone, string adminPass)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("RegisterAdmin", myConn); //RegisterAdmin procedure
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountStatus", SqlDbType.NVarChar).Value = "Admin";
            saveCmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar).Value = adminEmail;
            saveCmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = adminName;
            saveCmd.Parameters.Add("@UserPhoneNum", SqlDbType.NVarChar).Value = adminPhone;
            saveCmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = adminPass;


            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public void RegisterUser(string userEmail, string userName, string userPhone, string userPass, string memType)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("RegisterUser", myConn); //RegisterUser procedure
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountStatus", SqlDbType.NVarChar).Value = "User";
            saveCmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar).Value = userEmail;
            saveCmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
            saveCmd.Parameters.Add("@UserPhoneNum", SqlDbType.NVarChar).Value = userPhone;
            saveCmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = userPass;
            saveCmd.Parameters.Add("@MemType", SqlDbType.NVarChar).Value = memType;



            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public void AddToCart(string prodName, string email, int quantity)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("AddToCart", myConn); //AddToCart procedure
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = prodName;
            saveCmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            saveCmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;



            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public void SaveNewProduct(string prodID, string prodName, string prodType, int prodPrice, int prodStock)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveNewProduct", myConn); //SaveNewProduct procedure
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@ProductID", SqlDbType.NVarChar).Value = prodID;
            saveCmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = prodName;
            saveCmd.Parameters.Add("@ProductType", SqlDbType.NVarChar).Value = prodType;
            saveCmd.Parameters.Add("@RetailPrice", SqlDbType.NVarChar).Value = prodPrice;
            saveCmd.Parameters.Add("@ProductStock", SqlDbType.NVarChar).Value = prodStock;




            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public void SaveTransaction(string email, double finalAmount)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveTransaction", myConn); //SaveTransaction procedure
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar).Value = email;
            saveCmd.Parameters.Add("@ItemPrice", SqlDbType.Float).Value = finalAmount;
            saveCmd.Parameters.Add("@PurchaseDate", SqlDbType.Date).Value = DateTime.Today;

            saveCmd.ExecuteNonQuery();  
            myConn.Close();
        }

        public void ComputeTotal(double totalAmount, double quantity, string memType)
        {
            double discountPercentage = 0;
            switch (memType)
            {
                case "Silver":
                    discountPercentage = 0.5; // 50% discount
                    break;
                case "Gold":
                    discountPercentage = 0.10; // 10% discount
                    break;
                case "Platinum":
                    discountPercentage = 0.15; // 15% discount
                    break;
            }
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("ComputeTotal", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
            saveCmd.Parameters.AddWithValue("@Discount", discountPercentage);
            saveCmd.Parameters.AddWithValue("@Quantity", quantity);


            SqlDataReader reader = saveCmd.ExecuteReader();
            if (reader.Read())
            {
                TotalAmount = Convert.ToDouble(reader["TotalAmount"]);
                Vat = Convert.ToDouble(reader["VAT"]);
                DiscountAmount = discountAmount;
                FinalAmount = Convert.ToDouble(reader["FinalAmount"]);
            }

            reader.Close();
            myConn.Close();
        }



        public void UpdatePassword(string email, string password)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("UpdatePass", myConn); //UpdatePass procedure
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@userEmail", SqlDbType.NVarChar).Value = email;
            saveCmd.Parameters.Add("@newPassword", SqlDbType.NVarChar).Value = password;




            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public DataSet DisplayUserCart(string email)
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayCart", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@UserEmail", email);
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }

        public DataSet DisplayOrderHistory(string email)
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayOrderHistory", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@UserEmail", email);
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }

        public DataSet DisplayAllProducts()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayAllProducts", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }

        public DataSet DisplayLaptops()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayLaptops", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }
        public DataSet DisplayDesktops()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayDesktops", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }

        public DataSet DisplayStoreProducts()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayStoreProducts", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }

        public DataSet DisplayMembersRecords()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayMembersRecords", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }

        public DataSet DisplayTransactions()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayTransactions", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }


        private double vat, totalAmount, finalAmount, discountAmount;
        private string adminPass;
        private string accountStatus;
        private string userEmail;
        private string userName;
        private int userPhone;
        private string userPass;
        private string memType;
        private string adminEmail;
        private string adminName;
        private int adminPhone;
        bool accType = false; //false admin, true user


        public string AccountStatus { get => accountStatus; set => accountStatus = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserName { get => userName; set => userName = value; }
        public string MemType { get => memType; set => memType = value; }
        public string AdminEmail { get => adminEmail; set => adminEmail = value; }
        public string AdminName { get => adminName; set => adminName = value; }
        public string AdminPass { get => adminPass; set => adminPass = value; }
        public string UserPass { get => userPass; set => userPass = value; }
        public int UserPhone { get => userPhone; set => userPhone = value; }
        public int AdminPhone { get => adminPhone; set => adminPhone = value; }
        public bool AccType { get => accType; set => accType = value; }
        public double Vat { get => vat; set => vat = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public double FinalAmount { get => finalAmount; set => finalAmount = value; }
        public double DiscountAmount { get => discountAmount; set => discountAmount = value; }

        public bool CheckAccount(string email)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("CheckAccount", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar).Value = email;


            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                AccountStatus = dr.GetString(4);

                if (AccountStatus == "User")
                {
                    UserEmail = dr.GetString(0);
                    UserName = dr.GetString(1);
                    UserPhone = dr.GetInt32(2);
                    UserPass = dr.GetString(3);
                    MemType = dr.GetString(5);
                    AccType = true;
                }
                else
                {
                    adminEmail = dr.GetString(0);
                    adminName = dr.GetString(1);
                    AdminPhone = dr.GetInt32(2);
                    adminPass = dr.GetString(3);
                    AccType = false;
                }

                found = true; //account found
                break;
            }
            myConn.Close();
            return found; //account not found

        }

        public bool AdminLogin(string adminEmail, string adminPass)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("AdminLogin", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar).Value = adminEmail;
            readCmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = adminPass;


            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                AdminEmail = dr.GetString(0);
                AdminName = dr.GetString(1);
                AdminPhone = dr.GetInt32(2);
                AdminPass = dr.GetString(3);
                AccountStatus = dr.GetString(4);
                if(AccountStatus == "User")
                {
                    break;
                }

                found = true;
                break;
            }
            myConn.Close();
            return found;

        }

        public bool UserLogin(string userEmail, string userPass)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("UserLogin", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar).Value = userEmail;
            readCmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = userPass;


            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                UserEmail = dr.GetString(0);
                UserName = dr.GetString(1);
                UserPhone = dr.GetInt32(2);
                UserPass = dr.GetString(3);
                MemType = dr.GetString(5); //memtype
                AccountStatus = dr.GetString(4);
                if (AccountStatus == "Admin")
                {
                    break;
                }


                found = true;
                break;
            }
            myConn.Close();
            return found;

        }



    }


}
