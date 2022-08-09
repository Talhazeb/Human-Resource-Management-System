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
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }
        int age;
        Commoncls cls = new Commoncls();
        Person persond = new Person();
      
        PersonBAL pbal = new PersonBAL();

        private void Employee_Details_Load(object sender, EventArgs e)
        {

            #region screen
            int x = Screen.GetWorkingArea(this).Width;//1024
            int y = Screen.GetWorkingArea(this).Height;//768
            this.Location = new Point(x - 100 - this.Size.Width, 150);
            #endregion
            Load_combo();
            GridView1.DataSource = pbal.Bind_Getdata();

        }

        private void FinindID()
        {
            try
            {
               
                persond.EMPID = txtempid.Text;
              
                pbal.Find(persond);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Load_combo()
        {
            cls.setComboList(cmb1, "Select Dep_Id,Dep_Name From Dep_Details Order By Dep_Id ASC", "Dep_Details", "Dep_Name", "Dep_Id");       
        }

        private void GridBind()
        {
            try
            {
                persond.NIC = txtfind.Text;
                GridView1.DataSource = pbal.Bind_Getdata_with(persond);
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }

        private void age_find()
        {
            DateTime bday;
            bday = DateTime.Parse(dateTimePicker1.Text);
            DateTime now = DateTime.Today;
             age = now.Year - bday.Year;
            if (bday > now.AddYears(-age)) age--;
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            age_find();

            FinindID();


            int insertrec = 0;
            try
            {
                if (txtempid.Text == "")
                {
                    MessageBox.Show("Employee ID Cannot Be Blank", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    persond.EMPID = txtempid.Text;
                    persond.DEPID = cmb1.SelectedValue.ToString();
                    persond.FIRSTNAME = txtfname.Text;
                    persond.LASTNAME = txtlname.Text;
                    persond.FULLNAME = txtfullname.Text;
                    persond.SEX = cbgender.Text;
                    persond.CONFIRM = cmbconf.Text;
                    persond.AGE = int.Parse(age.ToString());
                    persond.DOB = DateTime.Parse(dateTimePicker1.Text);
                    persond.NIC = txtnic.Text;
                    persond.MSTATUS = cmbsta.Text;
                    persond.ADDRESS = txtaddress.Text;
                    persond.CITY = txtcity.Text;
                    persond.COUNTRY = txtcountry.Text;
                    persond.BUSNUMBER = txtbisnum.Text;
                    persond.HOMENUMBER = txthomenum.Text;
                    persond.BASIC = txtnote.Text;
                    persond.DESIGNATION = txtdesig.Text;


                    insertrec = pbal.Insert(persond);

                    GridView1.DataSource = pbal.Bind_Getdata();
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

                ee.ToString();
            }
            finally
            {
               
            }


            
            
           
        }
        
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btncloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls)
            {
                if (X is TextBox)
                    X.Text = " ";

            }
            txtfullname.Text = "";
            txtnote.Text = "";
            txtnic.Text = "";

        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            GridBind();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                persond.NIC = txtfind.Text;
                pbal.Delete_Per(persond);
                MessageBox.Show("Record Delete Successfull", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridView1.DataSource = pbal.Bind_Getdata();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Delete Error");
            }
            
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                String nic = txtfind.Text;

                DataSet ds = pbal.Find_Emp(nic);
                DataRow row;
                row = ds.Tables[0].Rows[0];

                MessageBox.Show(row["NIC"].ToString());

              //  GridBind();

                foreach (DataRow rows in ds.Tables[0].Rows)
                {

                     txtempid.Text=rows["Emp_Id"].ToString();
                     cmb1.Text = rows["Dep_Name"].ToString();
                     txtfname.Text = rows["First_Name"].ToString();
                     txtlname.Text = rows["Last_Name"].ToString();
                     txtfullname.Text = rows["Full_Name"].ToString();
                     cbgender.Text = rows["Sex"].ToString();
                     cmbsta.Text = rows["M_Sta"].ToString();//
                     dateTimePicker1.Text = rows["D_O_Birth"].ToString();
                     txtnic.Text = rows["NIC"].ToString();
                     cmbconf.Text = rows["Confirmation"].ToString();//
                     txtaddress.Text = rows["Address"].ToString();
                     txtcity.Text = rows["City"].ToString();
                     txtcountry.Text = rows["Country"].ToString();
                     txtbisnum.Text = rows["Business_Number"].ToString();
                     txthomenum.Text = rows["Home_Number"].ToString();

                     txtnote.Text = rows["Basic_sal"].ToString();//
                     txtdesig.Text = rows["Designation"].ToString();
                    



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            age_find();

            try
            {
                persond.EMPID = txtempid.Text;
                persond.NIC = txtfind.Text;
                persond.DEPID = cmb1.SelectedValue.ToString();
                persond.FIRSTNAME = txtfname.Text;
                persond.LASTNAME = txtlname.Text;
                persond.FULLNAME = txtfullname.Text;
                persond.SEX = cbgender.Text;
                persond.AGE = int.Parse(age.ToString());
                persond.DOB = DateTime.Parse(dateTimePicker1.Text);
                persond.ADDRESS = txtaddress.Text;
                persond.CITY = txtcity.Text;
                persond.COUNTRY = txtcountry.Text;
                persond.BUSNUMBER = txtbisnum.Text;

                persond.CONFIRM = cmbconf.Text;
                persond.MSTATUS = cmbsta.Text;
                persond.BASIC = txtnote.Text;
                persond.DESIGNATION = txtdesig.Text;

                pbal.Update_P(persond);
                MessageBox.Show("Record Updated Successfull", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridView1.DataSource = pbal.Bind_Getdata();
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
