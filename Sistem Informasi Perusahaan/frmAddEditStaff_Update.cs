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
    public partial class frmAddEditStaff_Update : Form
    {
        int pegawai_id;
        public frmAddEditStaff_Update(int no_id)
        {

            InitializeComponent();
            pegawai_id = no_id;
        }

        protected override void WndProc(ref Message frmAddEditStaff_Update)
        {
            switch (frmAddEditStaff_Update.Msg)
            {
                case 0x84:
                    base.WndProc(ref frmAddEditStaff_Update);
                    if ((int)frmAddEditStaff_Update.Result == 0x1)
                        frmAddEditStaff_Update.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref frmAddEditStaff_Update);
        }

        private void button4_Click(object sender, EventArgs e)                           //button4 = "Cancel"
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)                          //button3 = "Save"
        {
            SQLConn.sqL = "SELECT no_id FROM staff WHERE no_id=@find";
            SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
            SQLConn.ConnDB();
            SQLConn.cmd.Parameters.Add(new MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.Int16, 5, "no_id"));
            SQLConn.cmd.Parameters["@find"].Value = txtno_id.Text;
            SQLConn.dr = SQLConn.cmd.ExecuteReader();
            if (SQLConn.dr.Read())
            {
                MessageBox.Show("Harap Masukkan No ID Yang Belum Terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtno_id.Text = "";
                txtno_id.Focus();

                if ((SQLConn.dr != null))
                {
                    SQLConn.dr.Close();
                }
                return;
            }

            if (SQLConn.adding == true)
            {
                AddStaff();
                
            }
            else
            {
                UpdateStaff();
            }

    
            if (System.Windows.Forms.Application.OpenForms["frmListStaff"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmListStaff"] as frmListStaff).LoadStaffs("");
            }

            this.Close();
        }

        private void GetStaffID()
        {
            try
            {
                SQLConn.sqL = "SELECT no_id FROM staff ORDER BY no_id DESC";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    txtno_id.Text = (Convert.ToInt32(SQLConn.dr["no_id"]) + 1).ToString();
                }
                else
                {
                    txtno_id.Text = "1";
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

        private void AddStaff()
        {
            try
            {
                SQLConn.sqL = "INSERT INTO staff(no_id, nama_lengkap, nama_panggilan, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, agama, status_pernikahan, no_kontak, email, pendidikan_terakhir, akademik, jurusan, posisi, tgl_masuk, username, password) VALUES('" + txtno_id.Text + "', '"
                            + txtnama_lengkap.Text + "', '" + txtnama_panggilan.Text + "', '" + cmbjenis_kelamin.Text + "', '" + txttempat_lahir.Text + "', '" + dtptanggal_lahir.Text 
                            + "', '" + txtalamat.Text + "', '" + cmbagama.Text + "', '" + cmbstatus_pernikahan.Text +"', '" + txtno_kontak.Text + "', '" + txtemail.Text 
                            + "', '" + txtpendidikan_terakhir.Text + "', '" + cmbakademik.Text + "', '" + txtjurusan.Text + "', '" + cmbposisi.Text +"', '" + dtptanggal_masuk.Text 
                            + "', '" + txtusername.Text + "', '" + txtpassword.Text + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                Interaction.MsgBox("Data Pegawai Telah Berhasil Ditambah", MsgBoxStyle.Information, "Tambah Pegawai");
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

        private void UpdateStaff()
        {
            try
            {

                SQLConn.sqL = "Update staff SET  nama_lengkap = '" + txtnama_lengkap.Text + "', nama_panggilan = '" + txtnama_panggilan.Text +
                               "', jenis_kelamin = '" + cmbjenis_kelamin.Text + "', tempat_lahir = '" + txttempat_lahir.Text + "', tanggal_lahir = '" + dtptanggal_lahir.Text + 
                               "', agama = '" + cmbagama.Text + "', status_pernikahan = '" + cmbstatus_pernikahan.Text + "', alamat = '" + txtalamat.Text + 
                               "', no_kontak = '" + txtno_kontak.Text + "', email = '" + txtemail.Text + "', pendidikan_terakhir = '" + txtpendidikan_terakhir.Text + "', akademik = '" + cmbakademik.Text +
                               "', jurusan = '" + txtjurusan.Text + "', tgl_masuk = '" + dtptanggal_masuk.Text + "', posisi = '" + cmbposisi.Text + 
                               "', username = '" +txtusername.Text + "', password = '" + txtpassword.Text + "' WHERE no_id = '" + pegawai_id + "'";

                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                Interaction.MsgBox("Data Pegawai Telah Di Update", MsgBoxStyle.Information, "Update Data Pegawai");

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

        private void LoadUpdateStaff()
        {
            try
            {
                SQLConn.sqL = "SELECT * FROM staff WHERE no_id = '" + pegawai_id + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    txtno_id.Text = SQLConn.dr["no_id"].ToString();
                    txtnama_lengkap.Text = SQLConn.dr["nama_lengkap"].ToString();
                    txtnama_panggilan.Text = SQLConn.dr["nama_panggilan"].ToString();
                    cmbjenis_kelamin.Text = SQLConn.dr["jenis_kelamin"].ToString();
                    txttempat_lahir.Text = SQLConn.dr["tempat_lahir"].ToString();
                    dtptanggal_lahir.Text = SQLConn.dr["tanggal_lahir"].ToString();
                    txtalamat.Text = SQLConn.dr["alamat"].ToString();
                    cmbagama.Text = SQLConn.dr["agama"].ToString();
                    cmbstatus_pernikahan.Text = SQLConn.dr["status_pernikahan"].ToString();
                    txtno_kontak.Text = SQLConn.dr["no_kontak"].ToString();
                    txtemail.Text = SQLConn.dr["email"].ToString();
                    txtpendidikan_terakhir.Text = SQLConn.dr["pendidikan_terakhir"].ToString();
                    txtjurusan.Text = SQLConn.dr["jurusan"].ToString();
                    cmbakademik.Text = SQLConn.dr["akademik"].ToString();
                    dtptanggal_masuk.Text = SQLConn.dr["tgl_masuk"].ToString();
                    cmbposisi.Text = SQLConn.dr["posisi"].ToString();
                    txtusername.Text = SQLConn.dr["username"].ToString();
                    txtpassword.Text = SQLConn.dr["password"].ToString();
                    txtconfirmpwd.Text = SQLConn.dr["password"].ToString();

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

        private void ClearFields()
        {
            txtno_id.Text = "";
            txtnama_lengkap.Text = "";
            txtnama_panggilan.Text = "";
            cmbjenis_kelamin.SelectedIndex = -1;
            txttempat_lahir.Text = "";
            txtalamat.Text = "";
            cmbagama.SelectedIndex = -1;
            cmbstatus_pernikahan.SelectedIndex = -1;
            txtno_kontak.Text = "";
            txtemail.Text = "";
            txtpendidikan_terakhir.Text = "";
            cmbakademik.SelectedIndex = -1;
            txtjurusan.Text = "";
            cmbposisi.SelectedIndex = -1;
            txtusername.Text = "";
            txtpassword.Text = "";
            txtconfirmpwd.Text = "";
        }

        private void frmAddEditStaff_Load(object sender, EventArgs e)
        {
            if (SQLConn.adding == true)
            {
                lblTitle.Text = "Menambah Pegawai Baru";
                ClearFields();
                GetStaffID();
            }
            else
            {
                lblTitle.Text = "Updating Pegawai";
                LoadUpdateStaff();

            }
        }

        private void txtNUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLETTER_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SQLConn.adding == true)
            {
                AddStaff();

            }
            else
            {
                UpdateStaff();
            }


            if (System.Windows.Forms.Application.OpenForms["frmListStaff"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmListStaff"] as frmListStaff).LoadStaffs("");
            }

            this.Close();
        }
    }
    }

