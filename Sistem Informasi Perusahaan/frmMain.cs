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

namespace Sistem_Informasi_Perusahaan
{
    public partial class frmMain : Form
    {
        string Username;
        int pegawai_id;
        public frmMain(string username, int no_id)
        {
            InitializeComponent();
            Username = username;
            pegawai_id = no_id;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

     

        private void frmMain_Load(object sender, EventArgs e)
        {
            SQLConn.getData();
            this.lbluser.Text = "Login user : " + Username.ToUpper();
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = "Date-Time : " + DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

    
        private void picClose_Click_1(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Apakah Anda Akan Keluar Dari Aplikasi Ini?", MsgBoxStyle.YesNo, "Exit System") == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Apakah Anda Ingin Keluar Dari Aplikasi ini?", MsgBoxStyle.YesNo, "Exit System") == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frmLogin lg = new frmLogin();
            lg.Show();
        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStaff f1 = new frmListStaff();
            f1.ShowDialog();
        }

        private void laporanDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataStaffReport rptdtstaff = new frmDataStaffReport();
            rptdtstaff.Show();
        }

        private void konfigurasiDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatabaseConfig dbcfg = new frmDatabaseConfig();
            dbcfg.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void newProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNewOrder fnp = new frmNewOrder();
            fnp.Show();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetailProduct dp = new frmDetailProduct();
            dp.Show();
        }

        private void categoryRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoryOrderRecord cpr = new frmCategoryOrderRecord();
            cpr.Show();
        }

        private void clientRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientOrderRecord cr = new frmClientOrderRecord();
            cr.Show();
        }

        private void orderRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderRecord or = new frmOrderRecord();
            or.Show();
        }

        private void productRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetailProductRecord dpr = new frmDetailProductRecord();
            dpr.Show();
        }

        private void keyboardOnScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.exe");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.exe");
        }

        private void powerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("POWERPNT.exe");
        }

        private void stickyNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void commandPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe");
        }

        private void calculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void suratTandaTerimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuratSPGB buka = new frmSuratSPGB();
            buka.Show();
        }
    }
}
