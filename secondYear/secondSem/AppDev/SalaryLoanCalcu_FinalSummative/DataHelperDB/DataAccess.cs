using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelperDB
{
    public class DataAccess
    {
        //Connection String
        static string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rovic\OneDrive\Documents\GitHub\BSIT-Repo\secondYear\secondSem\AppDev\SalaryLoanCalcu_FinalSummative\SalaryLoanCalcu_FinalSummative_Rodriguez\App_Data\MasterFile.mdf;Integrated Security=True";
        //Connection Object
        SqlConnection myConn = new SqlConnection(ConnStr);

        string accountStatus, email, firstname, lastname, password;
        int monthlySalary;
        bool accType;

        public string AccountStatus { get => accountStatus; set => accountStatus = value; }
        public string Email { get => email; set => email = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Password { get => password; set => password = value; }
        public int MonthlySalary { get => monthlySalary; set => monthlySalary = value; }
        public bool AccType { get => accType; set => accType = value; }

        public void RegisterAdmin(string email, string firstname, string lastname, string password)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("RegisterAdmin", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountStatus", SqlDbType.NVarChar).Value = "Admin";
            saveCmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            saveCmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstname;
            saveCmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastname;
            saveCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;


            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public void RegisterUser(string email, string firstname, string lastname, double monthlysalary, string password)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("RegisterUser", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountStatus", SqlDbType.NVarChar).Value = "User";
            saveCmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            saveCmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstname;
            saveCmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastname;
            saveCmd.Parameters.Add("@MonthlySalary", SqlDbType.NVarChar).Value = monthlysalary;
            saveCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;


            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        public bool CheckAccount(string email)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("CheckAccount", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;


            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                AccountStatus = dr.GetString(4);

                if (AccountStatus == "User")
                {
                    Email = dr.GetString(0);
                    Firstname = dr.GetString(1);
                    Lastname = dr.GetString(2);
                    Password = dr.GetString(3);
                    MonthlySalary = dr.GetInt32(5);
                    AccType = true;
                }
                else
                {
                    Email = dr.GetString(0);
                    Firstname = dr.GetString(1);
                    Lastname = dr.GetString(2);
                    Password = dr.GetString(3);
                    AccType = false;
                }

                found = true; //account found
                break;
            }
            myConn.Close();
            return found; //account not found

        }

    }
}
