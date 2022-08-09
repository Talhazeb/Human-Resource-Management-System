using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Emp_RPT : Form
    {
        public Emp_RPT()
        {
            InitializeComponent();
        }

        private void Emp_RPT_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HRMS_DBDataSet.Emp_Details' table. You can move, or remove it, as needed.
            this.Emp_DetailsTableAdapter.Fill(this.HRMS_DBDataSet.Emp_Details,txtEmpid.Text);

            this.reportViewer1.RefreshReport();
        }

        private void Emp_RPT_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
