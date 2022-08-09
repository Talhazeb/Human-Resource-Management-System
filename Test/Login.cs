using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Test;

namespace Test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Get a coonection
        Commoncls cls = new Commoncls();

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT  Username, Password FROM Login  WHERE Username = @Username";

            using (SqlConnection conn = new SqlConnection(cls.setConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //add a parameter to sql query
                    cmd.Parameters.AddWithValue("Username", txtuname.Text);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //read the first row that reader returned and save password from DB into variable
                            reader.Read();
                            string username = reader["Username"].ToString();
                            string password = reader["Password"].ToString();
                            //string priviledgeLevel = reader["PriviledgeLvl"].ToString();
                           // string prv;
                            if (reader.Read() == true)
                            {

                                return;
                            }

                            else if (txtpwrd.Text == password)
                            {

                               
                                this.Visible = false;

                                MainMenu main = new MainMenu();
                                main.ShowDialog();
                              

                            }
                            else if (txtuname.Text != username || txtpwrd.Text != password)
                            {
                                MessageBox.Show("Password not Valid, Please TryAgain", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid Access Please TryAgain", "UserLogin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

    }

}
    

