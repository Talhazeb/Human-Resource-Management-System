using System;
using System.Data;
using System.Configuration;


/// <summary>
/// Summary description for PersonBAL
/// </summary>
public class PersonBAL
{
	public PersonBAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int Insert(Person person)
    {
        PersonDAL PDAL = new PersonDAL();
        try
        {
            return PDAL.Insert(person);
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            PDAL = null;
        }
    }

    public int Update_P(Person pup)
    {
        PersonDAL PDAL = new PersonDAL();
        try
        {
           return PDAL.Update_Emp(pup);
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
           
        }
    }

    public DataSet Find_Emp(String str)
    {
        PersonDAL PFDAL = new PersonDAL();
        DataSet data = null;

        data = PFDAL.Find_Emp(str);

        return data;

    }


    public void Find(Person p_id)
    {
        PersonDAL PDAL = new PersonDAL();
        try
        {
            PDAL.Find(p_id);
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            PDAL = null;
        }
    }

    public int Delete_Per(Person person)
    {
        PersonDAL PDAL = new PersonDAL();
        try
        {
            return PDAL.Delete_Per(person);
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            PDAL = null;
        }
    }


    public DataTable Bind_Getdata()
    {
        PersonDAL PDAL = new PersonDAL();
        try
        {
           return PDAL.GetData();
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            PDAL = null;
        }
    }

    public DataTable Bind_Getdata_with(Person P)
    {
        PersonDAL PDAL = new PersonDAL();
        try
        {
            return PDAL.GetDataWith(P);
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            PDAL = null;
        }
    }

    public void Bind()
    {
        PersonDAL PDAL = new PersonDAL();
        try
        {
          PDAL.GetData();
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            PDAL = null;
        }
    }


}
