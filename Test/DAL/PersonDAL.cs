using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using Test;
/// <summary>
/// Summary description for PersonDAL
/// </summary>
public class PersonDAL
{
    Commoncls cls = new Commoncls();
    
	public PersonDAL()
	{
	     //
		// TODO: Add constructor logic here
	   //
	}

    public int Insert(Person person)
    {
        SqlConnection connection = new SqlConnection(cls.setConnectionString());
        connection.Open();
        //SqlCommand command = new SqlCommand("InsertData",connection);
        //command.CommandType = CommandType.StoredProcedure;
        //SqlCommand command = new SqlCommand("INSERT INTO Emp_Details VALUES('" + person.EMPID + "','" + person.DEPID + "','" + person.NIC + "','" + person.FIRSTNAME + "','" + person.LASTNAME +"','" + person.FULLNAME +
       //     "','" + person.SEX + "','"+person.AGE+"','" + person.DOB + "','" + person.ADDRESS  +"','"+ person.CITY + "','" + person.COUNTRY + "','" + person.BUSNUMBER + "','" + person.HOMENUMBER + "')", connection);
        SqlCommand command = new SqlCommand("INSERT INTO Emp_Details VALUES(@Emp_Id,@Dep_Id,@NIC,@conf,@First_Name,@Last_Name,@Full_Name,@Sex,@msta,@Age,@DOB,@Address,@City,@Country,@Bus_Number,@Home_Number,@basic,@designation)", connection);   
        command.CommandType = CommandType.Text;
        try
        {
            command.Parameters.AddWithValue("@Emp_Id", person.EMPID);
            command.Parameters.AddWithValue("@Dep_Id",  person.DEPID);
            command.Parameters.AddWithValue("@NIC",  person.NIC);
            command.Parameters.AddWithValue("@conf", person.CONFIRM);
            command.Parameters.AddWithValue("@First_Name",person.FIRSTNAME);
            command.Parameters.AddWithValue("@Last_Name", person.LASTNAME);
            command.Parameters.AddWithValue("@Full_Name", person.FULLNAME);
            command.Parameters.AddWithValue("@Sex", person.SEX);
            command.Parameters.AddWithValue("@msta", person.MSTATUS);
            command.Parameters.AddWithValue("@Age", person.AGE);
            command.Parameters.AddWithValue("@DOB", person.DOB);
            command.Parameters.AddWithValue("@Address", person.ADDRESS);
            command.Parameters.AddWithValue("@City", person.CITY);
            command.Parameters.AddWithValue("@Country", person.COUNTRY);
            command.Parameters.AddWithValue("@Bus_Number", person.BUSNUMBER);
            command.Parameters.AddWithValue("@Home_Number", person.HOMENUMBER);
            command.Parameters.AddWithValue("@basic", person.BASIC);
            command.Parameters.AddWithValue("@designation", person.DESIGNATION);

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


    public int Update_Emp(Person pup)
    {
        SqlConnection connection = new SqlConnection(cls.setConnectionString());
        connection.Open();

        String selectStr = "UPDATE Emp_Details SET Dep_Id = @dep_Id, NIC= @nic, Confirmation=@conf, First_Name=@fname, Last_Name=@lname, Full_Name=@fullname, Sex=@sex, M_Sta=@msta, Age=@age, D_O_Birth=@dob, Address=@address, City=@city, Country=@country, Business_Number=@bnum, Basic_sal=@basic,Designation=@designation WHERE (Emp_Id = @empid)";
        SqlCommand command = new SqlCommand(selectStr, connection);
        command.CommandType = CommandType.Text;
        try
        {
            command.Parameters.AddWithValue("@empid",pup.EMPID);
            command.Parameters.AddWithValue("@dep_Id", pup.DEPID);
            command.Parameters.AddWithValue("@nic", pup.NIC);
            command.Parameters.AddWithValue("@conf", pup.CONFIRM);
            command.Parameters.AddWithValue("@fname", pup.FIRSTNAME);
            command.Parameters.AddWithValue("@lname", pup.LASTNAME);
            command.Parameters.AddWithValue("@fullname", pup.FULLNAME);
            command.Parameters.AddWithValue("@sex", pup.SEX);
            command.Parameters.AddWithValue("@msta", pup.MSTATUS);
            command.Parameters.AddWithValue("@age", pup.AGE);
            command.Parameters.AddWithValue("@dob", pup.DOB);
            command.Parameters.AddWithValue("@address", pup.ADDRESS);
            command.Parameters.AddWithValue("@city", pup.CITY);
            command.Parameters.AddWithValue("@country", pup.COUNTRY);
            command.Parameters.AddWithValue("@bnum", pup.BUSNUMBER);
            command.Parameters.AddWithValue("@basic", pup.BASIC);
            command.Parameters.AddWithValue("@designation", pup.DESIGNATION);

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
    public DataSet Find_Emp(String arg)
    {
        DataSet ds = null;

        try
        {
            SqlConnection connection = new SqlConnection(cls.setConnectionString());
            connection.Open();

            String selectStr = "SELECT  Emp_Details.Emp_Id, Dep_Details.Dep_Name, Emp_Details.NIC, Emp_Details.First_Name, Emp_Details.Last_Name, Emp_Details.Full_Name, Emp_Details.Sex,  Emp_Details.Age, Emp_Details.D_O_Birth, Emp_Details.Address, Emp_Details.City, Emp_Details.Country, Emp_Details.Business_Number, Emp_Details.Home_Number,Emp_Details.M_Sta,Emp_Details.Confirmation,Emp_Details.Basic_sal,Emp_Details.Designation FROM  Emp_Details INNER JOIN Dep_Details ON Emp_Details.Dep_Id = Dep_Details.Dep_Id  WHERE Emp_Details.NIC = '" + arg + "'";
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

    public void Find(Person p_id)
    {
        SqlConnection connection = new SqlConnection(cls.setConnectionString());
        connection.Open();

        SqlCommand command = new SqlCommand("SELECT * FROM Emp_Details WHERE Emp_Id=@pid", connection);
        command.CommandType = CommandType.Text;
        try
        {
            command.Parameters.AddWithValue("@pid", p_id.EMPID);
            SqlDataReader reader=command.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Employee ID already exists","Exists",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

    public int Delete_Per(Person per)
    {
        SqlConnection connection = new SqlConnection(cls.setConnectionString());
        connection.Open();

        String selectStr = "DELETE FROM Emp_Details  WHERE (NIC = @nic)";
        SqlCommand command = new SqlCommand(selectStr, connection);
        command.CommandType = CommandType.Text;
        try
        {
            command.Parameters.AddWithValue("@nic", per.NIC);

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


    public  DataTable GetData()
    {
        string query = "SELECT  Emp_Details.Emp_Id, Dep_Details.Dep_Name, Emp_Details.NIC, Emp_Details.First_Name, Emp_Details.Last_Name, Emp_Details.Full_Name, Emp_Details.Sex,  Emp_Details.Age, Emp_Details.D_O_Birth, Emp_Details.Address, Emp_Details.City, Emp_Details.Country, Emp_Details.Business_Number, Emp_Details.Home_Number,Emp_Details.Basic_sal,Emp_Details.Designation FROM  Emp_Details INNER JOIN Dep_Details ON Emp_Details.Dep_Id = Dep_Details.Dep_Id";
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

    public DataTable GetDataWith(Person p)
    {
        string query = "SELECT  Emp_Details.Emp_Id, Dep_Details.Dep_Name, Emp_Details.NIC, Emp_Details.First_Name, Emp_Details.Last_Name, Emp_Details.Full_Name, Emp_Details.Sex,  Emp_Details.Age, Emp_Details.D_O_Birth, Emp_Details.Address, Emp_Details.City, Emp_Details.Country, Emp_Details.Business_Number, Emp_Details.Home_Number,Emp_Details.Basic_sal,Emp_Details.Designation FROM  Emp_Details INNER JOIN Dep_Details ON Emp_Details.Dep_Id = Dep_Details.Dep_Id WHERE NIC LIKE '%" + p.NIC + "%'";
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
