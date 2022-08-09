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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
           // lbluser.Text = user;
        }
        Commoncls cls = new Commoncls();
        public static MainMenu publicMDIParent;

        private void Form1_Load(object sender, EventArgs e)
        {
            ShortCutMenu sForm = new ShortCutMenu();
            sForm.MdiParent = this;
            sForm.Show();

            //try
            //{
            //    setWebTotals();
            //   // lbldatetime.Text = DateTime.Now.ToLongTimeString();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString());
            //}
            publicMDIParent = this;
        }
        //public void setWebTotals()
        //{
        //    wbInformation.Navigate("");
        //    cls.setWebInfo_Remove();
        //    cls.setWebInfo_Create();
        //    wbInformation.Navigate(Path.GetTempPath().ToString() + @"hrmsinfo.htm");
        //}
        private void panelBOTTOM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBOTTOM_LEFT_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                refreshToolStripMenuItem.Enabled = true;
                //setWebTotals();
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            //lbltime.Text = DateTime.Now.ToLongTimeString();
            //lbldate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //setWebTotals();
                refreshToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            } 
        }

        private void employeeDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_RPT emprpt = new Emp_RPT();
            emprpt.ShowDialog();
        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pay_RPT par = new Pay_RPT();
            par.ShowDialog();
        }

        private void picTOP_LEFT_02_Click(object sender, EventArgs e)
        {

        }
    }
}
