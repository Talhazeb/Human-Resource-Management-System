using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Test
{
    class Commoncls
    {
        public static SqlConnection sSQLConnection = new SqlConnection();
        public SqlDataAdapter sSQLDataAdapter = new SqlDataAdapter();
        public SqlCommand sSQLCommand = new SqlCommand();
       // public static SqlDataReader sSQLDataReader;

        public string setConnectionString()
        {
            return "Data Source=TALHA\\SQLEXPRESS;Initial Catalog=HRMS_DB;Integrated Security=True";
           
        }

        public void setSqlConnectionState()//For sql Connection
        {
            if (sSQLConnection.State == ConnectionState.Open)
                sSQLConnection.Close();
            sSQLConnection.ConnectionString = setConnectionString();
        }

        public static void setListview(ListView sListView, String sCaption, Byte sIcon, ImageList sImageList)
        {
            sListView.Width = 250;
            sListView.LargeImageList = sImageList;
            sListView.SmallImageList = sImageList;
            sListView.Items.Add(new ListViewItem(sCaption, sIcon));
        }

        public static void setCreateDirectory(string sFolder, string sLocation)
        {
            try { if (Directory.Exists(sLocation + "\\" + sFolder) == false) { Directory.CreateDirectory(sLocation + "\\" + sFolder); } }
            catch (Exception ex) 
            {
                ex.ToString();
            }
        }


        public void getSqlRecordCount(DataSet dsFill, string sSQL, string sTable)
        {
            setSqlConnectionState();
            sSQLDataAdapter.SelectCommand = new SqlCommand(sSQL, sSQLConnection);
            dsFill.Clear();
            sSQLDataAdapter.Fill(dsFill, sTable);
        }

        public void setWebInfo_Create()
        {
            try
            {

           
            //DATASET VARIABLES
            DataSet dsEmployees = new DataSet();
            DataSet dsEmpFemale = new DataSet();
            DataSet dsEmpMale = new DataSet();
            DataSet dsDepartment = new DataSet();
            DataSet dsEmpActive = new DataSet();
            DataSet dsLeave = new DataSet();
            

            getSqlRecordCount(dsDepartment, "SELECT Dep_Status AS Dep FROM  Dep_Details Where Dep_Status='A' ", "Dep_Details");
            getSqlRecordCount(dsEmployees, "SELECT Sex FROM Emp_Details Where Sex ='Male' OR Sex='Female'", "Emp_Details");          
            getSqlRecordCount(dsEmpMale, "SELECT Sex FROM Emp_Details Where Sex ='Male' ", "Emp_Details");
            getSqlRecordCount(dsEmpFemale, "SELECT Sex FROM Emp_Details Where Sex ='Female' ", "Emp_Details");
            getSqlRecordCount(dsEmpActive, "SELECT * FROM Att_Details WHERE Status = 'IN' AND  (Date_Time >= CONVERT(CHAR(8), GETDATE(), 112))", "Att_Details");
            getSqlRecordCount(dsLeave, "SELECT * FROM Leave_Details WHERE (App_Date >= CONVERT(CHAR(8), GETDATE(), 112))", "Leave_Details");
          
            FileStream sFileStream = new FileStream(Path.GetTempPath().ToString() + @"hrmsinfo.htm", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sStreamWriter = new StreamWriter(sFileStream);

            // Write to the file using StreamWriter class 
            sStreamWriter.BaseStream.Seek(0, SeekOrigin.End);
            sStreamWriter.WriteLine("<html>");
            sStreamWriter.WriteLine("<body bgcolor = '#f4f4f4' leftmargin='0' topmargin='10' text='#000000'>");
            sStreamWriter.WriteLine("<marquee behavior='scrol' direction='left' style='font-family:Arial, Helvetica, sans-serif; font-size:11px' scrolldelay='200'>");
            sStreamWriter.WriteLine("<strong>Department : " + dsDepartment.Tables["Dep_Details"].Rows.Count + " <<>>  </strong> ");
            sStreamWriter.WriteLine("<strong>Total Employees : " + dsEmployees.Tables["Emp_Details"].Rows.Count + " <<>>  </strong>");           
            sStreamWriter.WriteLine("<strong text='#00FF00'>Male Employees   : " + dsEmpMale.Tables["Emp_Details"].Rows.Count + " <<>>  </strong>");
            sStreamWriter.WriteLine("<strong text='#00FF00'>Female Employees : " + dsEmpFemale.Tables["Emp_Details"].Rows.Count + " <<>>  </strong>");
            sStreamWriter.WriteLine("<strong text='#00FF00'>Today Active Employees : " + dsEmpActive.Tables["Att_Details"].Rows.Count + " <<>>  </strong>");
            sStreamWriter.WriteLine("<strong text='#00FF00'>Today Leave Employees : " + dsLeave.Tables["Leave_Details"].Rows.Count + " </strong>");
            
            sStreamWriter.WriteLine("</marquee>");
            sStreamWriter.WriteLine("</body>");
            sStreamWriter.WriteLine("</html>");
            sStreamWriter.Flush();
            }
            catch (System.IO.IOException exp)
            {

                exp.ToString();
            }
        }

        public void setWebInfo_Remove()
        {
            try
            {
                File.Delete(Path.GetTempPath().ToString() + @"hrmsinfo.htm");
            }
            catch (System.IO.IOException exp)
            {

              exp.ToString();
            }
           
        }
       
        public void setMDIChild(Form sMDIChild, Form sMDIParent)
        {
            sMDIChild.MdiParent = sMDIParent;
            sMDIChild.Show();
            sMDIChild.Activate();
        }
        public void setSqlcommand(DataSet dsFill, SqlDataAdapter daFill, string sSQL, string sTable)
        {
            setSqlConnectionState();
            daFill.SelectCommand = new SqlCommand(sSQL, sSQLConnection);
            dsFill.Clear();
            daFill.Fill(dsFill, sTable);
        }

        public void setComboList(ComboBox sComboBox, string sSQL, string sTable, string sFieldName,string sValue)
        {
            DataSet sDataSet = new DataSet();
            SqlDataAdapter sOleDbDataAdapter = new SqlDataAdapter();
            setSqlcommand(sDataSet, sOleDbDataAdapter, sSQL, sTable);

            sComboBox.DataSource = sDataSet.Tables[0].DefaultView;
            sComboBox.DisplayMember = sFieldName;
            sComboBox.ValueMember = sValue;
        }
        public void Sqlback()
        {
        string dbname = "HRMS_DB";
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        // sqlcon.ConnectionString = "Data Source=nuwan-pc\\sqlexpress;Initial Catalog=MMS;Integrated Security=True";//@"nuwan-pc\\sqlexpress;Initial Catalog=MMS;Integrated Security=True" providerName";//@"Server=RAVI-PC\SQLEXPRESS;database=" + dbname + ";uid=ravindran;pwd=srirangam;";
         sqlcon.ConnectionString = setConnectionString();
           
            string destdir = "D:\\BackupSqlDataBase";

          
            if (!System.IO.Directory.Exists(destdir))
            {
                System.IO.Directory.CreateDirectory("D:\\BackupSqlDataBase");
            }
            try
            {
               
                sqlcon.Open();
               
                sqlcmd = new SqlCommand("backup database  " + dbname + " to disk='" + destdir + "\\" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".bak'", sqlcon);
                sqlcmd.ExecuteNonQuery();
                
                sqlcon.Close();
                MessageBox.Show("Check your Partition E:\\ Backup DataBase Successfully","Backup",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error During backup database!");
            }
        }
        
        public void setCreateError(string sErrorMessage, string sLocation, string sFileName)
        {
            try
            {
             
                FileStream sFileStream = new FileStream(sLocation + sFileName + ".err", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sStreamWriter = new StreamWriter(sFileStream);

               
                sStreamWriter.BaseStream.Seek(0, SeekOrigin.End);
                sStreamWriter.WriteLine(sErrorMessage);
                sStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }


        
    }
}
