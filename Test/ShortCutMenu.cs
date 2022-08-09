using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Test
{
    public partial class ShortCutMenu : Form
    {
        Commoncls clsSettings = new Commoncls();

        public ShortCutMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
                setWebTotals();
                // lbldatetime.Text = DateTime.Now.ToLongTimeString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            //listView1.Location.X = 0;
            //listView1.Location.Y = 10;

            Commoncls.setListview(lvShortcuts, "Employee Data", 0, i64x64);
            Commoncls.setListview(lvShortcuts, "Department", 1, i64x64);
            Commoncls.setListview(lvShortcuts, "Job Profile", 2, i64x64);
            Commoncls.setListview(lvShortcuts, "Attendance Management",3,i64x64);
            Commoncls.setListview(lvShortcuts, "Leave Management", 4, i64x64);
            Commoncls.setListview(lvShortcuts, "Payment", 5, i64x64);
            Commoncls.setListview(lvShortcuts, "User Account", 6, i64x64);
            Commoncls.setListview(lvShortcuts, "MS Excel", 7, i64x64);
            Commoncls.setListview(lvShortcuts, "Internet", 8, i64x64);
            //Commoncls.setListview(lvShortcuts, "DB Backup", 9, i64x64);
            Commoncls.setListview(lvShortcuts, "Exit the System", 10, i64x64);
            Commoncls.setCreateDirectory("Errors", AppDomain.CurrentDomain.BaseDirectory);
        // Class1
        }
        public void setWebTotals()
        {
            wbInformation.Navigate("");
            clsSettings.setWebInfo_Remove();
            clsSettings.setWebInfo_Create();
            wbInformation.Navigate(Path.GetTempPath().ToString() + @"hrmsinfo.htm");
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void lvShortcuts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvShortcuts_DoubleClick(object sender, EventArgs e)
        {
            switch (lvShortcuts.Items[lvShortcuts.FocusedItem.Index].SubItems[0].Text)
            {
                case "Employee Data":
                    cmsemp_det_Click(sender, e);
                    break;
                case "Department":
                    cmsF1_Click(sender, e);
                    break;
                case "Job Profile":
                    cmsF3_Click(sender, e);
                    break;
                case "Attendance Management":
                    cmsF4_Click(sender, e);
                    break;
                case "Leave Management":
                    cmsF5_Click(sender, e);
                    break;
                case "Payment":
                    cmsF6_Click(sender, e);
                    break;

                case "User Account":
                    cmsF8_Click(sender, e);
                    break;

                case "MS Excel":
                     cmsFex_Click(sender, e);
                    break;
                case "Internet":
                     cmsFIn_Click(sender, e);
                    break;
                //case "DB Backup":
                //    cmsback_Click(sender, e);
                //    break;
                case "Windows Wordpad":
                   // cmsCtrlF6_Click(sender, e);
                    break;
                case "Exit the System":
                    cmsF7_Click(sender, e);
                    break;
            }
             
        }
        private void cmsemp_det_Click(object sender, EventArgs e)
        {
            Employee_Details Details = new Employee_Details();
            Details.ShowDialog();
        }
        private void cmsF1_Click(object sender, EventArgs e)
        {

            DepartmentDetails dd = new DepartmentDetails();
            dd.ShowDialog();
       //  clsSettings.setMDIChild(DepartmentDetails.Instance(), MainMenu.publicMDIParent); 
                      
        }
        private void cmsF3_Click(object sender, EventArgs e)
        {
            JobHistoryDetails jbhd = new JobHistoryDetails();
            jbhd.ShowDialog();
        }
        private void cmsF4_Click(object sender, EventArgs e)
        {
            Attendance_Details att = new Attendance_Details();
            att.ShowDialog();
        }
        private void cmsF5_Click(object sender, EventArgs e)
        {
            Leave_Details leave = new Leave_Details();
            leave.ShowDialog();
        }

        private void cmsF6_Click(object sender, EventArgs e)
        {
            Payment_Details pay = new Payment_Details();
            pay.ShowDialog();
        }
        private void cmsF8_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }
        private void cmsFex_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }
        private void cmsFIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }
        private void cmsback_Click(object sender, EventArgs e)
        {
            clsSettings.Sqlback();
        }
        private void cmsF7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                setWebTotals();
                // lbldatetime.Text = DateTime.Now.ToLongTimeString();
            }
            catch (System.IO.IOException exp)
            {
               
                MessageBox.Show(exp.ToString());
            }
           
        }

        //private void CenterControlInParent(Control ctrlToCenter)
        //{
        //    //ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width)/4;
        //    ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height)/2;

        //}

        private void ShortCutMenu_SizeChanged(object sender, EventArgs e)
        {
          
        }

    }
}
