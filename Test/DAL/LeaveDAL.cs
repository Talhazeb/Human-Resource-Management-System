using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Test;

    class LeaveDAL
    {
        Commoncls cls = new Commoncls();
        Leave leaves = new Leave();

        public int Insert(Leave leave)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Leave_Details VALUES('" + leave.LEAVEID + "','" + leave.EMPID + "','" + leave.APPDATE + "', '" + leave.RESDATE +"','" + leave.TYPE + "')", connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@attid", leave.LEAVEID);
                command.Parameters.AddWithValue("@Emp_Id", leave.EMPID);
                command.Parameters.AddWithValue("@DateTime", leave.APPDATE);
                command.Parameters.AddWithValue("@RsDateTime", leave.RESDATE);
                command.Parameters.AddWithValue("@Status", leave.TYPE);
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

        

        public DataSet Find_Leave(String arg)
        {
            DataSet ds = null;

            try
            {
                SqlConnection connection = new SqlConnection(cls.setConnectionString());
                connection.Open();

                String selectStr = "SELECT Emp_Details.Emp_Id, Leave_Details.Leave_Id, Leave_Details.Emp_Id, Leave_Details.App_Date,Leave_Details.Res_Date, Leave_Details.Type FROM  Leave_Details INNER JOIN  Emp_Details ON Leave_Details.Emp_Id = Emp_Details.Emp_Id  WHERE  Leave_Details.Leave_Id = '" + arg + "'";
                //String selectStr = "SELECT Emp_Details.Full_Name, Job_HSDetails.Jh_ID,* FROM Job_HSDetails  INNER JOIN Emp_Details  ON Emp_Details.Emp_Id = Job_HSDetails.Jh_EmpID WHERE Job_HSDetails.Jh_EmpID = '" + arg + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, connection);
                ds = new DataSet();
                da.Fill(ds, "Leave_Details");

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

        public int Update_Leave(Leave lev)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            String selectStr = "UPDATE Leave_Details SET Emp_Id=@empid,App_Date=@appdate,Res_Date=@resdate,Type=@type WHERE (Leave_Id = @leave)";
            SqlCommand command = new SqlCommand(selectStr, connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@leave",lev.LEAVEID);
                command.Parameters.AddWithValue("@empid", lev.EMPID);
                command.Parameters.AddWithValue("@appdate", lev.APPDATE);
                command.Parameters.AddWithValue("@resdate", lev.RESDATE);
                command.Parameters.AddWithValue("@type", lev.TYPE);
               
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



        public int Delete_Leave(Leave le)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            String selectStr = "DELETE FROM Leave_Details  WHERE (Leave_Id = '" + le.LEAVEID + "')";
            SqlCommand command = new SqlCommand(selectStr, connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@leave", le.LEAVEID);
                //command.Parameters.AddWithValue("@sleave",le.APPDATE);
                //command.Parameters.AddWithValue("@eleave", le.APPDATE);
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


        public DataTable GetData()
        {
            string query = "SELECT  Leave_Details.Leave_Id , Emp_Details.Full_Name , Leave_Details.App_Date,Leave_Details.Res_Date, Leave_Details.Type FROM  Leave_Details INNER JOIN Emp_Details ON Leave_Details.Emp_Id = Emp_Details.Emp_Id";
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


        public DataTable GetData_DateRange(Leave l)
        {
            string query = "SELECT     Leave_Details.Leave_Id, Emp_Details.Full_Name, Leave_Details.App_Date,Leave_Details.Res_Date, Leave_Details.Type FROM   Leave_Details INNER JOIN Emp_Details ON Leave_Details.Emp_Id = Emp_Details.Emp_Id WHERE Leave_Id Like'%" + l.LEAVEID + "%' ";
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

