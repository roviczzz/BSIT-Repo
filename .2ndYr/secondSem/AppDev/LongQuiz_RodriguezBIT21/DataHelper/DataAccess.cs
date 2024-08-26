using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public class DataAccess
    {
        static string myConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rovic\OneDrive\Documents\GitHub\BSIT-Repo\secondYear\secondSem\AppDev\LongQuiz_RodriguezBIT21\LongQuiz_RodriguezBIT21\App_Data\MasterFile.mdf;Integrated Security=True";
        SqlConnection myConn = new SqlConnection(myConStr);

        public string EncryptData(string userPassWord)
        {
            MD5CryptoServiceProvider mdHash = new MD5CryptoServiceProvider();
            byte[] totalBytes = Encoding.ASCII.GetBytes(userPassWord);
            byte[] hashBytes = mdHash.ComputeHash(totalBytes);

            StringBuilder sb = new StringBuilder();
            for (int generateChar = 0; generateChar < hashBytes.Length; generateChar++)
            {
                sb.AppendFormat("{0:x2}", hashBytes[generateChar]);

            }
            return sb.ToString();
        }
        string encryptedUserPassword;


        public bool VerifyPassword(string userPassword, string passwordHash)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] userInputHash = md5.ComputeHash(Encoding.ASCII.GetBytes(userPassword));

                StringBuilder userInputHashString = new StringBuilder();
                for (int i = 0; i < userInputHash.Length; i++)
                {
                    userInputHashString.Append(userInputHash[i].ToString("x2"));
                }

                return string.Equals(userInputHashString.ToString(), passwordHash, StringComparison.OrdinalIgnoreCase);
            }
        }


        public string EncryptedUserPassword
        {
            get { return encryptedUserPassword; }
            set { encryptedUserPassword = value; }
        }
        DateTime birthday;
        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Middleinitial { get => middleinitial; set => middleinitial = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Useraddress { get => useraddress; set => useraddress = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Usertype { get => usertype; set => usertype = value; }

        public void SaveNewAccount(string userName, string userPassword, string lastName, string firstName,
            string middleInitial, string phoneNumber, string userAddress, DateTime birthDay, string gender, string userType)
        {
            myConn.Open();
            encryptedUserPassword = EncryptData(userPassword);
            SqlCommand saveCmd = new SqlCommand("SaveNewAccount", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;
            saveCmd.Parameters.Add("@userPassword", SqlDbType.NVarChar).Value = encryptedUserPassword;
            saveCmd.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = lastName;
            saveCmd.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = firstName;
            saveCmd.Parameters.Add("@middleInitial", SqlDbType.NVarChar).Value = middleInitial;
            saveCmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = phoneNumber;
            saveCmd.Parameters.Add("@userAddress", SqlDbType.NVarChar).Value = userAddress;
            saveCmd.Parameters.Add("@birthDay", SqlDbType.Date).Value = birthDay;
            saveCmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            saveCmd.Parameters.Add("@userType", SqlDbType.NVarChar).Value = userType;

            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        string userName, userPassword, firstname, lastname, middleinitial, phonenumber, useraddress, gender;



        public bool CheckUser(string username, string password)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("CheckUser", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = username;
            readCmd.Parameters.Add("@userPassWord", SqlDbType.NVarChar).Value = password;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {



                UserName = dr.GetString(0);
                Lastname = dr.GetString(1);
                Firstname = dr.GetString(2);
                Middleinitial = dr.GetString(3);
                Phonenumber = dr.GetString(4);
                useraddress = dr.GetString(5);
                birthday = dr.GetDateTime(6);
                gender = dr.GetString(7);
                UserPassword = dr.GetString(8);

                found = true;
                break;
            }

            myConn.Close();
            return found;
        }


        string usertype;
        public bool CheckType(string username)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("CheckType", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = username;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                Usertype = dr.GetString(0);
                found = true;
                break;
            }
            myConn.Close();

            return found;
        }

        public void ChangeDetails(string username, string password, string address, string phonenumber)
        {
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("changeDetails", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
            readCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
            readCmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;
            readCmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = phonenumber;

            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                break;
            }
            myConn.Close();
        }

        public DataSet ViewAll()
        {
            SqlDataAdapter da = new SqlDataAdapter("ViewAll", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }
    }
}
