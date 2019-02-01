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
    public partial class frmCategoryOrderRecord : Form
    {
        public frmCategoryOrderRecord()
        {
            InitializeComponent();
        }

        private void frmCategoryProjectRecord_Load (object sender, EventArgs e)
        {
            LoadRecord();
        }

        public void LoadRecord()
        {
            try
            {
                SQLConn.sqL = "SELECT ct_id, project_category FROM category_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                listView1.Items.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["ct_id"].ToString());
                    x.SubItems.Add(SQLConn.dr["project_category"].ToString());
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
    }
}
