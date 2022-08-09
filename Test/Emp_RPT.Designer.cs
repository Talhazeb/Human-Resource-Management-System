namespace Test
{
    partial class Emp_RPT
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Emp_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HRMS_DBDataSet = new Test.HRMS_DBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Emp_DetailsTableAdapter = new Test.HRMS_DBDataSetTableAdapters.Emp_DetailsTableAdapter();
            this.txtEmpid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRMS_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Emp_DetailsBindingSource
            // 
            this.Emp_DetailsBindingSource.DataMember = "Emp_Details";
            this.Emp_DetailsBindingSource.DataSource = this.HRMS_DBDataSet;
            // 
            // HRMS_DBDataSet
            // 
            this.HRMS_DBDataSet.DataSetName = "HRMS_DBDataSet";
            this.HRMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Emp_DetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test.Emp_Rpt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 41);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // Emp_DetailsTableAdapter
            // 
            this.Emp_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // txtEmpid
            // 
            this.txtEmpid.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpid.Location = new System.Drawing.Point(356, 13);
            this.txtEmpid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.Size = new System.Drawing.Size(177, 21);
            this.txtEmpid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(540, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID";
            // 
            // Emp_RPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEmpid);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Emp_RPT";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Emp_RPT_FormClosing);
            this.Load += new System.EventHandler(this.Emp_RPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Emp_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRMS_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Emp_DetailsBindingSource;
        private HRMS_DBDataSet HRMS_DBDataSet;
        private HRMS_DBDataSetTableAdapters.Emp_DetailsTableAdapter Emp_DetailsTableAdapter;
        private System.Windows.Forms.TextBox txtEmpid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}