using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test;

    class Atten_Details
    {
        string _attid;
        string _empid;
        DateTime _datetime;
        string _stauts;

        public string ATTID
        {
            get
            {
                return _attid;
            }
            set
            {
                _attid = value;
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

        public DateTime DATETIME
        {
            get
            {
                return _datetime;
            }
            set
            {
                _datetime = value;
            }
        }
        public string STATUS
        {
            get
            {
                return _stauts;
            }
            set
            {
                _stauts = value;
            }
        }
    }

