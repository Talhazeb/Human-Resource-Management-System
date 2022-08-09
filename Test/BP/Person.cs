using System;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
    string _empid;
    string _depid;
    string _nic;
    string _firstname;
    string _lastname;
    string _fullname;
    string _sex;
    int _age;
    DateTime _dob;
    string _address;
    string _city;
    string _country;
    string _busnumber;
    string _homenumber;

    string _basic;
    string _mstatus;
    string _confirm;
    string _designation;


	public Person()
	{
		//
		// TODO: Add constructor logic here
    	//
	}
    public string EMPID
    {
        get
        {
            return _empid;
        }
        set
        {
            _empid = value;
        }
    }
    public string DEPID
    {
        get
        {
            return _depid;
        }
        set
        {
            _depid = value;
        }
    }
    public string NIC
    {
        get
        {
            return _nic;
        }
        set
        {
            _nic = value;
        }
    }

    public string FIRSTNAME
    {
        get
        {
            return _firstname;
        }
        set
        {
            _firstname = value;
        }
    }
    public string LASTNAME
    {
        get
        {
            return _lastname;
        }
        set
        {
            _lastname = value;
        }
    }

    public string FULLNAME
    {
        get
        {
            return _fullname;
        }
        set
        {
            _fullname = value;
        }

    }
    public string SEX
    {
        get
        {
            return _sex;
        }
        set
        {
            _sex = value;
        }
    }
    public int AGE
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }
    public DateTime DOB
    {
        get
        {
            return _dob;
        }
        set
        {
            _dob = value;
        }
    }
    public string ADDRESS
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
        }
    }
    public string CITY
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }
    public string COUNTRY
    {
        get
        {
            return _country;
        }
        set
        {
            _country = value;
        }
    }
    public string BUSNUMBER
    {
        get
        {
            return _busnumber;
        }
        set
        {
            _busnumber = value;
        }
    }
    public string HOMENUMBER
    {
        get
        {
            return _homenumber;
        }
        set
        {
            _homenumber = value;
        }
    }

    public string MSTATUS
    {
        get
        {
            return _mstatus;
        }
        set
        {
            _mstatus = value;
        }
    }

    public string BASIC
    {
        get
        {
            return _basic;
        }
        set
        {
            _basic = value;
        }
    }

    public string CONFIRM
    {
        get
        {
            return _confirm;
        }
        set
        {
            _confirm = value;
        }
    }

    public string DESIGNATION
    {
        get
        {
            return _designation;
        }
        set
        {
            _designation = value;
        }
    }
}
