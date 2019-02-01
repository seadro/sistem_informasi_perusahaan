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
    public partial class frmOrderRecord : Form
    {
        public frmOrderRecord()
        {
            InitializeComponent();
        }

        public void LoadRecord()
        {
            try
            {
                SQLConn.sqL = "SELECT o_id ,(SELECT project_category FROM category_project WHERE ct_id = order_project.ct_id) AS Category, (SELECT client_name FROM client_project WHERE cl_id = order_project.cl_id) AS Client, nama_product, tanggal_dimulai FROM order_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                listView1.Items.Clear();


                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["o_id"].ToString());
                    x.SubItems.Add(SQLConn.dr["Category"].ToString());
                    x.SubItems.Add(SQLConn.dr["Client"].ToString());
                    x.SubItems.Add(SQLConn.dr["nama_product"].ToString());
                    x.SubItems.Add(SQLConn.dr["tanggal_dimulai"].ToString());

                    listView1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void txtrefresh_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void frmOrderRecord_Load(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(txtsearch.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
            LoadRecord();
        }
    }
    }

