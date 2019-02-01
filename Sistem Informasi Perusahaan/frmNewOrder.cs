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
using System.Text.RegularExpressions;

namespace Sistem_Informasi_Perusahaan
{
    public partial class frmNewOrder : Form
    {

        public frmNewOrder()
        {
            InitializeComponent();

        }

        private void frmNewProject_Load(object sender, EventArgs e)
        {

            btndeletect.Enabled = false;
            btnupdatect.Enabled = false;
            btndeletecl.Enabled = false;
            btnupdatecl.Enabled = false;
            btndeleteo.Enabled = false;
            btnupdateo.Enabled = false;
            Resetct();
            if (SQLConn.adding == true)
            {
                GetCatID();
                GetCliID();
                Resetcl();
                txtjenisct.Text = "";

            }
            //================================================================ Order ID
            cmbcto();
            cmbclo();
            //================================================================ Order ID

        }

        //______________________________________________________________________________________________________________________________________________ Category Project

        private void btnsavect_Click(object sender, EventArgs e)
        {
            if (txtjenisct.Text == "")
            {
                MessageBox.Show("Harap Check Kembali Inputan Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtjenisct.Focus();
                return;
            }


            try
            {
                SQLConn.sqL = "SELECT ct_id FROM category_project WHERE ct_id=@find";
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.ConnDB();
                SQLConn.cmd.Parameters.Add(new MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.Int16, 5, "ct_id"));
                SQLConn.cmd.Parameters["@find"].Value = txtctid.Text;
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read())
                {
                    MessageBox.Show("Harap Masukkan No ID Yang Belum Terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtctid.Text = "";
                    txtctid.Focus();

                    if ((SQLConn.dr != null))
                    {
                        SQLConn.dr.Close();
                    }
                    return;
                }

                SQLConn.sqL = "SELECT project_category FROM category_project WHERE project_category='" + txtjenisct.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read())
                {
                    MessageBox.Show("Category Yang Anda Masukkan Sudah Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtjenisct.Text = "";
                    txtjenisct.Focus();

                    if ((SQLConn.dr != null))
                    {
                        SQLConn.dr.Close();
                    }
                    return;
                }

                SQLConn.sqL = "INSERT INTO category_project(ct_id, project_category) VALUES ('" + txtctid.Text + "', '" + txtjenisct.Text + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                MessageBox.Show("Berhasil Disimpan", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecordCatID();
                Resetct();

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

        private void LoadRecordCatID()
        {
            try
            {
                SQLConn.sqL = "SELECT * FROM category_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
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

        private void GetCatID()
        {
            try
            {
                SQLConn.sqL = "SELECT ct_id FROM category_project ORDER BY ct_id DESC";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    txtctid.Text = (Convert.ToInt32(SQLConn.dr["ct_id"]) + 1).ToString();
                }
                else
                {
                    txtctid.Text = "1";
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

        private void btndeletect_Click(object sender, EventArgs e)
        {
            if (txtctid.Text == "")
            {
                Interaction.MsgBox("Harap Isikan Data Category ID Yang Akan Di Hapus", MsgBoxStyle.Exclamation, "Delete");
                return;
            }

            else
            {
                if (MessageBox.Show("Apakah anda akan menghapus data ini?", "Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteCatID();
                    LoadRecordCatID();
                    Resetct();
                }
            }
        }

        public void DeleteCatID()
        {
            try
            {

                SQLConn.sqL = "DELETE FROM category_project WHERE ct_id=" + txtctid.Text + "";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                MessageBox.Show("Data Berhasil Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnupdatect_Click(object sender, EventArgs e)
        {
            if (txtctid.Text == "")
            {
                Interaction.MsgBox("Harap Isikan Data Category ID Yang Akan Di Update", MsgBoxStyle.Exclamation, "Update");
                return;
            }

            else
            {
                UpdateCatID();
                LoadRecordCatID();
                Resetct();
            }

        }

        private void UpdateCatID()
        {
            try
            {

                SQLConn.sqL = "UPDATE category_project SET  project_category = '" + txtjenisct.Text + "' WHERE ct_id='" + txtctid.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                Interaction.MsgBox("Data Telah Di Update", MsgBoxStyle.Information, "Update Data");

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

        private void btngetdatact_Click(object sender, EventArgs e)
        {
            frmNewOrder or = new frmNewOrder();
            if (Application.OpenForms.OfType<frmNewOrder>().Any())
            {
                Application.OpenForms.OfType<frmNewOrder>().First().Close();
                or.Show();
            }
            else
            {

                or.Show();
            }
            frmCategoryOrderRecord ctpr = new frmCategoryOrderRecord();
            if (Application.OpenForms.OfType<frmCategoryOrderRecord>().Any())
            {

                Application.OpenForms.OfType<frmCategoryOrderRecord>().First().Close();
                ctpr.Show();
            }
            else
            {

                ctpr.Show();
            }
        }

        private void btnnewct_Click(object sender, EventArgs e)
        {
            LoadRecordCatID();
            txtjenisct.Text = "";
            GetCatID();
            cbclid1.Checked = true;
        }

        private void Resetct()
        {
            txtctid.Text = "";
            txtjenisct.Text = "";
        }
        //______________________________________________________________________________________________________________________________________________ Category Project
        //**********************************************************************************************************************************************
        //______________________________________________________________________________________________________________________________________________ Client Project
        private void btnsavecl_Click(object sender, EventArgs e)
        {

            if (txtnamaclient.Text == "")
            {
                MessageBox.Show("Harap Check Kembali Inputan Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnamaclient.Focus();
                return;
            }


            try
            {
                SQLConn.sqL = "SELECT cl_id FROM client_project WHERE cl_id=@find";
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.ConnDB();
                SQLConn.cmd.Parameters.Add(new MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.Int16, 5, "cl_id"));
                SQLConn.cmd.Parameters["@find"].Value = txtclid.Text;
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read())
                {
                    MessageBox.Show("Harap Masukkan No ID Yang Belum Terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtctid.Text = "";
                    txtctid.Focus();

                    if ((SQLConn.dr != null))
                    {
                        SQLConn.dr.Close();
                    }
                    return;
                }

                SQLConn.sqL = "INSERT INTO client_project(cl_id, client_name, alamat, no_telp, email) VALUES ('" + txtclid.Text + "', '" + txtnamaclient.Text + "', '" + txtalamatcl.Text + "','" + txttelpcl.Text + "','" + txtemailcl.Text + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                MessageBox.Show("Berhasil Disimpan", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecordClID();
                Resetcl();

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

        private void LoadRecordClID()
        {
            try
            {
                SQLConn.sqL = "SELECT * FROM client_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
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

        private void Resetcl()
        {
            txtnamaclient.Text = "";
            txtalamatcl.Text = "";
            txttelpcl.Text = "";
            txtemailcl.Text = "";
        }

        private void GetCliID()
        {
            try
            {
                SQLConn.sqL = "SELECT cl_id FROM client_project ORDER BY cl_id DESC";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    txtclid.Text = (Convert.ToInt32(SQLConn.dr["cl_id"]) + 1).ToString();
                }
                else
                {
                    txtclid.Text = "1";
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

        private void btndeletecl_Click(object sender, EventArgs e)
        {
            if (txtclid.Text == "")
            {
                Interaction.MsgBox("Harap Isikan Data Client ID Yang Akan Di Hapus", MsgBoxStyle.Exclamation, "Delete");
                return;
            }

            else
            {
                if (MessageBox.Show("Apakah anda akan menghapus data ini?", "Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteCliID();
                    LoadRecordClID();
                    Resetcl();
                }
            }
        }

        public void DeleteCliID()
        {
            try
            {

                SQLConn.sqL = "DELETE FROM client_project WHERE cl_id=" + txtclid.Text + "";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                MessageBox.Show("Data Berhasil Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnupdatecl_Click(object sender, EventArgs e)
        {
            if (txtclid.Text == "")
            {
                Interaction.MsgBox("Harap Isikan Data Client ID Yang Akan Di Update", MsgBoxStyle.Exclamation, "Delete");
                return;
            }

            else
            {
                UpdateCliID();
                LoadRecordClID();
                Resetcl();
            }
        }

        private void UpdateCliID()
        {
            try
            {

                SQLConn.sqL = "UPDATE client_project SET client_name = '" + txtnamaclient.Text + "', alamat='" + txtalamatcl.Text + "', no_telp='" + txttelpcl.Text + "', email = '" + txtemailcl.Text + "' WHERE cl_id='" + txtclid.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                Interaction.MsgBox("Data Telah Di Update", MsgBoxStyle.Information, "Update Data");

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

        private void btngetdatacl_Click(object sender, EventArgs e)
        {

            frmNewOrder or = new frmNewOrder();
            if (Application.OpenForms.OfType<frmNewOrder>().Any())
            {
                Application.OpenForms.OfType<frmNewOrder>().First().Close();
                or.Show();
            }
            else
            {

                or.Show();
            }
            frmClientOrderRecord fcr = new frmClientOrderRecord();
            if (Application.OpenForms.OfType<frmClientOrderRecord>().Any())
            {

                Application.OpenForms.OfType<frmClientOrderRecord>().First().Close();
                fcr.Show();
            }
            else
            {

                fcr.Show();
            }
        }

        private void btnnewcl_Click(object sender, EventArgs e)
        {
            LoadRecordClID();
            Resetcl();
            GetCliID();
            cbclid1.Checked = true;
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
        //______________________________________________________________________________________________________________________________________________ Client Project
        //**********************************************************************************************************************************************
        //______________________________________________________________________________________________________________________________________________ Order Project


        private void auto_oid()
        {

            string id;

            string ND; // "CHHRT" or whatever;

            int sequence;

            try
            {
                SQLConn.sqL = "SELECT o_id FROM order_project ORDER BY o_id DESC";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    id = SQLConn.dr[0].ToString();
                    sequence = int.Parse(new string(id.Where(char.IsDigit).ToArray()));
                    ND = new string(id.Where(char.IsLetter).ToArray());
                    id = ND + (sequence + 1).ToString("000");
                    txtoid.Text = id;
                }
                else
                {
                    txtoid.Text = "ND001";
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
        private void cmbcto()
        {
            try
            {
                SQLConn.sqL="SELECT project_category FROM category_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                while (SQLConn.dr.Read())
                {
                    cmbct.Items.Add(SQLConn.dr[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            cmbct.SelectedIndex = -1;
        }

        private void cmbclo()
        {
            try
            {
                SQLConn.sqL = "SELECT client_name FROM client_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                while (SQLConn.dr.Read())
                {
                    cmbcl.Items.Add(SQLConn.dr[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            cmbcl.SelectedIndex = -1;
        }

        private void Resetoid()
        {
            txtoid.Text = "";
            cmbcl.SelectedIndex = -1;
            txtclido.Text = "";
            cmbct.SelectedIndex = -1;
            txtctido.Text = "";
            txtnamaproducto.Text = "";

        }

        private void cmbct_SelectedIndexChanged(object sender, EventArgs e)
        {

            SQLConn.sqL = "SELECT * FROM category_project WHERE project_category='"+cmbct.Text+"';";
            SQLConn.ConnDB();
            SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
            SQLConn.dr = SQLConn.cmd.ExecuteReader();
            try
            {
                while (SQLConn.dr.Read())
                {
                    string sct_id = SQLConn.dr.GetInt32("ct_id").ToString();
                    txtctido.Text = sct_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbcl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLConn.sqL = "SELECT * FROM client_project WHERE client_name='" + cmbcl.Text + "';";
            SQLConn.ConnDB();
            SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
            SQLConn.dr = SQLConn.cmd.ExecuteReader();
            try
            {
                while (SQLConn.dr.Read())
                {
                    string scl_id = SQLConn.dr.GetInt32("cl_id").ToString();
                    txtclido.Text = scl_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsaveo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtoid.Text == "")
                {
                    MessageBox.Show("Please enter Order ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtoid.Focus();
                    return;
                }

                if (cmbct.Text == "")
                {
                    MessageBox.Show("Please select category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbct.Focus();
                    return;
                }

                if (cmbcl.Text == "")
                {
                    MessageBox.Show("Please select Client", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbcl.Focus();
                    return;
                }
                if (txtnamaproducto.Text == "")
                {
                    MessageBox.Show("Please enter Nama Product", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnamaproducto.Focus();
                    return;
                }

                SQLConn.sqL = "SELECT o_id FROM order_project WHERE o_id=@find";
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.ConnDB();
                SQLConn.cmd.Parameters.Add(new MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 10, "o_id"));
                SQLConn.cmd.Parameters["@find"].Value = txtoid.Text;
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read())
                {
                    MessageBox.Show("Harap Masukkan No ID Yang Belum Terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtoid.Text = "";
                    txtoid.Focus();

                    if ((SQLConn.dr != null))
                    {
                        SQLConn.dr.Close();
                    }
                    return;
                }

                SQLConn.sqL = "INSERT INTO order_project(o_id, ct_id, cl_id, nama_product, tanggal_dimulai) VALUES ('" + txtoid.Text + "', '" + txtctido.Text + "', '" + txtclido.Text + "','" + txtnamaproducto.Text + "','" + dtptanggaldimulai.Text + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                MessageBox.Show("Berhasil Disimpan", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecordOID();
                Resetoid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadRecordOID()
        {
            try
            {
                SQLConn.sqL = "SELECT * FROM order_project";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
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

        private void btnnewo_Click(object sender, EventArgs e)
        {
            auto_oid();
            LoadRecordOID();
            cboid1.Checked = true;
        }

        private void btndeleteo_Click(object sender, EventArgs e)
        {
            if (txtoid.Text == "")
            {
                Interaction.MsgBox("Harap Isikan Data Client ID Yang Akan Di Hapus", MsgBoxStyle.Exclamation, "Delete");
                return;
            }

            else
            {
                if (MessageBox.Show("Apakah anda akan menghapus data ini?", "Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteCliID();
                    LoadRecordOID();
                    Resetoid();
                }
            }
        }

        private void btnupdateo_Click(object sender, EventArgs e)
        {
            if (txtoid.Text == "")
            {
                Interaction.MsgBox("Harap Isikan Data Order ID Yang Akan Di Update", MsgBoxStyle.Exclamation, "Delete");
                return;
            }

            else
            {
                Updateoid();
                LoadRecordOID();
                Resetoid();
            }
        }

        private void Updateoid()
        {
            try
            {

                SQLConn.sqL = "UPDATE order_project SET ct_id = '" + txtctido.Text + "', cl_id='" + txtclido.Text + "', nama_product ='" + txtnamaproducto.Text + "', tanggal_dimulai = '" + dtptanggaldimulai.Text + "' WHERE o_id='" + txtoid.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                Interaction.MsgBox("Data Telah Di Update", MsgBoxStyle.Information, "Update Data");

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

        private void btngetdatao_Click(object sender, EventArgs e)
        {
            frmNewOrder or = new frmNewOrder();
            if (Application.OpenForms.OfType<frmNewOrder>().Any())
            {
                Application.OpenForms.OfType<frmNewOrder>().First().Close();
                or.Show();
            }
            else
            {

                or.Show();
            }
            frmOrderRecord orc = new frmOrderRecord();
            if (Application.OpenForms.OfType<frmOrderRecord>().Any())
            {

                Application.OpenForms.OfType<frmOrderRecord>().First().Close();
                orc.Show();
            }
            else
            {

                orc.Show();
            }
        }

        //========================================================================================================================================== Button Checked -Save- -Delete- -Update-

        private void cbctid1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbctid2.Checked == true)
            {
                cbctid1.Checked = false;
                btndeletect.Enabled = true;
                btnupdatect.Enabled = true;
            }
            else
            {
                cbctid1.Checked = true;
                btndeletect.Enabled = false;
                btnupdatect.Enabled = false;
            }
        }

        private void cbctid1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbctid1.Checked == false)
            {
                btnsavect.Enabled = false;
                cbctid2.Checked = true;
            }
            else
            {
                cbctid2.Checked = false;
                btnsavect.Enabled = true;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------- category - client

        private void cbclid1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbclid2.Checked==true)
            {
                cbclid1.Checked = false;
                btndeletecl.Enabled = true;
                btnupdatecl.Enabled = true;
            }
            else
            {
                cbclid1.Checked = true;
                btndeletecl.Enabled = false;
                btnupdatecl.Enabled = false;
            }
        }

        private void cbclid1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbclid1.Checked==false)
            {
                btnsavecl.Enabled = false;
                cbclid2.Checked = true;
            }
            else
            {
                cbclid2.Checked = false;
                btnsavecl.Enabled = true;
            }
        }

        //------------------------------------------------------------------------------------------------------------ client - order

        private void cboid1_CheckedChanged(object sender, EventArgs e)
        {
            if (cboid2.Checked == true)
            {
                cboid1.Checked = false;
                btndeleteo.Enabled = true;
                btnupdateo.Enabled = true;
            }
            else
            {
                btndeleteo.Enabled = false;
                btnupdateo.Enabled = false;
                cboid1.Checked = true;
            }
        }

        private void cboid1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboid1.Checked==false)
            {
                cboid2.Checked = true;
                btnsaveo.Enabled = false;
            }
            else
            {
                btnsaveo.Enabled = true;
                cboid2.Checked = false;
            }
        }
    }
}
