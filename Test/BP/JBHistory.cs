using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class JBHistory
    {
        string _jbhID;
        string _jbempID;
        DateTime _jbJoingDate;
        DateTime _jbRsgDate;
        string _jbTitle;
        string _comment;

        public string JBHID
        {
            get
            {
                return _jbhID;
            }
            set
            {
                _jbhID = value;
            }
        }

        public string JBEMPID
        {
            get
            {
                return _jbempID;
            }
            set
            {
                _jbempID = value;
            }
        }

        public DateTime JBJOINGDATE
        {
            get
            {
                return _jbJoingDate;
            }
            set
            {
                _jbJoingDate = value;
            }
        }

        public DateTime JBRSGDATE
        {
            get
            {
                return _jbRsgDate;
            }
            set
            {
                _jbRsgDate = value;
            }
        }

        public string JBTITLE
        {
            get
            {
                return _jbTitle;
            }
            set
            {
                _jbTitle = value;
            }
        }

        public string COMMENT
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }
    }

