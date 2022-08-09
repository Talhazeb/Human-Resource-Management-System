using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    class Leave
    {
        string _leaveid;
        string _empid;
        DateTime _appdate;
        DateTime _resdate;
        string _type;

        public string LEAVEID
        {
            get
            {
                return _leaveid;
            }
            set
            {
                _leaveid = value;
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

        public DateTime APPDATE
        {
            get
            {
                return _appdate;
            }
            set
            {
                _appdate = value;
            }
        }

        public DateTime RESDATE
        {
            get
            {
                return _resdate;
            }
            set
            {
                _resdate = value;
            }
        }

        public string TYPE
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
    }

