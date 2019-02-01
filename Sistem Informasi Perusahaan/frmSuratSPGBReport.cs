using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using Microsoft.Reporting.WinForms;

namespace Sistem_Informasi_Perusahaan
{
    public partial class frmSuratSPGBReport : Form
    {
        public frmSuratSPGBReport()
        {
            InitializeComponent();
        }

        private void frmSuratSPGBReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                SQLConn.sqL = "SELECT no_surat, lampiran, perihal, tgl_dibuat, no_kontrak, tgl_kontrak, o_id FROM spgb";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.da = new MySqlDataAdapter(SQLConn.cmd);

                this.ReportSIP.DataSPGB.Clear();
                SQLConn.da.Fill(this.ReportSIP.DataSPGB);

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
