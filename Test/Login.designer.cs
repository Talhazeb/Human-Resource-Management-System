namespace Test
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpasswrd = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpwrd = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.header1 = new PhoneBook.UserControls.Header();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblusername.Location = new System.Drawing.Point(29, 66);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(59, 14);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            // 
            // lblpasswrd
            // 
            this.lblpasswrd.AutoSize = true;
            this.lblpasswrd.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswrd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblpasswrd.Location = new System.Drawing.Point(29, 106);
            this.lblpasswrd.Name = "lblpasswrd";
            this.lblpasswrd.Size = new System.Drawing.Size(57, 14);
            this.lblpasswrd.TabIndex = 1;
            this.lblpasswrd.Text = "Password";
            // 
            // txtuname
            // 
            this.txtuname.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(113, 63);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(206, 21);
            this.txtuname.TabIndex = 2;
            // 
            // txtpwrd
            // 
            this.txtpwrd.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwrd.Location = new System.Drawing.Point(113, 103);
            this.txtpwrd.Name = "txtpwrd";
            this.txtpwrd.Size = new System.Drawing.Size(206, 21);
            this.txtpwrd.TabIndex = 3;
            this.txtpwrd.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogin.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(113, 139);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(82, 27);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.toolTip1.SetToolTip(this.btnlogin, "Click To Login");
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(233, 139);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(82, 27);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnexit, "Exit the System");
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.White;
            this.header1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("header1.BackgroundImage")));
            this.header1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.header1.Description = "";
            this.header1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(337, 54);
            this.header1.TabIndex = 7;
            this.header1.Title = "User Login";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 178);
            this.ControlBox = false;
            this.Controls.Add(this.header1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpwrd);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.lblpasswrd);
            this.Controls.Add(this.lblusername);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.toolTip1.SetToolTip(this, "User Login");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpasswrd;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpwrd;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ToolTip toolTip1;
        private PhoneBook.UserControls.Header header1;
    }
}