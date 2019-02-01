namespace Sistem_Informasi_Perusahaan
{
    partial class frmNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewOrder));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpcategory = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtjenisct = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbctid1 = new System.Windows.Forms.CheckBox();
            this.cbctid2 = new System.Windows.Forms.CheckBox();
            this.btngetdatact = new System.Windows.Forms.Button();
            this.btnupdatect = new System.Windows.Forms.Button();
            this.btndeletect = new System.Windows.Forms.Button();
            this.btnsavect = new System.Windows.Forms.Button();
            this.btnnewct = new System.Windows.Forms.Button();
            this.txtctid = new System.Windows.Forms.TextBox();
            this.tpclient = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemailcl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelpcl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtalamatcl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnamaclient = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbclid1 = new System.Windows.Forms.CheckBox();
            this.cbclid2 = new System.Windows.Forms.CheckBox();
            this.btngetdatacl = new System.Windows.Forms.Button();
            this.btnupdatecl = new System.Windows.Forms.Button();
            this.btndeletecl = new System.Windows.Forms.Button();
            this.btnsavecl = new System.Windows.Forms.Button();
            this.btnnewcl = new System.Windows.Forms.Button();
            this.txtclid = new System.Windows.Forms.TextBox();
            this.tporder = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtclido = new System.Windows.Forms.TextBox();
            this.txtctido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbcl = new System.Windows.Forms.ComboBox();
            this.cmbct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtptanggaldimulai = new System.Windows.Forms.DateTimePicker();
            this.txtnamaproducto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboid1 = new System.Windows.Forms.CheckBox();
            this.cboid2 = new System.Windows.Forms.CheckBox();
            this.btngetdatao = new System.Windows.Forms.Button();
            this.btnupdateo = new System.Windows.Forms.Button();
            this.btndeleteo = new System.Windows.Forms.Button();
            this.btnsaveo = new System.Windows.Forms.Button();
            this.btnnewo = new System.Windows.Forms.Button();
            this.txtoid = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpcategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpclient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tporder.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpcategory);
            this.tabControl1.Controls.Add(this.tpclient);
            this.tabControl1.Controls.Add(this.tporder);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tpcategory
            // 
            this.tpcategory.BackColor = System.Drawing.Color.PapayaWhip;
            this.tpcategory.Controls.Add(this.label8);
            this.tpcategory.Controls.Add(this.groupBox1);
            this.tpcategory.Controls.Add(this.panel1);
            this.tpcategory.Controls.Add(this.txtctid);
            this.tpcategory.Location = new System.Drawing.Point(4, 22);
            this.tpcategory.Name = "tpcategory";
            this.tpcategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpcategory.Size = new System.Drawing.Size(495, 443);
            this.tpcategory.TabIndex = 1;
            this.tpcategory.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Category :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtjenisct);
            this.groupBox1.Location = new System.Drawing.Point(40, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(396, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Jenis :";
            // 
            // txtjenisct
            // 
            this.txtjenisct.Location = new System.Drawing.Point(73, 36);
            this.txtjenisct.Name = "txtjenisct";
            this.txtjenisct.Size = new System.Drawing.Size(286, 20);
            this.txtjenisct.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbctid1);
            this.panel1.Controls.Add(this.cbctid2);
            this.panel1.Controls.Add(this.btngetdatact);
            this.panel1.Controls.Add(this.btnupdatect);
            this.panel1.Controls.Add(this.btndeletect);
            this.panel1.Controls.Add(this.btnsavect);
            this.panel1.Controls.Add(this.btnnewct);
            this.panel1.Location = new System.Drawing.Point(18, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 64);
            this.panel1.TabIndex = 7;
            // 
            // cbctid1
            // 
            this.cbctid1.AutoSize = true;
            this.cbctid1.Checked = true;
            this.cbctid1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbctid1.Location = new System.Drawing.Point(18, 24);
            this.cbctid1.Name = "cbctid1";
            this.cbctid1.Size = new System.Drawing.Size(15, 14);
            this.cbctid1.TabIndex = 6;
            this.cbctid1.UseVisualStyleBackColor = true;
            this.cbctid1.CheckedChanged += new System.EventHandler(this.cbctid1_CheckedChanged_1);
            // 
            // cbctid2
            // 
            this.cbctid2.AutoSize = true;
            this.cbctid2.Location = new System.Drawing.Point(409, 24);
            this.cbctid2.Name = "cbctid2";
            this.cbctid2.Size = new System.Drawing.Size(15, 14);
            this.cbctid2.TabIndex = 5;
            this.cbctid2.UseVisualStyleBackColor = true;
            this.cbctid2.CheckedChanged += new System.EventHandler(this.cbctid1_CheckedChanged);
            // 
            // btngetdatact
            // 
            this.btngetdatact.Location = new System.Drawing.Point(335, 14);
            this.btngetdatact.Name = "btngetdatact";
            this.btngetdatact.Size = new System.Drawing.Size(68, 32);
            this.btngetdatact.TabIndex = 4;
            this.btngetdatact.Text = "&Get Data";
            this.btngetdatact.UseVisualStyleBackColor = true;
            this.btngetdatact.Click += new System.EventHandler(this.btngetdatact_Click);
            // 
            // btnupdatect
            // 
            this.btnupdatect.Location = new System.Drawing.Point(261, 14);
            this.btnupdatect.Name = "btnupdatect";
            this.btnupdatect.Size = new System.Drawing.Size(68, 32);
            this.btnupdatect.TabIndex = 3;
            this.btnupdatect.Text = "&Update";
            this.btnupdatect.UseVisualStyleBackColor = true;
            this.btnupdatect.Click += new System.EventHandler(this.btnupdatect_Click);
            // 
            // btndeletect
            // 
            this.btndeletect.Location = new System.Drawing.Point(187, 14);
            this.btndeletect.Name = "btndeletect";
            this.btndeletect.Size = new System.Drawing.Size(68, 32);
            this.btndeletect.TabIndex = 2;
            this.btndeletect.Text = "&Delete";
            this.btndeletect.UseVisualStyleBackColor = true;
            this.btndeletect.Click += new System.EventHandler(this.btndeletect_Click);
            // 
            // btnsavect
            // 
            this.btnsavect.Location = new System.Drawing.Point(113, 14);
            this.btnsavect.Name = "btnsavect";
            this.btnsavect.Size = new System.Drawing.Size(68, 32);
            this.btnsavect.TabIndex = 1;
            this.btnsavect.Text = "&Save";
            this.btnsavect.UseVisualStyleBackColor = true;
            this.btnsavect.Click += new System.EventHandler(this.btnsavect_Click);
            // 
            // btnnewct
            // 
            this.btnnewct.Location = new System.Drawing.Point(39, 14);
            this.btnnewct.Name = "btnnewct";
            this.btnnewct.Size = new System.Drawing.Size(68, 32);
            this.btnnewct.TabIndex = 0;
            this.btnnewct.Text = "&New";
            this.btnnewct.UseVisualStyleBackColor = true;
            this.btnnewct.Click += new System.EventHandler(this.btnnewct_Click);
            // 
            // txtctid
            // 
            this.txtctid.Location = new System.Drawing.Point(317, 18);
            this.txtctid.Name = "txtctid";
            this.txtctid.Size = new System.Drawing.Size(119, 20);
            this.txtctid.TabIndex = 8;
            this.txtctid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNUMBER_KeyPress);
            // 
            // tpclient
            // 
            this.tpclient.BackColor = System.Drawing.Color.PowderBlue;
            this.tpclient.Controls.Add(this.label9);
            this.tpclient.Controls.Add(this.groupBox2);
            this.tpclient.Controls.Add(this.panel2);
            this.tpclient.Controls.Add(this.txtclid);
            this.tpclient.Location = new System.Drawing.Point(4, 22);
            this.tpclient.Name = "tpclient";
            this.tpclient.Padding = new System.Windows.Forms.Padding(3);
            this.tpclient.Size = new System.Drawing.Size(495, 443);
            this.tpclient.TabIndex = 0;
            this.tpclient.Text = "Client";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID Client :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtemailcl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txttelpcl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtalamatcl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtnamaclient);
            this.groupBox2.Location = new System.Drawing.Point(41, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(396, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email :";
            // 
            // txtemailcl
            // 
            this.txtemailcl.BackColor = System.Drawing.Color.White;
            this.txtemailcl.Location = new System.Drawing.Point(88, 158);
            this.txtemailcl.Name = "txtemailcl";
            this.txtemailcl.Size = new System.Drawing.Size(184, 20);
            this.txtemailcl.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "No. Telp :";
            // 
            // txttelpcl
            // 
            this.txttelpcl.BackColor = System.Drawing.Color.White;
            this.txttelpcl.Location = new System.Drawing.Point(88, 132);
            this.txttelpcl.Name = "txttelpcl";
            this.txttelpcl.Size = new System.Drawing.Size(184, 20);
            this.txttelpcl.TabIndex = 10;
            this.txttelpcl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNUMBER_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alamat :";
            // 
            // txtalamatcl
            // 
            this.txtalamatcl.BackColor = System.Drawing.Color.White;
            this.txtalamatcl.Location = new System.Drawing.Point(88, 62);
            this.txtalamatcl.Multiline = true;
            this.txtalamatcl.Name = "txtalamatcl";
            this.txtalamatcl.Size = new System.Drawing.Size(265, 64);
            this.txtalamatcl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Client :";
            // 
            // txtnamaclient
            // 
            this.txtnamaclient.Location = new System.Drawing.Point(88, 36);
            this.txtnamaclient.Name = "txtnamaclient";
            this.txtnamaclient.Size = new System.Drawing.Size(271, 20);
            this.txtnamaclient.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbclid1);
            this.panel2.Controls.Add(this.cbclid2);
            this.panel2.Controls.Add(this.btngetdatacl);
            this.panel2.Controls.Add(this.btnupdatecl);
            this.panel2.Controls.Add(this.btndeletecl);
            this.panel2.Controls.Add(this.btnsavecl);
            this.panel2.Controls.Add(this.btnnewcl);
            this.panel2.Location = new System.Drawing.Point(8, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 62);
            this.panel2.TabIndex = 7;
            // 
            // cbclid1
            // 
            this.cbclid1.AutoSize = true;
            this.cbclid1.Checked = true;
            this.cbclid1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbclid1.Location = new System.Drawing.Point(20, 24);
            this.cbclid1.Name = "cbclid1";
            this.cbclid1.Size = new System.Drawing.Size(15, 14);
            this.cbclid1.TabIndex = 7;
            this.cbclid1.UseVisualStyleBackColor = true;
            this.cbclid1.CheckedChanged += new System.EventHandler(this.cbclid1_CheckedChanged_1);
            // 
            // cbclid2
            // 
            this.cbclid2.AutoSize = true;
            this.cbclid2.Location = new System.Drawing.Point(415, 24);
            this.cbclid2.Name = "cbclid2";
            this.cbclid2.Size = new System.Drawing.Size(15, 14);
            this.cbclid2.TabIndex = 6;
            this.cbclid2.UseVisualStyleBackColor = true;
            this.cbclid2.CheckedChanged += new System.EventHandler(this.cbclid1_CheckedChanged);
            // 
            // btngetdatacl
            // 
            this.btngetdatacl.Location = new System.Drawing.Point(337, 14);
            this.btngetdatacl.Name = "btngetdatacl";
            this.btngetdatacl.Size = new System.Drawing.Size(68, 32);
            this.btngetdatacl.TabIndex = 4;
            this.btngetdatacl.Text = "&Get Data";
            this.btngetdatacl.UseVisualStyleBackColor = true;
            this.btngetdatacl.Click += new System.EventHandler(this.btngetdatacl_Click);
            // 
            // btnupdatecl
            // 
            this.btnupdatecl.Enabled = false;
            this.btnupdatecl.Location = new System.Drawing.Point(263, 14);
            this.btnupdatecl.Name = "btnupdatecl";
            this.btnupdatecl.Size = new System.Drawing.Size(68, 32);
            this.btnupdatecl.TabIndex = 3;
            this.btnupdatecl.Text = "&Update";
            this.btnupdatecl.UseVisualStyleBackColor = true;
            this.btnupdatecl.Click += new System.EventHandler(this.btnupdatecl_Click);
            // 
            // btndeletecl
            // 
            this.btndeletecl.Enabled = false;
            this.btndeletecl.Location = new System.Drawing.Point(189, 14);
            this.btndeletecl.Name = "btndeletecl";
            this.btndeletecl.Size = new System.Drawing.Size(68, 32);
            this.btndeletecl.TabIndex = 2;
            this.btndeletecl.Text = "&Delete";
            this.btndeletecl.UseVisualStyleBackColor = true;
            this.btndeletecl.Click += new System.EventHandler(this.btndeletecl_Click);
            // 
            // btnsavecl
            // 
            this.btnsavecl.Location = new System.Drawing.Point(115, 14);
            this.btnsavecl.Name = "btnsavecl";
            this.btnsavecl.Size = new System.Drawing.Size(68, 32);
            this.btnsavecl.TabIndex = 1;
            this.btnsavecl.Text = "&Save";
            this.btnsavecl.UseVisualStyleBackColor = true;
            this.btnsavecl.Click += new System.EventHandler(this.btnsavecl_Click);
            // 
            // btnnewcl
            // 
            this.btnnewcl.Location = new System.Drawing.Point(41, 14);
            this.btnnewcl.Name = "btnnewcl";
            this.btnnewcl.Size = new System.Drawing.Size(68, 32);
            this.btnnewcl.TabIndex = 0;
            this.btnnewcl.Text = "&New";
            this.btnnewcl.UseVisualStyleBackColor = true;
            this.btnnewcl.Click += new System.EventHandler(this.btnnewcl_Click);
            // 
            // txtclid
            // 
            this.txtclid.Location = new System.Drawing.Point(318, 17);
            this.txtclid.Name = "txtclid";
            this.txtclid.Size = new System.Drawing.Size(119, 20);
            this.txtclid.TabIndex = 8;
            this.txtclid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNUMBER_KeyPress);
            // 
            // tporder
            // 
            this.tporder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tporder.Controls.Add(this.label10);
            this.tporder.Controls.Add(this.groupBox3);
            this.tporder.Controls.Add(this.panel3);
            this.tporder.Controls.Add(this.txtoid);
            this.tporder.Location = new System.Drawing.Point(4, 22);
            this.tporder.Name = "tporder";
            this.tporder.Padding = new System.Windows.Forms.Padding(3);
            this.tporder.Size = new System.Drawing.Size(495, 443);
            this.tporder.TabIndex = 2;
            this.tporder.Text = "Order";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Order ID :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtclido);
            this.groupBox3.Controls.Add(this.txtctido);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbcl);
            this.groupBox3.Controls.Add(this.cmbct);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtptanggaldimulai);
            this.groupBox3.Controls.Add(this.txtnamaproducto);
            this.groupBox3.Location = new System.Drawing.Point(32, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(396, 185);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product";
            // 
            // txtclido
            // 
            this.txtclido.Location = new System.Drawing.Point(107, 47);
            this.txtclido.Name = "txtclido";
            this.txtclido.ReadOnly = true;
            this.txtclido.Size = new System.Drawing.Size(32, 20);
            this.txtclido.TabIndex = 14;
            // 
            // txtctido
            // 
            this.txtctido.Location = new System.Drawing.Point(107, 20);
            this.txtctido.Name = "txtctido";
            this.txtctido.ReadOnly = true;
            this.txtctido.Size = new System.Drawing.Size(32, 20);
            this.txtctido.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Category :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Client :";
            // 
            // cmbcl
            // 
            this.cmbcl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcl.FormattingEnabled = true;
            this.cmbcl.Location = new System.Drawing.Point(142, 47);
            this.cmbcl.Name = "cmbcl";
            this.cmbcl.Size = new System.Drawing.Size(174, 21);
            this.cmbcl.TabIndex = 5;
            this.cmbcl.SelectedIndexChanged += new System.EventHandler(this.cmbcl_SelectedIndexChanged);
            // 
            // cmbct
            // 
            this.cmbct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbct.FormattingEnabled = true;
            this.cmbct.Location = new System.Drawing.Point(142, 20);
            this.cmbct.Name = "cmbct";
            this.cmbct.Size = new System.Drawing.Size(121, 21);
            this.cmbct.TabIndex = 4;
            this.cmbct.SelectedIndexChanged += new System.EventHandler(this.cmbct_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal Dimulai :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Product :";
            // 
            // dtptanggaldimulai
            // 
            this.dtptanggaldimulai.CustomFormat = "dd-MM-yyyy";
            this.dtptanggaldimulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptanggaldimulai.Location = new System.Drawing.Point(107, 118);
            this.dtptanggaldimulai.Name = "dtptanggaldimulai";
            this.dtptanggaldimulai.Size = new System.Drawing.Size(106, 20);
            this.dtptanggaldimulai.TabIndex = 1;
            // 
            // txtnamaproducto
            // 
            this.txtnamaproducto.Location = new System.Drawing.Point(107, 81);
            this.txtnamaproducto.Name = "txtnamaproducto";
            this.txtnamaproducto.Size = new System.Drawing.Size(271, 20);
            this.txtnamaproducto.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cboid1);
            this.panel3.Controls.Add(this.cboid2);
            this.panel3.Controls.Add(this.btngetdatao);
            this.panel3.Controls.Add(this.btnupdateo);
            this.panel3.Controls.Add(this.btndeleteo);
            this.panel3.Controls.Add(this.btnsaveo);
            this.panel3.Controls.Add(this.btnnewo);
            this.panel3.Location = new System.Drawing.Point(19, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 62);
            this.panel3.TabIndex = 10;
            // 
            // cboid1
            // 
            this.cboid1.AutoSize = true;
            this.cboid1.Checked = true;
            this.cboid1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboid1.Location = new System.Drawing.Point(17, 22);
            this.cboid1.Name = "cboid1";
            this.cboid1.Size = new System.Drawing.Size(15, 14);
            this.cboid1.TabIndex = 7;
            this.cboid1.UseVisualStyleBackColor = true;
            this.cboid1.CheckedChanged += new System.EventHandler(this.cboid1_CheckedChanged_1);
            // 
            // cboid2
            // 
            this.cboid2.AutoSize = true;
            this.cboid2.Location = new System.Drawing.Point(405, 22);
            this.cboid2.Name = "cboid2";
            this.cboid2.Size = new System.Drawing.Size(15, 14);
            this.cboid2.TabIndex = 6;
            this.cboid2.UseVisualStyleBackColor = true;
            this.cboid2.CheckedChanged += new System.EventHandler(this.cboid1_CheckedChanged);
            // 
            // btngetdatao
            // 
            this.btngetdatao.Location = new System.Drawing.Point(331, 12);
            this.btngetdatao.Name = "btngetdatao";
            this.btngetdatao.Size = new System.Drawing.Size(68, 32);
            this.btngetdatao.TabIndex = 4;
            this.btngetdatao.Text = "&Get Data";
            this.btngetdatao.UseVisualStyleBackColor = true;
            this.btngetdatao.Click += new System.EventHandler(this.btngetdatao_Click);
            // 
            // btnupdateo
            // 
            this.btnupdateo.Enabled = false;
            this.btnupdateo.Location = new System.Drawing.Point(257, 12);
            this.btnupdateo.Name = "btnupdateo";
            this.btnupdateo.Size = new System.Drawing.Size(68, 32);
            this.btnupdateo.TabIndex = 3;
            this.btnupdateo.Text = "&Update";
            this.btnupdateo.UseVisualStyleBackColor = true;
            this.btnupdateo.Click += new System.EventHandler(this.btnupdateo_Click);
            // 
            // btndeleteo
            // 
            this.btndeleteo.Enabled = false;
            this.btndeleteo.Location = new System.Drawing.Point(183, 12);
            this.btndeleteo.Name = "btndeleteo";
            this.btndeleteo.Size = new System.Drawing.Size(68, 32);
            this.btndeleteo.TabIndex = 2;
            this.btndeleteo.Text = "&Delete";
            this.btndeleteo.UseVisualStyleBackColor = true;
            this.btndeleteo.Click += new System.EventHandler(this.btndeleteo_Click);
            // 
            // btnsaveo
            // 
            this.btnsaveo.Location = new System.Drawing.Point(109, 12);
            this.btnsaveo.Name = "btnsaveo";
            this.btnsaveo.Size = new System.Drawing.Size(68, 32);
            this.btnsaveo.TabIndex = 1;
            this.btnsaveo.Text = "&Save";
            this.btnsaveo.UseVisualStyleBackColor = true;
            this.btnsaveo.Click += new System.EventHandler(this.btnsaveo_Click);
            // 
            // btnnewo
            // 
            this.btnnewo.Location = new System.Drawing.Point(35, 12);
            this.btnnewo.Name = "btnnewo";
            this.btnnewo.Size = new System.Drawing.Size(68, 32);
            this.btnnewo.TabIndex = 0;
            this.btnnewo.Text = "&New";
            this.btnnewo.UseVisualStyleBackColor = true;
            this.btnnewo.Click += new System.EventHandler(this.btnnewo_Click);
            // 
            // txtoid
            // 
            this.txtoid.Location = new System.Drawing.Point(324, 11);
            this.txtoid.Name = "txtoid";
            this.txtoid.Size = new System.Drawing.Size(86, 20);
            this.txtoid.TabIndex = 11;
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 377);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Order";
            this.Load += new System.EventHandler(this.frmNewProject_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpcategory.ResumeLayout(false);
            this.tpcategory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpclient.ResumeLayout(false);
            this.tpclient.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tporder.ResumeLayout(false);
            this.tporder.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.TabPage tpclient;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtnamaclient;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btngetdatacl;
        internal System.Windows.Forms.Button btnupdatecl;
        internal System.Windows.Forms.Button btndeletecl;
        internal System.Windows.Forms.Button btnsavecl;
        internal System.Windows.Forms.Button btnnewcl;
        internal System.Windows.Forms.TextBox txtclid;
        internal System.Windows.Forms.TabPage tpcategory;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtjenisct;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btngetdatact;
        internal System.Windows.Forms.Button btnupdatect;
        internal System.Windows.Forms.Button btndeletect;
        internal System.Windows.Forms.Button btnsavect;
        internal System.Windows.Forms.Button btnnewct;
        internal System.Windows.Forms.TextBox txtctid;
        internal System.Windows.Forms.TabPage tporder;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtnamaproducto;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btngetdatao;
        internal System.Windows.Forms.Button btnupdateo;
        internal System.Windows.Forms.Button btndeleteo;
        internal System.Windows.Forms.Button btnsaveo;
        internal System.Windows.Forms.Button btnnewo;
        internal System.Windows.Forms.TextBox txtoid;
        internal System.Windows.Forms.TextBox txtalamatcl;
        internal System.Windows.Forms.TextBox txttelpcl;
        internal System.Windows.Forms.TextBox txtemailcl;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dtptanggaldimulai;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cmbcl;
        internal System.Windows.Forms.ComboBox cmbct;
        internal System.Windows.Forms.TextBox txtclido;
        internal System.Windows.Forms.TextBox txtctido;
        internal System.Windows.Forms.CheckBox cbctid1;
        internal System.Windows.Forms.CheckBox cbclid1;
        internal System.Windows.Forms.CheckBox cboid1;
        internal System.Windows.Forms.CheckBox cbctid2;
        internal System.Windows.Forms.CheckBox cbclid2;
        internal System.Windows.Forms.CheckBox cboid2;
    }
}