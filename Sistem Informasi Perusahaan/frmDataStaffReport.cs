using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace Sistem_Informasi_Perusahaan
{
    public partial class frmDataStaffReport : Form
    {

        public frmDataStaffReport()
        {
            InitializeComponent();
        }

        private void frmReportDataStaff_Load(object sender, EventArgs e)
        {

            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                SQLConn.sqL = "SELECT no_id, nama_lengkap, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, agama, status_pernikahan, no_kontak, email, posisi FROM staff";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.da = new MySqlDataAdapter(SQLConn.cmd);

                this.ReportSIP.DataStaff.Clear();
                SQLConn.da.Fill(this.ReportSIP.DataStaff);

                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.ZoomPercent = 90;
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
        }
    }
}
