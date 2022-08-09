namespace Test
{
    partial class Employee_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Details));
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.txtbisnum = new System.Windows.Forms.TextBox();
            this.txthomenum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdesig = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbconf = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbsta = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncloase = new System.Windows.Forms.Button();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.header1 = new PhoneBook.UserControls.Header();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb1
            // 
            this.cmb1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(129, 93);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(164, 22);
            this.cmb1.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(637, 65);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(81, 31);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(129, 65);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(164, 21);
            this.txtempid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(129, 122);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(164, 21);
            this.txtfname.TabIndex = 4;
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(129, 150);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(164, 21);
            this.txtlname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(129, 203);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(164, 22);
            this.cbgender.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 21);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "NIC";
            // 
            // txtnic
            // 
            this.txtnic.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic.Location = new System.Drawing.Point(129, 243);
            this.txtnic.MaxLength = 10;
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(164, 21);
            this.txtnic.TabIndex = 9;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(455, 66);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(164, 47);
            this.txtaddress.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address";
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(455, 121);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(164, 21);
            this.txtcity.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "City";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtcountry
            // 
            this.txtcountry.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcountry.Location = new System.Drawing.Point(455, 149);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(164, 21);
            this.txtcountry.TabIndex = 12;
            // 
            // txtbisnum
            // 
            this.txtbisnum.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbisnum.Location = new System.Drawing.Point(455, 177);
            this.txtbisnum.Name = "txtbisnum";
            this.txtbisnum.Size = new System.Drawing.Size(164, 21);
            this.txtbisnum.TabIndex = 13;
            // 
            // txthomenum
            // 
            this.txthomenum.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthomenum.Location = new System.Drawing.Point(455, 205);
            this.txthomenum.Name = "txthomenum";
            this.txthomenum.Size = new System.Drawing.Size(164, 21);
            this.txthomenum.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "Country";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(333, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 14);
            this.label11.TabIndex = 24;
            this.label11.Text = "Business Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(333, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Home Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdesig);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtnote);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmbconf);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbsta);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtfullname);
            this.groupBox1.Controls.Add(this.txtnic);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 310);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtdesig
            // 
            this.txtdesig.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesig.Location = new System.Drawing.Point(455, 213);
            this.txtdesig.Name = "txtdesig";
            this.txtdesig.Size = new System.Drawing.Size(164, 21);
            this.txtdesig.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(333, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 14);
            this.label18.TabIndex = 28;
            this.label18.Text = "Designation";
            // 
            // txtnote
            // 
            this.txtnote.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnote.Location = new System.Drawing.Point(455, 185);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(164, 21);
            this.txtnote.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(333, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 14);
            this.label17.TabIndex = 26;
            this.label17.Text = "Basic Salary";
            // 
            // cmbconf
            // 
            this.cmbconf.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbconf.FormattingEnabled = true;
            this.cmbconf.Items.AddRange(new object[] {
            "Permanent",
            "Contract",
            "Temporary "});
            this.cmbconf.Location = new System.Drawing.Point(129, 272);
            this.cmbconf.Name = "cmbconf";
            this.cmbconf.Size = new System.Drawing.Size(164, 22);
            this.cmbconf.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 14);
            this.label16.TabIndex = 17;
            this.label16.Text = "Confirmation";
            // 
            // cmbsta
            // 
            this.cmbsta.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsta.FormattingEnabled = true;
            this.cmbsta.Items.AddRange(new object[] {
            "Married",
            "Unmarried"});
            this.cmbsta.Location = new System.Drawing.Point(129, 184);
            this.cmbsta.Name = "cmbsta";
            this.cmbsta.Size = new System.Drawing.Size(164, 22);
            this.cmbsta.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 14);
            this.label15.TabIndex = 15;
            this.label15.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtfind);
            this.groupBox2.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(336, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FIND";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "EMP NIC";
            // 
            // txtfind
            // 
            this.txtfind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfind.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfind.Location = new System.Drawing.Point(119, 25);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(158, 21);
            this.txtfind.TabIndex = 0;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "Name with Initials";
            // 
            // txtfullname
            // 
            this.txtfullname.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.Location = new System.Drawing.Point(129, 128);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(164, 21);
            this.txtfullname.TabIndex = 1;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Silver;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(637, 209);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(81, 31);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncloase
            // 
            this.btncloase.BackColor = System.Drawing.Color.Silver;
            this.btncloase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloase.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloase.Location = new System.Drawing.Point(637, 245);
            this.btncloase.Name = "btncloase";
            this.btncloase.Size = new System.Drawing.Size(81, 31);
            this.btncloase.TabIndex = 19;
            this.btncloase.Text = "CLOSE";
            this.btncloase.UseVisualStyleBackColor = false;
            this.btncloase.Click += new System.EventHandler(this.btncloase_Click);
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(12, 365);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(698, 126);
            this.GridView1.TabIndex = 29;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Silver;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(637, 173);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(81, 31);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Silver;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(637, 101);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(81, 31);
            this.btnfind.TabIndex = 16;
            this.btnfind.Text = "FIND";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
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
            this.header1.Size = new System.Drawing.Size(722, 54);
            this.header1.TabIndex = 0;
            this.header1.Title = "Employee Data";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(637, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.btncloase);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txthomenum);
            this.Controls.Add(this.txtbisnum);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee_Details";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Employee_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhoneBook.UserControls.Header header1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.TextBox txtbisnum;
        private System.Windows.Forms.TextBox txthomenum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncloase;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbsta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbconf;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtdesig;
        private System.Windows.Forms.Label label18;
    }
}