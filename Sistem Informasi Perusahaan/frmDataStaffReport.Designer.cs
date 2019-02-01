namespace Sistem_Informasi_Perusahaan
{
    partial class frmDataStaffReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataStaffReport));
            this.DataStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportSIP = new Sistem_Informasi_Perusahaan.ReportSIP();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportSIP)).BeginInit();
            this.SuspendLayout();
            // 
            // DataStaffBindingSource
            // 
            this.DataStaffBindingSource.DataMember = "DataStaff";
            this.DataStaffBindingSource.DataSource = this.ReportSIP;
            // 
            // ReportSIP
            // 
            this.ReportSIP.DataSetName = "ReportSIP";
            this.ReportSIP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rptDataStaff";
            reportDataSource1.Value = this.DataStaffBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistem_Informasi_Perusahaan.RPT.rptDataStaff.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(653, 454);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmDataStaffReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 454);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDataStaffReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Pegawai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportDataStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportSIP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public ReportSIP ReportSIP;
        public System.Windows.Forms.BindingSource DataStaffBindingSource;
    }
}