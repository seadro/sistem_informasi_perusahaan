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
using System.Collections;

namespace Sistem_Informasi_Perusahaan
{
    public partial class frmSuratSPGB : Form
    {
        public frmSuratSPGB()
        {
            InitializeComponent();
        }

        private void frmSuratSPGB_Load(object sender, EventArgs e)
        {
            cmbo_id();
            LoadList("");
            LoadRecord();

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
            dtpdibuat.Value = DateTime.Today;
            dtpkontrak.Value = DateTime.Today;
        }

        private void cmbod_SelectedIndexChanged(object sender, EventArgs e)
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
                    string clid = SQLConn.dr["cl_id"].ToString();
                    txtclid.Text = clid;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (txtno.Text == "" && txthari.Text =="" && txtbln.Text=="" && txtthn.Text=="" && txtromawi.Text=="")
            {
                MessageBox.Show("Harap Pilih Tanggal Surat Yang Akan Dibuat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpdibuat.Focus();
                return;
            }

            try
            {
                SQLConn.sqL = "SELECT no FROM spgb";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    txtno.Text = (Convert.ToInt32(SQLConn.dr["no"]) + 0).ToString();
                }
                else
                {
                    txtno.Text = "1";
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            if (!string.IsNullOrEmpty(txtno.Text) && !string.IsNullOrEmpty(txtspgb.Text) && !string.IsNullOrEmpty(txtromawi.Text) && !string.IsNullOrEmpty(txtthn.Text))
                txtnosurat.Text = (Convert.ToString(txtno.Text) + "/" + Convert.ToString(txtspgb.Text) + "/" + Convert.ToString(txtromawi.Text) + "/" + Convert.ToString(txtthn.Text));
        }

        private void dtpdibuat_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dtpdibuat.Value;
            this.txthari.Text = date.ToString("dd");
            this.txtbln.Text = date.ToString("MM");
            this.txtthn.Text = date.ToString("yyyy");
            txtromawi.Text = this.IntegerToRoman(int.Parse(txtbln.Text)).ToString();
        }
        public string IntegerToRoman(int IntNumberValue)
        {
            Dictionary<string, int> RomanNumbers = new Dictionary<string, int>();
            RomanNumbers.Add("M", 1000);
            RomanNumbers.Add("CM", 900);
            RomanNumbers.Add("D", 500);
            RomanNumbers.Add("CD", 400);
            RomanNumbers.Add("C", 100);
            RomanNumbers.Add("XC", 90);
            RomanNumbers.Add("L", 50);
            RomanNumbers.Add("XL", 40);
            RomanNumbers.Add("X", 10);
            RomanNumbers.Add("IX", 9);
            RomanNumbers.Add("V", 5);
            RomanNumbers.Add("IV", 4);
            RomanNumbers.Add("I", 1);

            string result = "";

            foreach (var pair in RomanNumbers)
            {
                while (IntNumberValue >= pair.Value)
                {
                    IntNumberValue -= pair.Value;
                    result += pair.Key;
                }
            }
            return result;
        }

