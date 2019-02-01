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
    public partial class frmListStaff : Form
    {
        public int no_id;

        public frmListStaff()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message frmListStaff)
        {
            switch (frmListStaff.Msg)
            {
                case 0x84:
                    base.WndProc(ref frmListStaff);
                    if ((int)frmListStaff.Result == 0x1)
                        frmListStaff.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref frmListStaff);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStaffs("");
        }


        private void button4_Click(object sender, EventArgs e)   //button4 = "DELETE"
        {
            if (ListView1.Items.Count == 0)
            {
                Interaction.MsgBox("Harap Pilih Data Yang Akan Di Hapus", MsgBoxStyle.Exclamation, "Delete");
                return;
            }
          
            else
            {
                if (MessageBox.Show("Apakah anda akan menghapus data?", "Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 {
                    DeleteStaff();
                 }
            }
        }

        public void DeleteStaff()
        {

            try
            {
                txtno_id.Enabled = false;
                txtno_id.Text = ListView1.FocusedItem.Text;

                SQLConn.sqL = "DELETE FROM staff WHERE no_id='" + this.txtno_id.Text + "';";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                MessageBox.Show("Data Pegawai Berhasil Di Hapus","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);               
                LoadStaffs("");
                

            }
            catch (Exception)
            {
                MessageBox.Show("Harap Pilih Data Yang Akan Di Hapus", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        

        private void button1_Click(object sender, EventArgs e)    // button1 = "NEW"
        {
            SQLConn.adding = true;
            SQLConn.updating = false;
            int init = 0;
            frmAddEditStaff f2 = new frmAddEditStaff(init);
            f2.ShowDialog();
        }


        public void LoadStaffs(string search)
        {
            try
            {
                SQLConn.sqL = "SELECT no_id, nama_lengkap, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, agama, status_pernikahan, no_kontak, email, posisi, username FROM staff WHERE nama_lengkap LIKE '" + search.Trim() + "%' ORDER By nama_lengkap";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                ListView1.Items.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["no_id"].ToString());
                    x.SubItems.Add(SQLConn.dr["nama_lengkap"].ToString());
                    x.SubItems.Add(SQLConn.dr["jenis_kelamin"].ToString());
                    x.SubItems.Add(SQLConn.dr["tempat_lahir"].ToString());
                    x.SubItems.Add(SQLConn.dr["tanggal_lahir"].ToString());
                    x.SubItems.Add(SQLConn.dr["alamat"].ToString());
                    x.SubItems.Add(SQLConn.dr["agama"].ToString());
                    x.SubItems.Add(SQLConn.dr["status_pernikahan"].ToString());
                    x.SubItems.Add(SQLConn.dr["no_kontak"].ToString());
                    x.SubItems.Add(SQLConn.dr["email"].ToString());
                    x.SubItems.Add(SQLConn.dr["posisi"].ToString());
                    x.SubItems.Add(SQLConn.dr["username"].ToString());

                    ListView1.Items.Add(x);
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

        private void button2_Click(object sender, EventArgs e)       // button2 = "UPDATE"
        {
            if (ListView1.Items.Count == 0)
            {
                Interaction.MsgBox("Harap Pilih Data Yang Akan Di Update", MsgBoxStyle.Exclamation, "Update");
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(ListView1.FocusedItem.Text))
                {

                }
                else
                {
                    SQLConn.adding = false;
                    SQLConn.updating = true;
                    no_id = Convert.ToInt32(ListView1.FocusedItem.Text);
                    frmAddEditStaff_Update f2 = new frmAddEditStaff_Update(no_id);
                    f2.ShowDialog();
                }
            }
            catch
            {
                Interaction.MsgBox("Harap Pilih Data Yang Akan Di Update", MsgBoxStyle.Exclamation, "Update");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)      // button3 = "SEARCH"
        {

            SQLConn.strSearch = Interaction.InputBox("Masukkan Nama Staff.", "Search Staff", " ");

            if (SQLConn.strSearch.Length >= 1)
            {
                LoadStaffs(SQLConn.strSearch.Trim());
            }
            else if (string.IsNullOrEmpty(SQLConn.strSearch))
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDataStaffReport rpt = new frmDataStaffReport();
            rpt.Show();
        }
    }
}
