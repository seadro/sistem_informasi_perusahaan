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

namespace Sistem_Informasi_Perusahaan
{
    public partial class frmClientOrderRecord : Form
    {
        public frmClientOrderRecord()
        {
            InitializeComponent();
            LoadRecord();
        }

        public void LoadRecord()
        {
            try
            {
                SQLConn.sqL = "SELECT cl_id, client_name, alamat, no_telp, email FROM client_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                listView1.Items.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["cl_id"].ToString());
                    x.SubItems.Add(SQLConn.dr["client_name"].ToString());
                    x.SubItems.Add(SQLConn.dr["alamat"].ToString());
                    x.SubItems.Add(SQLConn.dr["no_telp"].ToString());
                    x.SubItems.Add(SQLConn.dr["email"].ToString());
                    listView1.Items.Add(x);
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SQLConn.strSearch = Interaction.InputBox("Masukkan Nama Client.", "Search Client", "");

            if (SQLConn.strSearch.Length >= 1)
            {
                LoadRecords(SQLConn.strSearch.Trim());
            }
            else if (string.IsNullOrEmpty(SQLConn.strSearch))
            {
                return;
            }
        }

        public void LoadRecords(string search)
        {
            try
            {
                SQLConn.sqL = "SELECT cl_id, client_name, alamat, no_telp, email FROM client_project WHERE client_name LIKE '" + search.Trim() + "%' ORDER By client_name";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                listView1.Items.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["cl_id"].ToString());
                    x.SubItems.Add(SQLConn.dr["client_name"].ToString());
                    x.SubItems.Add(SQLConn.dr["alamat"].ToString());
                    x.SubItems.Add(SQLConn.dr["no_telp"].ToString());
                    x.SubItems.Add(SQLConn.dr["email"].ToString());
                  
                    listView1.Items.Add(x);
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

    }
}


