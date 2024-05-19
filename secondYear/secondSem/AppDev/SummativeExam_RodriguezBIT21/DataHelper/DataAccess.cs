using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public class DataAccess
    {
        static string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rovic\OneDrive\Documents\GitHub\2nd-Year-Programming\Alonzo - Final Exam\Alonzo - Final Exam\SummativeExam_RodriguezBIT21\App_Data\Masterfile.mdf"";Integrated Security=True";
        SqlConnection myConn = new SqlConnection(ConnStr);

        public void SaveRecord(string Email, string FirstName, string LastName, double BasicMonthly, string Password)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveRecord", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Email;
            saveCmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            saveCmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            saveCmd.Parameters.Add("@BasicMonthly", SqlDbType.Float).Value = BasicMonthly;
            saveCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
         
            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }
        string usertype;
        string email;
        public bool CheckUser(string Username, string Password)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("CheckUser", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username;
            readCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                BasicMonthly1 = dr.GetDouble(0);
                Usertype = dr.GetString(1);
                Email = dr.GetString(2);
                found = true;
                break;
            }
            myConn.Close();

            return found;
        }

        string approval;
       
        public bool GetStatus(string Username)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("GetStatus", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                Approval = dr.GetString(0);
                found = true;
                break;
            }
            myConn.Close();

            return found;
        }

        string username;
        public bool UserExists(string username)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("UserExists", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                Username = dr.GetString(0);
                found = true;
                break;
            }
            myConn.Close();

            return found;
        }

        double LoanAmount, Interest, ServiceCharge, TakeHome, MonthlyAmortization;
        double BasicMonthly;
        public double LoanAmount1 { get => LoanAmount; set => LoanAmount = value; }
        public double Interest1 { get => Interest; set => Interest = value; }
        public double ServiceCharge1 { get => ServiceCharge; set => ServiceCharge = value; }
        public double TakeHome1 { get => TakeHome; set => TakeHome = value; }
        public double MonthlyAmortization1 { get => MonthlyAmortization; set => MonthlyAmortization = value; }
        public string Username { get => username; set => username = value; }
        public string Usertype { get => usertype; set => usertype = value; }
        public double BasicMonthly1 { get => BasicMonthly; set => BasicMonthly = value; }
        public string Approval { get => approval; set => approval = value; }
        public string Email { get => email; set => email = value; }

        public void CalculateLoan(int Months, double loanAmount)
        {
            double rate = 0;
            if (Months >= 1 && Months <= 5)
            {
                rate = 0.0062;
            }
            else if (Months >= 6 && Months <= 10)
            {
                rate = 0.0065;
            }
            else if (Months >= 11 && Months <= 15)
            {
                rate = 0.0068;
            }
            else if (Months >= 16 && Months <= 20)
            {
                rate = 0.0075;
            }
            else if (Months >= 21 && Months <= 25)
            {
                rate = 0.0080;
            }

            LoanAmount1 = loanAmount;
            Interest1 = LoanAmount1 * Months * rate;

            ServiceCharge1 = LoanAmount1 * 0.02;
            TakeHome1 = LoanAmount1 - (Interest1 + ServiceCharge1);
            MonthlyAmortization1 = LoanAmount1 / Months;
        }

        public double LoanableAmount(double amount)
        {
            return amount * 2.5;
        }

        public void SetApproval(string username, string approval)
        {
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("SetApproval", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
            readCmd.Parameters.Add("@Approval", SqlDbType.NVarChar).Value = approval;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                break;
            }
            myConn.Close();
        }

        public void ApplyLoan(string Username)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("ApplyLoan", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username;
            saveCmd.Parameters.Add("@LoanAmount", SqlDbType.NVarChar).Value = LoanAmount1;
            saveCmd.Parameters.Add("@Interest", SqlDbType.NVarChar).Value = Interest1;
            saveCmd.Parameters.Add("@ServiceCharge", SqlDbType.NVarChar).Value = ServiceCharge1;
            saveCmd.Parameters.Add("@TakeHome", SqlDbType.NVarChar).Value = TakeHome1;
            saveCmd.Parameters.Add("@MonthlyAmortization", SqlDbType.NVarChar).Value = MonthlyAmortization1;

            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }
        public DataSet ViewApproved()
        {
            SqlDataAdapter da = new SqlDataAdapter("ViewApproved", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "ViewPending");
            return ds;
        }

        public DataSet GrantLoans()
        {
            SqlDataAdapter da = new SqlDataAdapter("GrantLoans", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "ViewPending");
            return ds;
        }
    }
}
