namespace Test
{
    partial class ShortCutMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortCutMenu));
            this.i64x64 = new System.Windows.Forms.ImageList(this.components);
            this.lvShortcuts = new System.Windows.Forms.ListView();
            this.panelTOP = new System.Windows.Forms.Panel();
            this.wbInformation = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // i64x64
            // 
            this.i64x64.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i64x64.ImageStream")));
            this.i64x64.TransparentColor = System.Drawing.Color.Transparent;
            this.i64x64.Images.SetKeyName(0, "emp.png");
            this.i64x64.Images.SetKeyName(1, "");
            this.i64x64.Images.SetKeyName(2, "Dep.png");
            this.i64x64.Images.SetKeyName(3, "new.png");
            this.i64x64.Images.SetKeyName(4, "H.png");
            this.i64x64.Images.SetKeyName(5, "money.png");
            this.i64x64.Images.SetKeyName(6, "user2.png");
            this.i64x64.Images.SetKeyName(7, "Excel.png");
            this.i64x64.Images.SetKeyName(8, "www.png");
            this.i64x64.Images.SetKeyName(9, "dtb.png");
            this.i64x64.Images.SetKeyName(10, "exit");
            this.i64x64.Images.SetKeyName(11, "dbbb.png");
            this.i64x64.Images.SetKeyName(12, "file.png");
            this.i64x64.Images.SetKeyName(13, "dtb.png");
            this.i64x64.Images.SetKeyName(14, "windows.png");
            // 
            // lvShortcuts
            // 
            this.lvShortcuts.BackColor = System.Drawing.Color.White;
            this.lvShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvShortcuts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvShortcuts.Font = new System.Drawing.Font("Varela Round", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvShortcuts.ForeColor = System.Drawing.Color.Black;
            this.lvShortcuts.FullRowSelect = true;
            this.lvShortcuts.HideSelection = false;
            this.lvShortcuts.LargeImageList = this.i64x64;
            this.lvShortcuts.Location = new System.Drawing.Point(0, 71);
            this.lvShortcuts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvShortcuts.Name = "lvShortcuts";
            this.lvShortcuts.Size = new System.Drawing.Size(486, 266);
            this.lvShortcuts.TabIndex = 4;
            this.lvShortcuts.TileSize = new System.Drawing.Size(10, 100);
            this.lvShortcuts.UseCompatibleStateImageBehavior = false;
            this.lvShortcuts.SelectedIndexChanged += new System.EventHandler(this.lvShortcuts_SelectedIndexChanged);
            this.lvShortcuts.DoubleClick += new System.EventHandler(this.lvShortcuts_DoubleClick);
            // 
            // panelTOP
            // 
            this.panelTOP.Controls.Add(this.wbInformation);
            this.panelTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTOP.Location = new System.Drawing.Point(0, 0);
            this.panelTOP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTOP.Name = "panelTOP";
            this.panelTOP.Size = new System.Drawing.Size(486, 71);
            this.panelTOP.TabIndex = 3;
            // 
            // wbInformation
            // 
            this.wbInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.wbInformation.Location = new System.Drawing.Point(0, 0);
            this.wbInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wbInformation.MinimumSize = new System.Drawing.Size(23, 22);
            this.wbInformation.Name = "wbInformation";
            this.wbInformation.ScrollBarsEnabled = false;
            this.wbInformation.Size = new System.Drawing.Size(486, 39);
            this.wbInformation.TabIndex = 55;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShortCutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 337);
            this.ControlBox = false;
            this.Controls.Add(this.lvShortcuts);
            this.Controls.Add(this.panelTOP);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ShortCutMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SizeChanged += new System.EventHandler(this.ShortCutMenu_SizeChanged);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panelTOP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ImageList i64x64;
        private System.Windows.Forms.ListView lvShortcuts;
        private System.Windows.Forms.Panel panelTOP;
        private System.Windows.Forms.WebBrowser wbInformation;
        public System.Windows.Forms.Timer timer1;
    }
}