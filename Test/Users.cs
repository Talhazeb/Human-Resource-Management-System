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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        Commoncls cls = new Commoncls();
        UserBAL ubal = new UserBAL();
        User_Details ude = new User_Details();
        UsersDAL udal = new UsersDAL();

        private void Find_UID()
        {
            try
            {

                ude.UID = txtuid.Text;
                ude.USERNAME = txtpassword.Text;
                udal.Find_UID(ude);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
          Find_UID();
            
            try
            {
                int insertrec = 0;
                ude.UID = txtuid.Text;
                ude.UEID = txtempid.Text;
                ude.USERNAME = txtusername.Text;
                ude.PASSWORD = txtpassword.Text;


                insertrec = ubal.Insert(ude);

                if (insertrec > 0)
                {
                    MessageBox.Show("Record Insert Successfull", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Already Insert!!!");
                }
            }
            catch (Exception ex)
            {

                ex.ToString();// MessageBox.Show(ex.ToString(), "Person Insert Error");
            }
            finally
            {
                
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtuid.Text = txtusername.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfind.Text == "")
                {
                    MessageBox.Show("Please Enter Valid User ID", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ude.UID = txtfind.Text;
                    ude.USERNAME = txtusername.Text;
                    ude.PASSWORD = txtpassword.Text;
                    ubal.Update(ude);
                    MessageBox.Show("Record Update Successfull", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Update error");
            }
            
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                String user = txtfind.Text;

                DataSet ds = ubal.Find_User(user);
                DataRow row;
                row = ds.Tables[0].Rows[0];

                MessageBox.Show(row["Username"].ToString());

              

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    txtuid.Text = rows["Login_id"].ToString();
                    txtempid.Text = rows["Emp_Id"].ToString();
                    txtusername.Text = rows["Username"].ToString();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        
    }
}
