using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelperDB
{
    public class DataAccess
    {

        //Connection String
        static string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rovic\source\repos\WebGradesCalculator-FinalAct1_RodriguezBIT21\WebGradesCalculator-FinalAct1_RodriguezBIT21\App_Data\SchoolData.mdf;Integrated Security=True";
        //Connection Object
        SqlConnection myConn = new SqlConnection(ConnStr);

        public bool isLogin = false;

        public void SaveNewTeacherRecord(string teacherID, string teacherName, string teacherPass)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveNewTeacherRecord", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@TeacherID", SqlDbType.NVarChar).Value = teacherID;
            saveCmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = teacherName;
            saveCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = teacherPass;

            saveCmd.ExecuteNonQuery();
            myConn.Close();


        }

        public void SaveNewStudentRecord(string studentID, string studentName, string studentPass)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveNewStudentRecord", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@StudentID", SqlDbType.NVarChar).Value = studentID;
            saveCmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = studentName;
            saveCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = studentPass;
            saveCmd.Parameters.Add("@PrelimGrade", SqlDbType.Float).Value = 0;
            saveCmd.Parameters.Add("@MidtermGrade", SqlDbType.Float).Value = 0;
            saveCmd.Parameters.Add("@FinalGrade", SqlDbType.Float).Value = 0;
            saveCmd.Parameters.Add("@OverallFinalGrade", SqlDbType.Float).Value = 0;


            saveCmd.ExecuteNonQuery();
            myConn.Close();


        }
        public void SaveGrade(string studentID, double prelimGrade, double midtermGrade, double finalGrade)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveGrade", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@StudentID", SqlDbType.NVarChar).Value = studentID;
            saveCmd.Parameters.Add("@PrelimGrade", SqlDbType.Float).Value = prelimGrade;
            saveCmd.Parameters.Add("@MidtermGrade", SqlDbType.Float).Value = midtermGrade;
            saveCmd.Parameters.Add("@FinalGrade", SqlDbType.Float).Value = finalGrade;

            SqlDataReader dr;
            dr = saveCmd.ExecuteReader();
            while (dr.Read())
            {
                OverallFinalGrade = dr.GetDouble(0);
                break;
            }
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

        string studentID, studentPass, studentName;
        double prelimGrade, midtermGrade, finalGrade, overallFinalGrade;
        public string TeacherID { get => teacherID; set => teacherID = value; }
        public string TeacherPass { get => teacherPass; set => teacherPass = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentPass { get => studentPass; set => studentPass = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public bool IsLogin { get => isLogin; set => isLogin = value; }
        public double PrelimGrade { get => prelimGrade; set => prelimGrade = value; }
        public double MidtermGrade { get => midtermGrade; set => midtermGrade = value; }
        public double FinalGrade { get => finalGrade; set => finalGrade = value; }
        public double OverallFinalGrade { get => overallFinalGrade; set => overallFinalGrade = value; }

        public bool CheckStudentAccount(string studentID)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("CheckStudentAccount", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@StudentID", SqlDbType.NVarChar).Value = studentID;


            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                StudentID = dr.GetString(0);
                StudentName = dr.GetString(1);
                PrelimGrade = dr.GetDouble(2);
                MidtermGrade = dr.GetDouble(3);
                FinalGrade = dr.GetDouble(4);
                OverallFinalGrade = dr.GetDouble(5);


                found = true;
                break;
            }
            myConn.Close();
            return found;

        }

        public bool CheckStudentLogin(string studentID, string studentPass)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("CheckStudentLogin", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@StudentID", SqlDbType.NVarChar).Value = studentID;
            readCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = studentPass;



            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                StudentID = dr.GetString(0);
                StudentName = dr.GetString(1);
                StudentPass = dr.GetString(2);
                PrelimGrade = dr.GetDouble(3);
                MidtermGrade = dr.GetDouble(4);
                FinalGrade = dr.GetDouble(5);
                OverallFinalGrade = dr.GetDouble(6);

                found = true;
                break;
            }
            myConn.Close();
            return found;

        }

        string teacherID, teacherPass;
        public bool CheckTeacherAccount(string TeacherID)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("CheckTeacherAccount", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@TeacherID", SqlDbType.NVarChar).Value = TeacherID;


            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                TeacherID = dr.GetString(0);
                found = true;
                break;
            }
            myConn.Close();
            return found;

        }

        public bool CheckTeacherLogin(string TeacherID, string TeacherPass)
        {
            myConn.Open();
            bool found = false;
            SqlCommand readCmd = new SqlCommand("CheckTeacherLogin", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@TeacherID", SqlDbType.NVarChar).Value = TeacherID;
            readCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = TeacherPass;



            SqlDataReader dr;
            dr = readCmd.ExecuteReader();
            while (dr.Read())
            {
                TeacherID = dr.GetString(0);
                TeacherPass = dr.GetString(1);
                found = true;
                break;
            }
            myConn.Close();
            return found;

        }


    }
}
