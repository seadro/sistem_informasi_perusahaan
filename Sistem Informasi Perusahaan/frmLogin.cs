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

namespace Sistem_Informasi_Perusahaan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
       
            InitializeComponent();
        }

        protected override void WndProc(ref Message frmLogin)
        {
            switch (frmLogin.Msg)
            {
                case 0x84:
                    base.WndProc(ref frmLogin);
                    if ((int)frmLogin.Result == 0x1)
                        frmLogin.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref frmLogin);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            SQLConn.getData();

        }

        private void Login()
        {
            try
            {
                SQLConn.sqL = "SELECT * FROM staff WHERE username = '" + txtusername.Text + "' AND password = '" + txtPassword.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {

                    if (SQLConn.dr["posisi"].ToString().ToUpper() == "")
                    {
                        frmMain m = new frmMain(SQLConn.dr["username"].ToString(), Convert.ToInt32(SQLConn.dr["no_id"]));
                        m.Show();
                        this.Hide();
                    }

                    else if (SQLConn.dr["posisi"].ToString().ToUpper() == "ADMIN")
                    {
                        frmMain m = new frmMain(SQLConn.dr["username"].ToString(), Convert.ToInt32(SQLConn.dr["no_id"]));
                        m.Show();
                        this.Hide();
                    }

                    else if (SQLConn.dr["posisi"].ToString().ToUpper() == "AKUNTING")
                    {
                        frmMain m = new frmMain(SQLConn.dr["username"].ToString(), Convert.ToInt32(SQLConn.dr["no_id"]));
                        m.Show();
                        this.Hide();
                    }
                    else if (SQLConn.dr["posisi"].ToString().ToUpper() == "IT")
                    {
                        frmMain m = new frmMain(SQLConn.dr["username"].ToString(), Convert.ToInt32(SQLConn.dr["no_id"]));
                        m.Show();
                        this.Hide();
                    }
                    else if (SQLConn.dr["posisi"].ToString().ToUpper() == "KARYAWAN")
                    {
                        frmMain m = new frmMain(SQLConn.dr["username"].ToString(), Convert.ToInt32(SQLConn.dr["no_id"]));
                        m.Show();
                        this.Hide();
                    }
                    else if (SQLConn.dr["posisi"].ToString().ToUpper() == "MANAGEMENT PERPAJAKAN") 
                    {
                        frmMain m = new frmMain(SQLConn.dr["username"].ToString(), Convert.ToInt32(SQLConn.dr["no_id"]));
                        m.Show();
                        this.Hide();
                    }
                }
                else
                {
                    Interaction.MsgBox("Invalid Password. Please try again.", MsgBoxStyle.Exclamation, "Login");
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                frmDatabaseConfig dc = new frmDatabaseConfig();
                dc.ShowDialog();
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Login();
        }


    }
}
