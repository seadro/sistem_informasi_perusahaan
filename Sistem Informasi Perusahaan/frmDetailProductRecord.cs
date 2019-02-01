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
    public partial class frmDetailProductRecord : Form
    {
        public frmDetailProductRecord()
        {
            InitializeComponent();
        }

        private void frmDetailProductRecord_Load(object sender, EventArgs e)
        {
            loadrecord();
        }

        private void loadrecord()
        {
            try
            {
                SQLConn.sqL = "SELECT o_id, no,(SELECT client_name FROM client_project WHERE cl_id = detail_product.cl_id) AS Client, (SELECT nama_product FROM order_project WHERE o_id = detail_product.o_id) AS Product, nama_barang, jumlah, satuan, harga_satuan, jumlah_harga, (SELECT project_category FROM category_project WHERE ct_id = detail_product.ct_id) AS Category, (SELECT tanggal_dimulai FROM order_project WHERE o_id = detail_product.o_id) AS Tanggal FROM detail_product";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                listView1.Items.Clear();


                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["o_id"].ToString());
                    x.SubItems.Add(SQLConn.dr["no"].ToString());
                    x.SubItems.Add(SQLConn.dr["Client"].ToString());
                    x.SubItems.Add(SQLConn.dr["Product"].ToString());
                    x.SubItems.Add(SQLConn.dr["nama_barang"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["jumlah"], "#,##0".ToString()));
                    x.SubItems.Add(SQLConn.dr["satuan"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["harga_satuan"], "#,##0".ToString()));
                    x.SubItems.Add(Strings.Format(SQLConn.dr["jumlah_harga"], "#,##0".ToString()));
                    x.SubItems.Add(SQLConn.dr["Category"].ToString());
                    x.SubItems.Add(SQLConn.dr["Tanggal"].ToString());

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
            loadrecord();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
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
                loadrecord();
        }
    }
}
