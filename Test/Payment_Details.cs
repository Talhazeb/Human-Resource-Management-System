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
    public partial class Payment_Details : Form
    {
        public Payment_Details()
        {
            InitializeComponent();
        }
        Commoncls cls = new Commoncls();
        Payment pay = new Payment();
      //  PaymentDAL pdal = new  PaymentDAL();
        PaymentBAL pbal = new PaymentBAL();

        private void btnadd_Click(object sender, EventArgs e)
        {
            int insertrec = 0;
            try
            {
                if(txtpayid.Text == "" || txtbasic.Text == "" || txtincentive.Text == "")
                {
                    MessageBox.Show("Please Fill All field Correctly", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                pay.PAYID = txtpayid.Text;
                pay.EMPID = cmemp.SelectedValue.ToString();
                pay.SALDATE = DateTime.Parse(dateTimePicker1.Value.ToShortDateString());
                pay.BASICSAL = txtbasic.Text;
                pay.INCENTIVES = txtincentive.Text;
                pay.APPRISAL = txtapp.Text;
                pay.TOTSAL = txttot.Text;
                
                
                insertrec = pbal.Insert(pay);
                GridBind();
                if (insertrec > 0)
                {
                    MessageBox.Show("Record Insert Successfull", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Already Insert!!!");
                }
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString(), "Insert Error");
            }
            finally
            {

            }

        }

        private void Payment_Details_Load(object sender, EventArgs e)
        {
            Load_Combo();
            GridBind();
        }

        private void Load_Combo()
        {
            cls.setComboList(this.cmemp, "Select Emp_Id,Full_Name From Emp_Details Order By Emp_Id ASC", "Emp_Details", "Emp_Id", "Emp_Id");
        }

        private void GridBind()
        {
            dataGridView1.DataSource = pbal.BindGrid();
        }
        private void clear()
        {
            txtbasic.Text = txtincentive.Text = txtpayid.Text = txttot.Text = "";
        }
        private void txtincentive_TextChanged(object sender, EventArgs e)
        {
            if ((txtincentive.Text == "") || (txtbasic.Text == "") || (txtapp.Text == ""))
            {
                txttot.Text = "";//MessageBox.Show("The Value are cannot empty");
            }
            else
            {
                try
                {
                    double a, b, c, d;

                    a = double.Parse(txtbasic.Text);
                    b = double.Parse(txtincentive.Text);
                    d = double.Parse(txtapp.Text);
                    c = a + b + d;

                    txttot.Text = c.ToString();
                }
                catch (Exception ex)
                {
                    ex.ToString();

                }
            }
             
            
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                String PayID = txtfind.Text;

                DataSet ds = pbal.Find_Pay(PayID);
                DataRow row;
                row = ds.Tables[0].Rows[0];

                MessageBox.Show(row["Full_Name"].ToString());

                // GridBind();

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    txtpayid.Text = rows["Pay_Id"].ToString();
                    cmemp.Text = rows["Emp_Id"].ToString();
                    dateTimePicker1.Text = rows["Sal_Date"].ToString();
                    txtbasic.Text = rows["Basic_Sal"].ToString();
                    txtincentive.Text = rows["Incentives"].ToString();
                    txtapp.Text = rows["Apprisal"].ToString();
                    txttot.Text = rows["Tot_Sal"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfind.Text == "")
                {
                    MessageBox.Show("You Moust Find PayID First", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    pay.PAYID = txtfind.Text;
                    pay.EMPID = cmemp.SelectedValue.ToString();
                    pay.SALDATE = DateTime.Parse(dateTimePicker1.Value.ToShortDateString());
                    pay.BASICSAL = txtbasic.Text;
                    pay.INCENTIVES = txtincentive.Text;
                    pay.APPRISAL = txtapp.Text;
                    pay.TOTSAL = txttot.Text;
                    pbal.Update_Pay(pay);

                    GridBind();
                    MessageBox.Show("Record Update Successfull", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                // Dpm = null;
                //  Ddal = null;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                pay.PAYID = txtfind.Text;
                pbal.Delete_Pay(pay);
                GridBind();
                MessageBox.Show("Record Delete Successfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Delete Error");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbasic_TextChanged(object sender, EventArgs e)
        {
            if ((txtincentive.Text == "") || (txtbasic.Text == "") || (txtapp.Text == ""))
            {
                txttot.Text = "";//MessageBox.Show("The Value are cannot empty");
            }
            else
            {
                try
                {
                    double a, b, c, d;

                    a = double.Parse(txtbasic.Text);
                    b = double.Parse(txtincentive.Text);
                    d = double.Parse(txtapp.Text);
                    c = a + b + d;

                    txttot.Text = c.ToString();
                }
                catch (Exception ex)
                {
                    ex.ToString();

                }
            }
              
        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtfind.Text == "")
                {
                    GridBind();
                }
                else
                {
                    pay.PAYID = txtfind.Text;
                    dataGridView1.DataSource = pbal.BindGrid_with(pay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Grid Error");
                
            }
           
        }

        private void txtapp_TextChanged(object sender, EventArgs e)
        {
            if ((txtincentive.Text == "") || (txtbasic.Text == "") || (txtapp.Text == ""))
            {
                txttot.Text = "";//MessageBox.Show("The Value are cannot empty");
            }
            else
            {
                try
                {
                    double a, b, c, d;

                    a = double.Parse(txtbasic.Text);
                    b = double.Parse(txtincentive.Text);
                    d = double.Parse(txtapp.Text);
                    c = a + b + d;

                    txttot.Text = c.ToString();
                }
                catch (Exception ex)
                {
                    ex.ToString();

                }
            }
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                String EmpID = cmemp.SelectedValue.ToString();

                DataSet ds = pbal.Find_Pay_Firstly(EmpID);
                DataRow row;
                row = ds.Tables[0].Rows[0];

               // MessageBox.Show(row["Full_Name"].ToString());

                // GridBind();

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    
                    txtempname.Text = rows["Full_Name"].ToString();
                    txtbasic.Text = rows["Basic_Sal"].ToString();
                    txtdesig.Text = rows["Designation"].ToString();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}

