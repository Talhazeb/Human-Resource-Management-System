using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Test;



    class PaymentDAL
    {

        Commoncls cls = new Commoncls();
         Payment pd = new Payment();
        public int Insert(Payment pay_det)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Pay_Details VALUES( @payid, @Emp_Id, @DateTime, @basic, @incentive, @apprasal, @totsal)", connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@payid", pay_det.PAYID);
                command.Parameters.AddWithValue("@Emp_Id", pay_det.EMPID);
                command.Parameters.AddWithValue("@DateTime", pay_det.SALDATE);
                command.Parameters.AddWithValue("@basic", pay_det.BASICSAL);
                command.Parameters.AddWithValue("@incentive", pay_det.INCENTIVES);
                command.Parameters.AddWithValue("@apprasal", pay_det.APPRISAL);
                command.Parameters.AddWithValue("@totsal", pay_det.TOTSAL);
                

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


        public int Update_Pay(Payment pay)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            String selectStr = "UPDATE Pay_Details SET Emp_Id = @emp_Id,Sal_Date=@saldate,Basic_Sal=@basic,Incentives=@incentiv,Apprisal=@app,Tot_Sal=@totsal WHERE (Pay_Id = '" + pay.PAYID + "')";
            SqlCommand command = new SqlCommand(selectStr, connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@emp_Id", pay.EMPID);
                command.Parameters.AddWithValue("@saldate", pay.SALDATE);
                command.Parameters.AddWithValue("@basic", pay.BASICSAL);
                command.Parameters.AddWithValue("@incentiv", pay.INCENTIVES);
                command.Parameters.AddWithValue("@app", pay.APPRISAL);
                command.Parameters.AddWithValue("@totsal", pay.TOTSAL);
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


        public DataSet Find_pay(String arg)
        {
            DataSet ds = null;

            try
            {
                SqlConnection connection = new SqlConnection(cls.setConnectionString());
                connection.Open();

                String selectStr = "SELECT Pay_Details.Pay_Id, Emp_Details.Full_Name,Emp_Details.Emp_Id, Pay_Details.Emp_Id, Pay_Details.Sal_Date, Pay_Details.Basic_Sal, Pay_Details.Incentives,Pay_Details.Apprisal, Pay_Details.Tot_Sal FROM  Pay_Details INNER JOIN  Emp_Details ON Pay_Details.Emp_Id = Emp_Details.Emp_Id   WHERE Pay_Details.Pay_Id = '" + arg + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, connection);
                ds = new DataSet();
                da.Fill(ds, "Pay_Details");

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


        public DataSet Find_Pay_First(String arg)
        {
            DataSet ds = null;

            try
            {
                SqlConnection connection = new SqlConnection(cls.setConnectionString());
                connection.Open();

                String selectStr = "select * From Emp_Details WHERE Emp_Id = '" + arg + "'";//"SELECT Pay_Details.Pay_Id, Emp_Details.Full_Name,Emp_Details.Emp_Id,Emp_Details.Designation,Emp_Details.Basic_Sal, Pay_Details.Emp_Id, Pay_Details.Sal_Date, Pay_Details.Basic_Sal, Pay_Details.Incentives,Pay_Details.Apprisal, Pay_Details.Tot_Sal FROM  Pay_Details INNER JOIN  Emp_Details ON Pay_Details.Emp_Id = Emp_Details.Emp_Id   WHERE Pay_Details.Pay_Id = '" + arg + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, connection);
                ds = new DataSet();
                da.Fill(ds, "Emp_Details");

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


        public int Delete_Pay(Payment pay_det)
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Pay_Details WHERE Pay_Id = '" + pay_det.PAYID + "'", connection);
            command.CommandType = CommandType.Text;
            try
            {
                command.Parameters.AddWithValue("@payid", pay_det.PAYID);
               
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
            string query = "SELECT Pay_Details.Pay_Id, Emp_Details.Full_Name, Pay_Details.Emp_Id, Pay_Details.Sal_Date, Pay_Details.Basic_Sal, Pay_Details.Incentives, Pay_Details.Apprisal, Pay_Details.Tot_Sal FROM  Pay_Details INNER JOIN  Emp_Details ON Pay_Details.Emp_Id = Emp_Details.Emp_Id ";
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


        public DataTable GetData_with(Payment P)
        {
            string query = "SELECT Pay_Details.Pay_Id, Emp_Details.Full_Name, Pay_Details.Emp_Id, Pay_Details.Sal_Date, Pay_Details.Basic_Sal, Pay_Details.Incentives, Pay_Details.Apprisal, Pay_Details.Tot_Sal FROM  Pay_Details INNER JOIN  Emp_Details ON Pay_Details.Emp_Id = Emp_Details.Emp_Id WHERE Pay_Details.Pay_Id='" + P.PAYID + "' ";
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

