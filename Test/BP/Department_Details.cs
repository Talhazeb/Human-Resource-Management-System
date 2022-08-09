using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test;
using System.Windows.Forms;


 class Department_Details

    {
    string _depid;
    string _depname;
    string _dephead;
    string _dsc;

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
        public string DepName
        {
            get
            {
                return _depname;
            }
            set
            {
                _depname = value;
            }
        }
        public string DepHead
        {
            get
            {
                return _dephead;
            }
            set
            {
                _dephead = value;
            }
        }

        public string DSC
        {
            get
            {
                return _dsc;
            }
            set
            {
                _dsc = value;
            }
        }
    }

