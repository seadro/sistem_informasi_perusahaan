namespace Sistem_Informasi_Perusahaan
{
    partial class frmSuratSPGBReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSPGBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportSIP = new Sistem_Informasi_Perusahaan.ReportSIP();
            ((System.ComponentModel.ISupportInitialize)(this.DataSPGBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportSIP)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSPGB";
            reportDataSource1.Value = this.DataSPGBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistem_Informasi_Perusahaan.RPT.rptSuratSPGB.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(629, 363);
            this.reportViewer1.TabIndex = 1;
            // 
            // DataSPGBBindingSource
            // 
            this.DataSPGBBindingSource.DataMember = "DataSPGB";
            this.DataSPGBBindingSource.DataSource = this.ReportSIP;
            // 
            // ReportSIP
            // 
            this.ReportSIP.DataSetName = "ReportSIP";
            this.ReportSIP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmSuratSPGBReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 363);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSuratSPGBReport";
            this.Text = "SPGB Report";
            this.Load += new System.EventHandler(this.frmSuratSPGBReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSPGBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportSIP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataSPGBBindingSource;
        private ReportSIP ReportSIP;
    }
}