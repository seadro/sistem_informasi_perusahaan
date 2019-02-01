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
using System.Globalization;


namespace Sistem_Informasi_Perusahaan
{
    public partial class frmDetailProduct : Form
    {
        public frmDetailProduct()
        {
            InitializeComponent();
        }

        private void frmDetailProduct_Load(object sender, EventArgs e)
        {
            LoadRecord();
            cmbo_id();
          
        }

        private void cmbo_id()
        {
            try
            {
                SQLConn.sqL = "SELECT o_id FROM order_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                while (SQLConn.dr.Read())
                {
                    cmboid.Items.Add(SQLConn.dr[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            cmboid.SelectedIndex = -1;
        }


        private void btnlihatoid_Click(object sender, EventArgs e)
        {
            frmOrderRecord or = new frmOrderRecord();
            if (Application.OpenForms.OfType<frmOrderRecord>().Any())
            {
                Application.OpenForms.OfType<frmOrderRecord>().First().Close();
                or.Show();
            }
            else
            {
                or.Show();
            }
        }

        private void cmboid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLConn.sqL = "SELECT o_id, (SELECT project_category FROM category_project WHERE ct_id = order_project.ct_id) AS Category, (SELECT client_name FROM client_project WHERE cl_id = order_project.cl_id) AS Client, nama_product, ct_id, cl_id FROM order_project WHERE o_id='" + cmboid.Text + "';";
            SQLConn.ConnDB();
            SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
            SQLConn.dr = SQLConn.cmd.ExecuteReader();
            try
            {
                while (SQLConn.dr.Read())
                {
                    string sct_id = SQLConn.dr["Category"].ToString();
                    txtct.Text = sct_id;
                    string scl_id = SQLConn.dr["Client"].ToString();
                    txtcl.Text = scl_id;
                    string n_p = SQLConn.dr["nama_product"].ToString();
                    txtnp.Text = n_p;
                    string ctid = SQLConn.dr["ct_id"].ToString();
                    txtctid.Text = ctid;
                    string clid= SQLConn.dr["cl_id"].ToString();
                    txtclid.Text = clid;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno1.Text))                           //cmbid + no urut = o_id_no
                txtoidno1.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno1.Text));

            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno2.Text))
                txtoidno2.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno2.Text));

            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno3.Text))
                txtoidno3.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno3.Text));

            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno4.Text))
                txtoidno4.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno4.Text));

            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno5.Text))
                txtoidno5.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno5.Text));
        }

        private void cb1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                cb2.Enabled = true;
                gpb1.Enabled = true;
            }
            else
            {
                cb2.Enabled = false;
                gpb1.Enabled = false;
                txtnb1.Text = "";
                txtj1.Text = "";
                txts1.Text = "";
                txths1.Text = "";
                txtjh1.Text = "";
                txtno1.Text = "";
                txtoidno1.Text = "";
            }
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                gpb1.Enabled = false;
                cb1.Enabled = false;
                gpb2.Enabled = true;
                cb3.Enabled = true;

            }
            else
            {
                gpb1.Enabled = true;
                cb1.Enabled = true;
                gpb2.Enabled = false;
                cb3.Enabled = false;
                txtnb2.Text = "";
                txtj2.Text = "";
                txts2.Text = "";
                txths2.Text = "";
                txtjh2.Text = "";
                txtno2.Text = "";
                txtoidno2.Text = "";
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked)
            {
                gpb2.Enabled = false;
                cb2.Enabled = false;
                gpb3.Enabled = true;
                cb4.Enabled = true;
            }
            else
            {
                gpb2.Enabled = true;
                cb2.Enabled = true;
                gpb3.Enabled = false;
                cb4.Enabled = false;
                txtnb3.Text = "";
                txtj3.Text = "";
                txts3.Text = "";
                txths3.Text = "";
                txtjh3.Text = "";
                txtno3.Text = "";
                txtoidno3.Text = "";
            }
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4.Checked)
            {
                gpb3.Enabled = false;
                cb3.Enabled = false;
                gpb4.Enabled = true;
                cb5.Enabled = true;
            }
            else
            {
                gpb3.Enabled = true;
                cb3.Enabled = true;
                gpb4.Enabled = false;
                cb5.Enabled = false;
                txtnb4.Text = "";
                txtj4.Text = "";
                txts4.Text = "";
                txths4.Text = "";
                txtjh4.Text = "";
                txtno4.Text = "";
                txtoidno4.Text = "";
            }
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5.Checked)
            {
                gpb4.Enabled = false;
                cb4.Enabled = false;
                gpb5.Enabled = true;
            }
            else
            {
                gpb4.Enabled = true;
                cb4.Enabled = true;
                gpb5.Enabled = false;
                txtnb5.Text = "";
                txtj5.Text = "";
                txts5.Text = "";
                txths5.Text = "";
                txtjh5.Text = "";
                txtno5.Text = "";
                txtoidno5.Text = "";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            frmDetailProduct or = new frmDetailProduct();
            if (Application.OpenForms.OfType<frmDetailProduct>().Any())
            {
                Application.OpenForms.OfType<frmDetailProduct>().First().Close();
                or.Show();
            }
            else
            {

                or.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmboid.SelectedIndex == -1)
                {
                    MessageBox.Show("Harap Pilih Order ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmboid.Focus();
                    return;
                }

             
                string[] oidno = new string[5];
                oidno[0] = txtoidno1.Text;
                oidno[1] = txtoidno2.Text;
                oidno[2] = txtoidno3.Text;
                oidno[3] = txtoidno4.Text;
                oidno[4] = txtoidno5.Text;

                SQLConn.sqL = "SELECT o_id_no FROM detail_product WHERE o_id_no=@find";
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.ConnDB();
                SQLConn.cmd.Parameters.Add(new MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 15, "o_id_no"));
                for (int i=0; i<5; i +=1)
                {
                    SQLConn.cmd.Parameters["@find"].Value = oidno[i];
                    SQLConn.dr = SQLConn.cmd.ExecuteReader();
                    break;
                }
               
                if (SQLConn.dr.Read())
                {
                    MessageBox.Show("Harap Masukkan No Yang Belum Terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Focus();

                    if ((SQLConn.dr != null))
                    {
                        SQLConn.dr.Close();
                    }
                    return;
                }


                if (cb1.Checked == true)
                {
                    if (txtno1.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "INSERT INTO detail_product(o_id_no, no, o_id, nama_barang, jumlah, satuan, harga_satuan, jumlah_harga, ct_id, cl_id) VALUES ('" + txtoidno1.Text + "', '" + txtno1.Text + "', '" + cmboid.Text + "','" + txtnb1.Text + "','" + txtj1.Text + "', '" + txts1.Text + "', '" + txths1.Text + "', '" + txtjh1.Text + "', '" + txtctid.Text + "', '" + txtclid.Text + "')";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.dr = SQLConn.cmd.ExecuteReader();
                    }
                }


                if (cb2.Checked == true)
                {
                    if (txtno2.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "INSERT INTO detail_product(o_id_no, no, o_id, nama_barang, jumlah, satuan, harga_satuan, jumlah_harga, ct_id, cl_id) VALUES ('" + txtoidno2.Text + "', '" + txtno2.Text + "', '" + cmboid.Text + "','" + txtnb2.Text + "','" + txtj2.Text + "', '" + txts2.Text + "', '" + txths2.Text + "', '" + txtjh2.Text + "', '" + txtctid.Text + "', '" + txtclid.Text + "')";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.dr = SQLConn.cmd.ExecuteReader();
                    }
                }

                if (cb3.Checked == true)
                {
                    if (txtno3.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "INSERT INTO detail_product(o_id_no, no, o_id, nama_barang, jumlah, satuan, harga_satuan, jumlah_harga, ct_id, cl_id) VALUES ('" + txtoidno3.Text + "', '" + txtno3.Text + "', '" + cmboid.Text + "','" + txtnb3.Text + "','" + txtj3.Text + "', '" + txts3.Text + "', '" + txths3.Text + "', '" + txtjh3.Text + "', '" + txtctid.Text + "', '" + txtclid.Text + "')";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.dr = SQLConn.cmd.ExecuteReader();
                    }
                }

                if (cb4.Checked == true)
                {
                    if (txtno4.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "INSERT INTO detail_product(o_id_no, no, o_id, nama_barang, jumlah, satuan, harga_satuan, jumlah_harga, ct_id, cl_id) VALUES ('" + txtoidno4.Text + "', '" + txtno4.Text + "', '" + cmboid.Text + "','" + txtnb4.Text + "','" + txtj4.Text + "', '" + txts4.Text + "', '" + txths4.Text + "', '" + txtjh4.Text + "', '" + txtctid.Text + "', '" + txtclid.Text + "')";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.dr = SQLConn.cmd.ExecuteReader();
                    }
                }

                if (cb5.Checked == true)
                {
                    if (txtno5.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "INSERT INTO detail_product(o_id_no, no, o_id, nama_barang, jumlah, satuan, harga_satuan, jumlah_harga, ct_id, cl_id) VALUES ('" + txtoidno5.Text + "', '" + txtno5.Text + "', '" + cmboid.Text + "','" + txtnb5.Text + "','" + txtj5.Text + "', '" + txts5.Text + "', '" + txths5.Text + "', '" + txtjh5.Text + "', '" + txtctid.Text + "', '" + txtclid.Text + "')";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.dr = SQLConn.cmd.ExecuteReader();                   
                    }
                }

                if (cb1.Checked == false)
                {
                    MessageBox.Show("Harap Input Data Yang Akan di Masukan", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Berhasil Disimpan", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    
        private void txtno1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno1.Text))
                txtoidno1.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno1.Text));
        }

        private void txtno2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno2.Text))
                txtoidno2.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno2.Text));
        }

        private void txtno3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno3.Text))
                txtoidno3.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno3.Text));
        }

        private void txtno4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno4.Text))
                txtoidno4.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno4.Text));
        }

        private void txtno5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmboid.Text) && !string.IsNullOrEmpty(txtno5.Text))
                txtoidno5.Text = (Convert.ToString(cmboid.Text) + "-" + Convert.ToString(txtno5.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmboid.SelectedIndex == -1)
            {
                MessageBox.Show("Harap Pilih Order ID Yang Akan Di Hapus", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboid.Focus();
                return;
            }

            else
            {
                if (MessageBox.Show("Apakah anda akan menghapus data ini?", "Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteOIDNO();
                }
            }
        }

        private void DeleteOIDNO()
        {
            try
            {

            if (cb1.Checked == true)
            {
                if (txtno1.Text == "")
                {
                    MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SQLConn.sqL = "DELETE FROM detail_product WHERE o_id_no='" + this.txtoidno1.Text + "';";
                    SQLConn.ConnDB();
                    SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                    SQLConn.dr = SQLConn.cmd.ExecuteReader();
                }
            }


            if (cb2.Checked == true)
            {
                if (txtno2.Text == "")
                {
                    MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SQLConn.sqL = "DELETE FROM detail_product WHERE o_id_no ='" + this.txtoidno2.Text + "';";
                    SQLConn.ConnDB();
                    SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                    SQLConn.dr = SQLConn.cmd.ExecuteReader();
                }
            }

            if (cb3.Checked == true)
            {
                if (txtno3.Text == "")
                {
                    MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SQLConn.sqL = "DELETE FROM detail_product WHERE o_id_no ='" + this.txtoidno3.Text + "';";
                    SQLConn.ConnDB();
                    SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                    SQLConn.dr = SQLConn.cmd.ExecuteReader();
                }
            }

            if (cb4.Checked == true)
            {
                if (txtno4.Text == "")
                {
                    MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SQLConn.sqL = "DELETE FROM detail_product WHERE o_id_no ='" + this.txtoidno4.Text + "';";
                    SQLConn.ConnDB();
                    SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                    SQLConn.dr = SQLConn.cmd.ExecuteReader();
                }
            }

            if (cb5.Checked == true)
            {
                if (txtno5.Text == "")
                {
                    MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SQLConn.sqL = "DELETE FROM detail_product WHERE o_id_no ='" + this.txtoidno5.Text + "';";
                    SQLConn.ConnDB();
                    SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                    SQLConn.dr = SQLConn.cmd.ExecuteReader();
                }
            }

            if (cb1.Checked == false)
            {
                MessageBox.Show("Harap Input Data Yang Akan di Hapus", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Berhasil Dihapus", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmboid.SelectedIndex == -1)
            {
                MessageBox.Show("Harap Pilih Order ID Yang Akan Di Update", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboid.Focus();
                return;
            }
            else
            {
               if (MessageBox.Show("Apakah anda akan Update data ini?", "Update",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               UpdateOIDNO();
            }
        }

        private void UpdateOIDNO()
        {
            try
            {

                if (cb1.Checked == true)
                {
                    if (txtno1.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return ;
                    }
                    else
                    {
                        SQLConn.sqL = "UPDATE detail_product SET nama_barang='" + txtnb1.Text + "', jumlah ='" + txtj1.Text + "', satuan ='" + txts1.Text + "', harga_satuan ='" + txths1.Text + "', jumlah_harga ='" + txtjh1.Text + "' WHERE o_id_no='" + this.txtoidno1.Text + "';";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.cmd.ExecuteNonQuery();
                    }
                }


                if (cb2.Checked == true)
                {
                    if (txtno2.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "UPDATE detail_product SET nama_barang='" + txtnb2.Text + "', jumlah ='" + txtj2.Text + "', satuan ='" + txts2.Text + "', harga_satuan ='" + txths2.Text + "', jumlah_harga ='" + txtjh2.Text + "' WHERE o_id_no='" + this.txtoidno2.Text + "';";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.cmd.ExecuteNonQuery();
                    }
                }

                if (cb3.Checked == true)
                {
                    if (txtno3.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "UPDATE detail_product SET nama_barang='" + txtnb3.Text + "', jumlah ='" + txtj3.Text + "', satuan ='" + txts3.Text + "', harga_satuan ='" + txths3.Text + "', jumlah_harga ='" + txtjh3.Text + "' WHERE o_id_no='" + this.txtoidno3.Text + "';";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.cmd.ExecuteNonQuery();
                    }
                }

                if (cb4.Checked == true)
                {
                    if (txtno4.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "UPDATE detail_product SET nama_barang='" + txtnb4.Text + "', jumlah ='" + txtj4.Text + "', satuan ='" + txts4.Text + "', harga_satuan ='" + txths4.Text + "', jumlah_harga ='" + txtjh4.Text + "' WHERE o_id_no='" + this.txtoidno4.Text + "';";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.cmd.ExecuteNonQuery();
                    }
                }

                if (cb5.Checked == true)
                {
                    if (txtno5.Text == "")
                    {
                        MessageBox.Show("No harus Diisi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLConn.sqL = "UPDATE detail_product SET nama_barang='" + txtnb5.Text + "', jumlah ='" + txtj5.Text + "', satuan ='" + txts5.Text + "', harga_satuan ='" + txths5.Text + "', jumlah_harga ='" + txtjh5.Text + "' WHERE o_id_no='" + this.txtoidno5.Text + "';";
                        SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.cmd.ExecuteNonQuery();
                    }
                }

                if (cb1.Checked == false)
                {
                    MessageBox.Show("Harap Input Data Yang Akan di Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Berhasil DiUpdate", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Reset();

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


        private void txths1_TextChanged(object sender, EventArgs e)
        {
          
            if (txtj1.Text == "" || txths1.Text == "")
            {
                txtjh1.Text = "";
            }
            else
            {
                Int64 hs = Int64.Parse(txths1.Text);
                Int64 j = Int64.Parse(txtj1.Text);
                txtjh1.Text = Convert.ToString(hs * j);
            }

        }

        private void txths2_TextChanged(object sender, EventArgs e)
        {
            if (txtj2.Text == "" || txths2.Text == "")
            {
                txtjh2.Text = "";
            }
            else
            {
                Int64 hs = Int64.Parse(txths2.Text);
                Int64 j = Int64.Parse(txtj2.Text);
                txtjh2.Text = Convert.ToString(hs * j);
            }
        }

        private void txths3_TextChanged(object sender, EventArgs e)
        {
            if (txtj3.Text == "" || txths3.Text == "")
            {
                txtjh3.Text = "";
            }
            else
            {
                Int64 hs = Int64.Parse(txths3.Text);
                Int64 j = Int64.Parse(txtj3.Text);
                txtjh3.Text = Convert.ToString(hs * j);
            }
        }

        private void txths4_TextChanged(object sender, EventArgs e)
        {
            if (txtj4.Text == "" || txths4.Text == "")
            {
                txtjh4.Text = "";
            }
            else
            {
                Int64 hs = Int64.Parse(txths4.Text);
                Int64 j = Int64.Parse(txtj4.Text);
                txtjh4.Text = Convert.ToString(hs * j);
            }
        }

        private void txths5_TextChanged(object sender, EventArgs e)
        {
            if (txtj5.Text == "" || txths5.Text == "")
            {
                txtjh5.Text = "";
            }
            else
            {
                Int64 hs = Int64.Parse(txths5.Text);
                Int64 j = Int64.Parse(txtj5.Text);
                txtjh5.Text = Convert.ToString(hs * j);
            }
        }

        private void btngetdatao_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            frmDetailProductRecord or = new frmDetailProductRecord();
            if (Application.OpenForms.OfType<frmDetailProductRecord>().Any())
            {
                Application.OpenForms.OfType<frmDetailProductRecord>().First().Close();
                or.Show();
            }
            else
            {
                or.Show();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            LoadRecord();
        }

        public void LoadRecord()
        {
            try
            {
                SQLConn.sqL = "SELECT o_id_no, no, nama_barang, jumlah, satuan, harga_satuan, jumlah_harga FROM detail_product";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                listView1.Items.Clear();


                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["o_id_no"].ToString());
                    x.SubItems.Add(SQLConn.dr["no"].ToString());
                    x.SubItems.Add(SQLConn.dr["nama_barang"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["jumlah"], "#,##0".ToString()));
                    x.SubItems.Add(SQLConn.dr["satuan"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["harga_satuan"], "#,##0".ToString()));
                    x.SubItems.Add(Strings.Format(SQLConn.dr["jumlah_harga"], "#,##0".ToString()));

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

        private void cbdp1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdp1.Checked == false)
            {
                cbdp2.Checked = true;
                btnSave.Enabled = false;
            }
            else
            {
                cbdp2.Checked = false;
                btnSave.Enabled = true;
            }
        }

        private void cbdp2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdp2.Checked==true)
            {
                cbdp1.Checked = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                cbdp1.Checked = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
    }
}