        private void LoadRecord()
        {
            try
            {
                SQLConn.sqL = "SELECT * FROM spgb";
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

        private void Reset()
        {
            cmboid.SelectedIndex = -1;
            txtnosurat.Text = "";
            txtlmp.Text = "";
            txtprl.Text = "";
            txtnokontrak.Text = "";
            txtno.Text = "";
            txthari.Text = "";
            txtbln.Text = "";
            txtthn.Text = "";
            txtromawi.Text = "";
            txtctid.Text = "";
            txtclid.Text = "";
            txtct.Text = "";
            txtcl.Text = "";
            txtnp.Text = "";
            dtpdibuat.Value = DateTime.Today;
            dtpkontrak.Value = DateTime.Today;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnosurat.Text == "" && cmboid.SelectedIndex==-1)
            {
                MessageBox.Show("No Surat Tidak Boleh Kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnosurat.Focus();
                return;
            }


            try
            {
                SQLConn.sqL = "SELECT no_surat FROM spgb WHERE no_surat=@find";
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.ConnDB();
                SQLConn.cmd.Parameters.Add(new MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 15, "no_surat"));
                SQLConn.cmd.Parameters["@find"].Value = txtnosurat.Text;
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read())
                {
                    MessageBox.Show("Harap Masukkan No Surat Yang Belum Terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnosurat.Text = "";
                    txtnosurat.Focus();

                    if ((SQLConn.dr != null))
                    {
                        SQLConn.dr.Close();
                    }
                    return;
                }

                SQLConn.sqL = "INSERT INTO spgb(no_surat, lampiran, perihal, tgl_dibuat, no_kontrak, tgl_kontrak, o_id, no) VALUES ('" + txtnosurat.Text + "', '" + txtlmp.Text + "', '" + txtprl.Text + "','" + dtpdibuat.Text + "','" + txtnokontrak.Text + "','" + dtpkontrak.Text + "','" + cmboid.Text + "','" + txtno.Text + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                MessageBox.Show("Berhasil Disimpan", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecord();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                Interaction.MsgBox("Harap Pilih Data Yang Akan Di Hapus", MsgBoxStyle.Exclamation, "Delete");
                return;
            }

            else
            {
                if (MessageBox.Show("Apakah anda akan menghapus data?", "Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Delete();
                    LoadRecord();
                    Reset();
                }
            }
        }

        public void Delete()
        {

            try
            {
                txtnosurat.Text = listView1.FocusedItem.Text;
                SQLConn.sqL = "DELETE FROM spgb WHERE no_surat='" + this.txtnosurat.Text + "';";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                MessageBox.Show("Data Surat Berhasil Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecord();
                LoadList("");


            }
            catch (Exception)
            {
                MessageBox.Show("Harap Pilih Data Yang Akan Di Hapus", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtnosurat.Text == "")
            {
                Interaction.MsgBox("No Surat Tidak Boleh Kosong!", MsgBoxStyle.Exclamation, "Update");
                return;
            }

            else
            {
                Update();
                LoadRecord();
                Reset();
            }
        }

        private void Update()
        {
            try
            {
                txtnosurat.Text = listView1.FocusedItem.Text;
                SQLConn.sqL = "UPDATE spgb SET lampiran = '" + txtlmp.Text + "', perihal = '" + txtprl.Text + "', tgl_dibuat = '" + dtpdibuat.Text + "', no_kontrak = '" + txtnokontrak.Text + "', tgl_kontrak = '" + dtpkontrak.Text + "' WHERE no_surat='" + this.txtnosurat.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                Interaction.MsgBox("Data Telah Di Update", MsgBoxStyle.Information, "Update Data");
                LoadRecord();
                LoadList("");

            }
            catch (Exception)
            {
                MessageBox.Show("Harap Pilih Data Yang Akan Di Hapus", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void LoadList(string search)
        {
            try
            {
                SQLConn.sqL = "SELECT no_surat, lampiran, perihal, tgl_dibuat, no_kontrak, tgl_kontrak, o_id FROM spgb WHERE no_surat LIKE '" + search.Trim() + "%' ORDER By no_surat";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                listView1.Items.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["no_surat"].ToString());
                    x.SubItems.Add(SQLConn.dr["lampiran"].ToString());
                    x.SubItems.Add(SQLConn.dr["perihal"].ToString());
                    x.SubItems.Add(SQLConn.dr["tgl_dibuat"].ToString());
                    x.SubItems.Add(SQLConn.dr["no_kontrak"].ToString());
                    x.SubItems.Add(SQLConn.dr["tgl_kontrak"].ToString());
                    x.SubItems.Add(SQLConn.dr["o_id"].ToString());
                   
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
            LoadList("");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SQLConn.strSearch = Interaction.InputBox("Masukkan No Surat.", "Search Surat", " ");

            if (SQLConn.strSearch.Length >= 1)
            {
                LoadList(SQLConn.strSearch.Trim());
            }
            else if (string.IsNullOrEmpty(SQLConn.strSearch))
            {
                return;
            }
        }

        private int sortColumn = -1;

        class ListViewItemComparer : IComparer   
          {  
              private int col;  
              private SortOrder order;  
              public ListViewItemComparer()  
              {  
                  col = 0;  
                  order = SortOrder.Ascending;  
              }  
              public ListViewItemComparer(int column, SortOrder order)  
              {  
                  col = column;  
                  this.order = order;  
              }  
              public int Compare(object x, object y)  
              {  
                  int returnVal;  
                  // Determine whether the type being compared is a date type.  
                  try 
                  {  
                      // Parse the two objects passed as a parameter as a DateTime.  
                      System.DateTime firstDate =  
                              DateTime.Parse(((ListViewItem)x).SubItems[col].Text);  
                      System.DateTime secondDate =  
                              DateTime.Parse(((ListViewItem)y).SubItems[col].Text);  
                      // Compare the two dates.  
                      returnVal = DateTime.Compare(firstDate, secondDate);  
                  }  
                  // If neither compared object has a valid date format, compare  
                  // as a string.  
                  catch 
                  {  
                      // Compare the two items as a string.  
                      returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,  
                                  ((ListViewItem)y).SubItems[col].Text);  
                  }  
                  // Determine whether the sort order is descending.  
                  if (order == SortOrder.Descending)  
                      // Invert the value returned by String.Compare.  
                      returnVal *= -1;  
                  return returnVal;  
              }  
          } 
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.  
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.  
                sortColumn = e.Column;
                // Set the sort order to ascending by default.  
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.  
                if (listView1.Sorting == SortOrder.Ascending)
                    listView1.Sorting = SortOrder.Descending;
                else
                    listView1.Sorting = SortOrder.Ascending;
            }
            // Call the sort method to manually sort.  
            listView1.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer  
            // object.  
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            frmSuratSPGBReport spgb = new frmSuratSPGBReport();
            spgb.ShowDialog();
        }
    }
}
