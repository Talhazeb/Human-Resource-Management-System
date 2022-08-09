using System;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{

    string _pcode;
    string _pname;
    int _quentity;
    DateTime _expdate;

	public Product()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string ProductCode
    {
        get
        {
            return _pcode;
        }
        set
        {
            _pcode = value;
        }
    }
    public string ProductName
    {
        get
        {
            return _pname;
        }
        set
        {
            _pname = value;
        }
    }
    public int PQuentity
    {
        get
        {
            return _quentity;
        }
        set
        {
            _quentity = value;
        }
    }
    public DateTime ExpDate
    {
        get
        {
            return _expdate;
        }
        set
        {
            _expdate = value;
        }
    }

}
