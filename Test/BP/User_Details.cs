using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class User_Details
    {
        string _uid;
        string _uempid;
        string _username;
        string _password;

        public string UID
        {
            get
            {
                return _uid;
            }
            set
            {
                _uid = value;
            }
        }


        public string UEID
        {
            get
            {
                return _uempid;
            }
            set
            {
                _uempid = value;
            }
        }

        public string USERNAME
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string PASSWORD
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
    }

