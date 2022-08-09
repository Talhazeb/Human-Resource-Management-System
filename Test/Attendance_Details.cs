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
    public partial class Attendance_Details : Form
    {
        Commoncls cls = new Commoncls();
       
       
        Atten_Details att_det = new Atten_Details();
        AttenBAL abal = new AttenBAL();

        public Attendance_Details()
        {
            InitializeComponent();
        }

        private void Attendance_Details_Load(object sender, EventArgs e)
        {
            Load_Combo();
            GridBind();
            new_ID();
           
        }

        private void Load_Combo()
        {
            cls.setComboList(this.cmbemp, "Select Emp_Id,Full_Name From Emp_Details Order By Emp_Id ASC", "Emp_Details", "Emp_Id", "Emp_Id");
        }

        private void GridBind()
        {
            dataGridView1.DataSource = abal.BindGrid();
        }


        private string GetNextValue(string s)
        {
            return String.Format("A{0:D5}", Convert.ToInt32(s.Substring(3)) + 1);
        }
        
        #region ID
        private void new_ID()
        {
            try
            {
                          
                SqlConnection con = new SqlConnection(cls.setConnectionString());
                con.Open();
                SqlCommand cmddr = new SqlCommand("select max(Att_Id) as ids from Att_Details",con );
                SqlDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {
                    string strid = dr["ids"].ToString();
                    if (strid == "")
                    {

                        
                        txtattid.Text = "A00001";
                    }
                    else
                    {
                        strid = txtattid.Text;

                        string current = dr["ids"].ToString();// txtattid.Text;
                        string next = GetNextValue(current);
                       
                        txtattid.Text = GetNextValue(current);
                        
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

        private void btnadd_Click(object sender, EventArgs e)
        {
           

            new_ID();

            int insertrec = 0;
            try
            {

                att_det.ATTID = txtattid.Text;
                att_det.EMPID = cmbemp.SelectedValue.ToString();
                att_det.DATETIME = DateTime.Parse(dateTimePicker1.Value.ToLongTimeString());
                att_det.STATUS = cmbsta.Text;


                insertrec = abal.Insert(att_det);
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
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString(), "Insert Error");
            }
            finally
            {

            }


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtattid.Text = "";
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                att_det.ATTID = txtattid.Text;
                abal.Delete_leave(att_det);
                MessageBox.Show("Record Delete Successfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridBind();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Delete Error");
            }
           
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtattid.Text = "";

        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                String AtID = txtfind.Text;

                DataSet ds = abal.Find_Attdet(AtID);
                DataRow row;
                row = ds.Tables[0].Rows[0];

                MessageBox.Show(row["Full_Name"].ToString());

              

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    txtattid.Text = rows["Att_Id"].ToString();
                    cmbemp.Text = rows["Emp_Id"].ToString();
                    dateTimePicker1.Text = rows["Date_Time"].ToString();
                    cmbsta.Text = rows["Status"].ToString();


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
                if(txtfind.Text=="")
                {
                    MessageBox.Show("You Must Find Attendance ID", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
                }
                else
                {

                att_det.ATTID = txtfind.Text;
                att_det.EMPID = cmbemp.SelectedValue.ToString();
                att_det.DATETIME = DateTime.Parse(dateTimePicker1.Value.ToLongDateString());
                att_det.STATUS = cmbsta.Text.ToString();
                abal.Upate_Att(att_det);
                GridBind();
                MessageBox.Show("Record Update Successfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Update Error");
            }
        }

        private void header1_Load(object sender, EventArgs e)
        {

        }
    }
}
