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
    public partial class Pay_RPT : Form
    {
        public Pay_RPT()
        {
            InitializeComponent();
        }

        private void Pay_RPT_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HRMS_DBDataSet1.Pay_Details' table. You can move, or remove it, as needed.
            this.Pay_DetailsTableAdapter.Fill(this.HRMS_DBDataSet1.Pay_Details,txtempid.Text,DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));

            this.reportViewer1.RefreshReport();
        }

        private void Pay_RPT_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
