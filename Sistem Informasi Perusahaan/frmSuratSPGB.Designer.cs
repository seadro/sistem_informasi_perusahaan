namespace Sistem_Informasi_Perusahaan
{
    partial class frmSuratSPGB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmboid = new System.Windows.Forms.ComboBox();
            this.txtnosurat = new System.Windows.Forms.TextBox();
            this.txtlmp = new System.Windows.Forms.TextBox();
            this.txtprl = new System.Windows.Forms.TextBox();
            this.dtpdibuat = new System.Windows.Forms.DateTimePicker();
            this.txtctid = new System.Windows.Forms.TextBox();
            this.txtclid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.txtcl = new System.Windows.Forms.TextBox();
            this.txtct = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnokontrak = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpkontrak = new System.Windows.Forms.DateTimePicker();
            this.txtbln = new System.Windows.Forms.TextBox();
            this.txtthn = new System.Windows.Forms.TextBox();
            this.txtromawi = new System.Windows.Forms.TextBox();
            this.txtspgb = new System.Windows.Forms.TextBox();
            this.txthari = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmboid
            // 
            this.cmboid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboid.FormattingEnabled = true;
            this.cmboid.Location = new System.Drawing.Point(136, 72);
            this.cmboid.Name = "cmboid";
            this.cmboid.Size = new System.Drawing.Size(172, 21);
            this.cmboid.TabIndex = 0;
            this.cmboid.SelectedIndexChanged += new System.EventHandler(this.cmbod_SelectedIndexChanged);
            // 
            // txtnosurat
            // 
            this.txtnosurat.Location = new System.Drawing.Point(136, 125);
            this.txtnosurat.Name = "txtnosurat";
            this.txtnosurat.Size = new System.Drawing.Size(172, 20);
            this.txtnosurat.TabIndex = 1;
            // 
            // txtlmp
            // 
            this.txtlmp.Location = new System.Drawing.Point(136, 151);
            this.txtlmp.Name = "txtlmp";
            this.txtlmp.Size = new System.Drawing.Size(172, 20);
            this.txtlmp.TabIndex = 2;
            // 
            // txtprl
            // 
            this.txtprl.Location = new System.Drawing.Point(136, 177);
            this.txtprl.Name = "txtprl";
            this.txtprl.Size = new System.Drawing.Size(172, 20);
            this.txtprl.TabIndex = 3;
            // 
            // dtpdibuat
            // 
            this.dtpdibuat.CustomFormat = "dd-MM-yyyy";
            this.dtpdibuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdibuat.Location = new System.Drawing.Point(136, 99);
            this.dtpdibuat.Name = "dtpdibuat";
            this.dtpdibuat.Size = new System.Drawing.Size(172, 20);
            this.dtpdibuat.TabIndex = 4;
            this.dtpdibuat.Value = new System.DateTime(2017, 7, 28, 9, 54, 47, 0);
            this.dtpdibuat.ValueChanged += new System.EventHandler(this.dtpdibuat_ValueChanged);
            // 
            // txtctid
            // 
            this.txtctid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtctid.Location = new System.Drawing.Point(465, 66);
            this.txtctid.Name = "txtctid";
            this.txtctid.ReadOnly = true;
            this.txtctid.Size = new System.Drawing.Size(24, 20);
            this.txtctid.TabIndex = 94;
            // 
            // txtclid
            // 
            this.txtclid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtclid.Location = new System.Drawing.Point(645, 66);
            this.txtclid.Name = "txtclid";
            this.txtclid.ReadOnly = true;
            this.txtclid.Size = new System.Drawing.Size(24, 20);
            this.txtclid.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Product :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Client :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Jenis :";
            // 
            // txtnp
            // 
            this.txtnp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtnp.Location = new System.Drawing.Point(465, 99);
            this.txtnp.Multiline = true;
            this.txtnp.Name = "txtnp";
            this.txtnp.ReadOnly = true;
            this.txtnp.Size = new System.Drawing.Size(174, 34);
            this.txtnp.TabIndex = 89;
            // 
            // txtcl
            // 
            this.txtcl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcl.Location = new System.Drawing.Point(675, 66);
            this.txtcl.Multiline = true;
            this.txtcl.Name = "txtcl";
            this.txtcl.ReadOnly = true;
            this.txtcl.Size = new System.Drawing.Size(134, 67);
            this.txtcl.TabIndex = 88;
            // 
            // txtct
            // 
            this.txtct.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtct.Location = new System.Drawing.Point(495, 66);
            this.txtct.Name = "txtct";
            this.txtct.ReadOnly = true;
            this.txtct.Size = new System.Drawing.Size(93, 20);
            this.txtct.TabIndex = 87;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(417, 178);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 163);
            this.listView1.TabIndex = 95;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No Surat";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lampiran";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Perihal";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tanggal Dibuat";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No Kontrak";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tanggal Kontrak";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Order ID";
            this.columnHeader7.Width = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "No Order :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "No Surat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Lampiran :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Perihal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "Tanggal dibuat :";
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(322, 123);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(42, 23);
            this.btnnew.TabIndex = 101;
            this.btnnew.Text = "&New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(40, 272);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(73, 23);
            this.btnsave.TabIndex = 102;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(119, 272);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(73, 23);
            this.btndelete.TabIndex = 103;
            this.btndelete.Text = "&Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(198, 272);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(73, 23);
            this.btnupdate.TabIndex = 104;
            this.btnupdate.Text = "&Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(277, 272);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(73, 23);
            this.btnexport.TabIndex = 105;
            this.btnexport.Text = "&Export";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(495, 144);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(73, 23);
            this.btnsearch.TabIndex = 106;
            this.btnsearch.Text = "&Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(675, 144);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(73, 23);
            this.btnrefresh.TabIndex = 107;
            this.btnrefresh.Text = "&Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 25);
            this.label6.TabIndex = 108;
            this.label6.Text = "SURAT PERMOHONAN PENGIRIMIAN BARANG";
            // 
            // txtnokontrak
            // 
            this.txtnokontrak.Location = new System.Drawing.Point(136, 203);
            this.txtnokontrak.Name = "txtnokontrak";
            this.txtnokontrak.Size = new System.Drawing.Size(172, 20);
            this.txtnokontrak.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "No Kontrak :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Tanggal Kontrak :";
            // 
            // dtpkontrak
            // 
            this.dtpkontrak.CustomFormat = "dd-MM-yyyy";
            this.dtpkontrak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkontrak.Location = new System.Drawing.Point(136, 225);
            this.dtpkontrak.Name = "dtpkontrak";
            this.dtpkontrak.ShowCheckBox = true;
            this.dtpkontrak.Size = new System.Drawing.Size(172, 20);
            this.dtpkontrak.TabIndex = 112;
            // 
            // txtbln
            // 
            this.txtbln.Location = new System.Drawing.Point(189, 321);
            this.txtbln.Name = "txtbln";
            this.txtbln.ReadOnly = true;
            this.txtbln.Size = new System.Drawing.Size(46, 20);
            this.txtbln.TabIndex = 113;
            this.txtbln.Visible = false;
            // 
            // txtthn
            // 
            this.txtthn.Location = new System.Drawing.Point(268, 321);
            this.txtthn.Name = "txtthn";
            this.txtthn.ReadOnly = true;
            this.txtthn.Size = new System.Drawing.Size(40, 20);
            this.txtthn.TabIndex = 114;
            this.txtthn.Visible = false;
            // 
            // txtromawi
            // 
            this.txtromawi.Location = new System.Drawing.Point(347, 321);
            this.txtromawi.Name = "txtromawi";
            this.txtromawi.ReadOnly = true;
            this.txtromawi.Size = new System.Drawing.Size(43, 20);
            this.txtromawi.TabIndex = 115;
            this.txtromawi.Visible = false;
            // 
            // txtspgb
            // 
            this.txtspgb.Location = new System.Drawing.Point(12, 321);
            this.txtspgb.Name = "txtspgb";
            this.txtspgb.ReadOnly = true;
            this.txtspgb.Size = new System.Drawing.Size(50, 20);
            this.txtspgb.TabIndex = 116;
            this.txtspgb.Text = "SPGB";
            this.txtspgb.Visible = false;
            // 
            // txthari
            // 
            this.txthari.Location = new System.Drawing.Point(122, 321);
            this.txthari.Name = "txthari";
            this.txthari.ReadOnly = true;
            this.txthari.Size = new System.Drawing.Size(39, 20);
            this.txthari.TabIndex = 117;
            this.txthari.Visible = false;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(68, 321);
            this.txtno.Name = "txtno";
            this.txtno.ReadOnly = true;
            this.txtno.Size = new System.Drawing.Size(38, 20);
            this.txtno.TabIndex = 118;
            this.txtno.Visible = false;
            // 
            // frmSuratSPGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 365);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txthari);
            this.Controls.Add(this.txtspgb);
            this.Controls.Add(this.txtromawi);
            this.Controls.Add(this.txtthn);
            this.Controls.Add(this.txtbln);
            this.Controls.Add(this.dtpkontrak);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtnokontrak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtctid);
            this.Controls.Add(this.txtclid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.txtcl);
            this.Controls.Add(this.txtct);
            this.Controls.Add(this.dtpdibuat);
            this.Controls.Add(this.txtprl);
            this.Controls.Add(this.txtlmp);
            this.Controls.Add(this.txtnosurat);
            this.Controls.Add(this.cmboid);
            this.Name = "frmSuratSPGB";
            this.Text = "Persuratan SPGB";
            this.Load += new System.EventHandler(this.frmSuratSPGB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtnp;
        internal System.Windows.Forms.TextBox txtcl;
        internal System.Windows.Forms.TextBox txtct;
        internal System.Windows.Forms.ComboBox cmboid;
        internal System.Windows.Forms.TextBox txtnosurat;
        internal System.Windows.Forms.TextBox txtlmp;
        internal System.Windows.Forms.TextBox txtprl;
        internal System.Windows.Forms.DateTimePicker dtpdibuat;
        internal System.Windows.Forms.TextBox txtctid;
        internal System.Windows.Forms.TextBox txtclid;
        internal System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnexport;
        internal System.Windows.Forms.Button btnsearch;
        internal System.Windows.Forms.Button btnrefresh;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtnokontrak;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.DateTimePicker dtpkontrak;
        internal System.Windows.Forms.TextBox txtbln;
        internal System.Windows.Forms.TextBox txtthn;
        internal System.Windows.Forms.TextBox txtromawi;
        internal System.Windows.Forms.TextBox txtspgb;
        internal System.Windows.Forms.TextBox txthari;
        internal System.Windows.Forms.TextBox txtno;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.ColumnHeader columnHeader4;
        internal System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.ColumnHeader columnHeader6;
        internal System.Windows.Forms.ColumnHeader columnHeader7;
    }
}