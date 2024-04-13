using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataHelper
{
    public class DataAccess
    {
        //Conneciton String
        static string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rovic\source\repos\FinalAct1_RodriguezBIT21\FinalAct1_RodriguezBIT21\App_Data\MasterFile.mdf;Integrated Security=True";
        //Connection Object
        SqlConnection myConn = new SqlConnection(ConnStr);

        public void SaveNewRecord(string studentNo, string name, string userPassword)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveNewRecord", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@StudentNo", SqlDbType.NVarChar).Value = studentNo;
            saveCmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
            saveCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = userPassword;
            saveCmd.ExecuteNonQuery();
            myConn.Close();


        }

        public DataSet DisplayMyRecords()
        {
            SqlDataAdapter da = new SqlDataAdapter("DisplayRecords", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "myTable");
            return ds;
        }

        string studentNumber, studentPassword;

        public string StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string StudentPassword { get => studentPassword; set => studentPassword = value; }

        public bool CheckStudentAccount(string StudentNumber)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("CheckAccount", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@StudentNo", SqlDbType.NVarChar).Value = StudentNumber;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                studentNumber = dr.GetString(0);
                found = true;
                break;
            }
            myConn.Close();
            return found;

        }
    }
}
