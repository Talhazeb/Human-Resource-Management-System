using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
    class UsersDAL
    {
        Commoncls cls = new Commoncls();

        public int Insert(User_Details u_det)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Login VALUES('" + u_det.UID + "','" + u_det.UEID + "', '" + u_det.USERNAME + "' ,'" + u_det.PASSWORD + "')", connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@uid", u_det.UID);
                command.Parameters.AddWithValue("@ueid", u_det.UEID);
                command.Parameters.AddWithValue("@username", u_det.USERNAME);
                command.Parameters.AddWithValue("@password", u_det.PASSWORD);
                
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



        public int Update(User_Details u_det)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();
         
            SqlCommand command = new SqlCommand("UPDATE Login SET Login_id='" + u_det.UID + "', Username='" + u_det.USERNAME + "' ,Password='" + u_det.PASSWORD + "' WHERE  User_ID = '" + u_det.UID + "'", connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@uid", u_det.UID);
                command.Parameters.AddWithValue("@username", u_det.USERNAME);
                command.Parameters.AddWithValue("@password", u_det.PASSWORD);

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

        public DataSet Find_User(String arg)
        {
            DataSet ds = null;

            try
            {
                SqlConnection connection = new SqlConnection(cls.setConnectionString());
                connection.Open();

                String selectStr = "SELECT * FROM Login Where Login_id = '" + arg + "'";

                SqlDataAdapter da = new SqlDataAdapter(selectStr, connection);
                ds = new DataSet();
                da.Fill(ds, "Login");

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

        public void Find_UID(User_Details u_id)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE Login_id='" + u_id.UID + "' OR Username ='" + u_id.USERNAME + "' ", connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@uid", u_id.UID);
                command.Parameters.AddWithValue("@ueid", u_id.UEID);
                command.Parameters.AddWithValue("@uname", u_id.USERNAME);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("User ID or Username already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

