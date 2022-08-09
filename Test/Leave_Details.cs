using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class Leave_Details : Form
    {
        public Leave_Details()
        {
            InitializeComponent();
        }
        Commoncls cls = new Commoncls();
        Leave leave = new Leave();
        LeaveBAL leavebal = new LeaveBAL();
        LeaveDAL ldal = new LeaveDAL();

        private void btnadd_Click(object sender, EventArgs e)
        {

            new_ID();

            int insertrec = 0;
            try
            {

                leave.LEAVEID = txtleaveid.Text;
                leave.EMPID = cmbemp.SelectedValue.ToString();
                leave.APPDATE = DateTime.Parse(dateTimePicker1.Value.ToLongTimeString());
                leave.RESDATE = DateTime.Parse(dateTimePicker2.Value.ToLongTimeString());
                leave.TYPE = cmbtype.Text;


                insertrec = leavebal.Insert(leave);
                gridBind();
                if (insertrec > 0)
                {
                    MessageBox.Show("Record Insert Successfull", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Already Insert!!!");
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
        

        private void Leave_Details_Load(object sender, EventArgs e)
        {
            Load_Combo();
            gridBind();
            new_ID();
        }


        private void Load_Combo()
        {
            cls.setComboList(this.cmbemp, "Select Emp_Id,Full_Name From Emp_Details Order By Emp_Id ASC", "Emp_Details", "Emp_Id", "Emp_Id");
                
        }
        private void gridBind()
        {
            dataGridView1.DataSource = ldal.GetData();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtleaveid.Text = "";

        }

        private void btnserch_Click(object sender, EventArgs e)
        {
           
            
        }

        private string GetNextValue(string s)
        {
            return String.Format("L{0:D5}", Convert.ToInt32(s.Substring(3)) + 1);
        }

        #region ID
        private void new_ID()
        {
            try
            {

                SqlConnection con = new SqlConnection(cls.setConnectionString());
                con.Open();
                SqlCommand cmddr = new SqlCommand("select max(Leave_Id) as ids from Leave_Details", con);
                SqlDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {
                    string strid = dr["ids"].ToString();
                    if (strid == "")
                    {


                        txtleaveid.Text = "L00001";
                    }
                    else
                    {
                        strid = txtleaveid.Text;

                        string current = dr["ids"].ToString();// txtattid.Text;
                        string next = GetNextValue(current);

                        txtleaveid.Text = GetNextValue(current);

                    }

                }
                dr.Close();
                con.Close();
                cmddr.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        #endregion

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfind.Text == "")
                {
                    MessageBox.Show("First Finding Record ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    leave.LEAVEID = txtfind.Text;
                    //leave.APPDATE = DateTime.Parse(D1.Text);//Datetime.parse(D1.Text);
                    //leave.APPDATE = DateTime.Parse(D2.Text);
                    leavebal.Delete_leave(leave);
                    gridBind();
                    MessageBox.Show("Record Delete Successfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtfind.Text == "")
                {
                    MessageBox.Show("Please Enter LeveID ", "Finding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                String levID = txtfind.Text;

                DataSet ds = ldal.Find_Leave(levID);
                DataRow row;
                row = ds.Tables[0].Rows[0];

               

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    txtleaveid.Text=rows["Leave_Id"].ToString();
                    cmbemp.Text = rows["Emp_Id"].ToString();
                    dateTimePicker1.Text = rows["App_Date"].ToString();
                    dateTimePicker2.Text = rows["Res_Date"].ToString();
                    cmbtype.Text = rows["Type"].ToString();
                   
                }
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
                leave.LEAVEID = txtleaveid.Text;
                leave.EMPID = cmbemp.SelectedValue.ToString();
                leave.APPDATE = DateTime.Parse(dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm:ss"));
                leave.RESDATE = DateTime.Parse(dateTimePicker2.Value.ToString("MM/dd/yyyy HH:mm:ss"));
                leave.TYPE = cmbtype.Text;
                leavebal.Update_Leave(leave);

                gridBind();
                MessageBox.Show("Record Update Successfull", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                
            }
        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                leave.LEAVEID = txtfind.Text;
                dataGridView1.DataSource = ldal.GetData_DateRange(leave);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"GridLike Error");
            }
           
        }
    }
}
