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
    public partial class DepartmentDetails : Form
    {
       
        Commoncls cls = new Commoncls();
        Department_Details Dpm = new Department_Details();
       
        DepartmentBL bal = new DepartmentBL();

        public DepartmentDetails()
        {
            InitializeComponent();
        }

        public static DepartmentDetails publicPostalCodes;

        private void button1_Click(object sender, EventArgs e)
        {
           
           
           
        }
        
        private void DepartmentDetails_Load(object sender, EventArgs e)
        {
            Load_combo();
            publicPostalCodes = this;
            GridView1.DataSource = bal.Bind_Grid();
        }

        private void DepartmentDetails_Resize(object sender, EventArgs e)
        {
            ControlBox = false;
        }


        private void FindID()
        {
            try
            {
               
                Dpm.DEPID = txtdepid.Text;
                bal.Find_DID(Dpm);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            FindID();
            int insertrec = 0;
            try
            {
                if (txtdepid.Text == "")
                {
                    MessageBox.Show("Department ID Cannot Be Blank ", "Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Dpm.DEPID = txtdepid.Text;
                    Dpm.DepName = txtdepname.Text;
                    Dpm.DepHead = txtdephead.Text;
                    Dpm.DSC = txtdepdsc.Text;
                    insertrec = bal.Insert(Dpm);
                    GridView1.DataSource = bal.Bind_Grid();
                    Load_combo();
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
            ClearText();
        }
        private void ClearText()
        {
            txtdepdsc.Text = txtdephead.Text = txtdepid.Text = txtdepname.Text = "";

        }
        private void Load_combo()
        {
            cls.setComboList(cmbfind, "Select Dep_Name From Dep_Details Order By Dep_Id ASC", "Dep_Details", "Dep_Name", "Dep_Name");
        }

        private void GridBind()
        {
            try
            {
                Dpm.DepName = cmbfind.Text;
                GridView1.DataSource = bal.Bind_Grid_with(Dpm);
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }
        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                String depID = cmbfind.Text;
              
                DataSet ds = bal.Find_Depdet(depID);
                DataRow row;
                row = ds.Tables[0].Rows[0];

                MessageBox.Show(row["Dep_Name"].ToString());

                GridBind();

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                   
                    txtdepid.Text=rows["Dep_Id"].ToString();
                    txtdepname.Text = rows["Dep_Name"].ToString();
                    txtdephead.Text=rows["Dep_Head"].ToString();
                    txtdepdsc.Text = rows["Dep_Description"].ToString();
                   
                   
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

                Dpm.DEPID = txtdepid.Text;
                Dpm.DepName = txtdepname.Text;
                Dpm.DepHead = txtdephead.Text;
                Dpm.DSC = txtdepdsc.Text;
                bal.Update_Dep(Dpm);
                
                MessageBox.Show("Record Update Successfull", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GridView1.DataSource = bal.Bind_Grid();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
              
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
            try
            {
                Dpm.DEPID = txtdepid.Text;
                bal.Delete_Dep(Dpm);
                
                MessageBox.Show("Delete Successful", "Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridView1.DataSource = bal.Bind_Grid();
                Load_combo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Delete Error");
            }
            
        }
        }
    }

