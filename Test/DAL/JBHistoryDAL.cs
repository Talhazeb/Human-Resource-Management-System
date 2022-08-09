using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Test;


    class JBHistoryDAL
    {
        Commoncls cls = new Commoncls();

       
        public int InsertJBH(JBHistory JBH)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();
            
            //SqlCommand command = new SqlCommand("InsertData",connection);
            //command.CommandType = CommandType.StoredProcedure;
            SqlCommand command = new SqlCommand("INSERT INTO Job_HSDetails VALUES('" + JBH.JBHID + "','" + JBH.JBEMPID + "','" + JBH.JBJOINGDATE + "','" + JBH.JBRSGDATE + "','" + JBH.JBTITLE + "','" + JBH.COMMENT + "')", connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@jbhid", JBH.JBHID);
                command.Parameters.AddWithValue("@jbempid", JBH.JBEMPID);
                command.Parameters.AddWithValue("@jbjoingdate", JBH.JBJOINGDATE);
                command.Parameters.AddWithValue("@jbrsgdate", JBH.JBRSGDATE);
                command.Parameters.AddWithValue("@jbtitle", JBH.JBTITLE);
                command.Parameters.AddWithValue("@jbcomment", JBH.COMMENT);

                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }


        public int Update(JBHistory JBH)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            String selectStr = "UPDATE Job_HSDetails SET Jh_Joingdate='" + JBH.JBJOINGDATE + "',jh_Resigndate='" + JBH.JBRSGDATE + "',jh_Jobtitle='" + JBH.JBTITLE + "',jh_comment= '" + JBH.COMMENT + "' WHERE (jh_EmpID = '" + JBH.JBHID + "')";
            SqlCommand command = new SqlCommand(selectStr, connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@jbhid", JBH.JBHID);
                command.Parameters.AddWithValue("@jbempid", JBH.JBEMPID);
                command.Parameters.AddWithValue("@jbjoingdate", JBH.JBJOINGDATE);
                command.Parameters.AddWithValue("@jbrsgdate", JBH.JBRSGDATE);
                command.Parameters.AddWithValue("@jbtitle", JBH.JBTITLE);
                command.Parameters.AddWithValue("@comment", JBH.COMMENT);

                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }


        public int Delete(JBHistory JBH)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            String selectStr = "DELETE FROM Job_HSDetails  WHERE (jh_EmpID = '" + JBH.JBEMPID + "')";
            SqlCommand command = new SqlCommand(selectStr, connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@jbheid", JBH.JBEMPID);
               
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }


        public DataSet Find_Jobh(String arg)
        {
            DataSet ds = null;

            try
            {
                SqlConnection connection = new SqlConnection(cls.setConnectionString());
                connection.Open();

                String selectStr = "SELECT Emp_Details.Full_Name,Emp_Details.Emp_Id, Job_HSDetails.Jh_ID,* FROM Job_HSDetails  INNER JOIN Emp_Details  ON Emp_Details.Emp_Id = Job_HSDetails.Jh_EmpID WHERE Job_HSDetails.Jh_EmpID = '" + arg + "'";
               
                SqlDataAdapter da = new SqlDataAdapter(selectStr, connection);
                ds = new DataSet();
                da.Fill(ds, "Job_HSDetails");

            }
            catch (Exception e)
            {
                String Str = e.Message;
            }
            finally
            {

            }

            return ds;
        }

        public DataTable GetData()
        {
            string query = "SELECT Emp_Details.Full_Name, Job_HSDetails.Jh_ID, Job_HSDetails.Jh_Joingdate, Job_HSDetails.jh_Resigndate, Job_HSDetails.jh_Jobtitle FROM  Job_HSDetails INNER JOIN  Emp_Details ON Job_HSDetails.Jh_EmpID = Emp_Details.Emp_Id";
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(cls.setConnectionString()))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable ds = new DataTable())
                    {
                        sda.Fill(ds);
                        return ds;
                    }
                }
            }
        }



    }

