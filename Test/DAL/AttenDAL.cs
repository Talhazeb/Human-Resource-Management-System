using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Test;

    class AttenDAL
    {
        Commoncls cls = new Commoncls();
        
        public int Insert(Atten_Details att_det)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();
            
            SqlCommand command = new SqlCommand("INSERT INTO Att_Details VALUES(@attid,@Emp_Id,@DateTime,@Status)", connection);
          
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@attid",att_det.ATTID);
                command.Parameters.AddWithValue("@Emp_Id", att_det.EMPID);
                command.Parameters.AddWithValue("@DateTime", att_det.DATETIME);
                command.Parameters.AddWithValue("@Status", att_det.STATUS);
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

        public DataSet Find_att(String arg)
        {
            DataSet ds = null;

            try
            {
                SqlConnection connection = new SqlConnection(cls.setConnectionString());
                connection.Open();

                String selectStr = "SELECT Emp_Details.Full_Name,Emp_Details.Emp_Id,Att_Details.Att_Id, Att_Details.Emp_Id,Att_Details.Date_Time,Att_Details.Status  FROM  Att_Details INNER JOIN  Emp_Details ON Att_Details.Emp_Id = Emp_Details.Emp_Id  WHERE  Emp_Details.Emp_Id = '" + arg + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, connection);
                ds = new DataSet();
                da.Fill(ds, "Att_Details");

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


        public int Update_Att(Atten_Details att)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            String selectStr = "UPDATE Att_Details SET Emp_Id = @emp_Id,Date_Time=@date,Status=@status  WHERE (Att_Id = '" + att.ATTID + "')";
            SqlCommand command = new SqlCommand(selectStr, connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@emp_Id", att.EMPID);
                command.Parameters.AddWithValue("@date", att.DATETIME);
                command.Parameters.AddWithValue("@status", att.STATUS);
              
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
            string query = "SELECT Att_Details.Att_Id,Emp_Details.Full_Name,Att_Details.Date_Time,Att_Details.Status  FROM  Att_Details INNER JOIN  Emp_Details ON Att_Details.Emp_Id = Emp_Details.Emp_Id";
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

        public int Delete_Att(Atten_Details at)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            String selectStr = "DELETE FROM Att_Details  WHERE (Att_Id = @att)";
            SqlCommand command = new SqlCommand(selectStr, connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@att", at.ATTID);
                
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

        public void Find(Atten_Details a_id)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT max(Att_Id) FROM Att_Details", connection);
            command.CommandType = CommandType.Text;
            try
            {
               
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //MessageBox.Show("Employee ID already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // return 
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



    }

