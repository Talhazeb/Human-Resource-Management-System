using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    class Payment
    {
        string _payid;
        string _empid;
        string _empname;
        string _designation;
        DateTime _saldate;
        string _basicsal;
        string _incentives;
        string _totsal;
        string _app;

        public string PAYID
        {
            get
            {
                return _payid;
            }
            set
            {
                _payid = value;
            }
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

        public string EMPNAME
        {
            get
            {
                return _empname;
            }
            set
            {
                _empname = value;
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
        public DateTime SALDATE
        {
            get
            {
                return _saldate;
            }
            set
            {
                _saldate = value;
            }
        }

        public string BASICSAL
        {
            get
            {
                return _basicsal;
            }
            set
            {
                _basicsal = value;
            }
        }

        public string INCENTIVES
        {
            get
            {
                return _incentives;
            }
            set
            {
                _incentives = value;
            }
        }

        public string TOTSAL
        {
            get
            {
                return _totsal;
            }
            set
            {
                _totsal = value;
            }
        }

        public string APPRISAL
        {
            get
            {
                return _app;
            }
            set
            {
                _app = value;
            }
        }
    }

