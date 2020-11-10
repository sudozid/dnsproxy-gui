namespace dnsproxygui
{
    partial class mainForm
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
            this.bogusTA = new System.Windows.Forms.RichTextBox();
            this.tlsconfigGB = new System.Windows.Forms.GroupBox();
            this.tlskeyBT = new System.Windows.Forms.Button();
            this.tlscertBT = new System.Windows.Forms.Button();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.ednsGB = new System.Windows.Forms.GroupBox();
            this.ednsipTB = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.ednsenableCB = new System.Windows.Forms.CheckBox();
            this.dnscryptGB = new System.Windows.Forms.GroupBox();
            this.dnscryptBT = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.logfileBT = new System.Windows.Forms.Button();
            this.Label17 = new System.Windows.Forms.Label();
            this.verboseCB = new System.Windows.Forms.CheckBox();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.noip6CB = new System.Windows.Forms.CheckBox();
            this.ratelimTB = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.refuseanyCB = new System.Windows.Forms.CheckBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.versionBT = new System.Windows.Forms.Button();
            this.commandgenBT = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.dnscryptlistenenableCB = new System.Windows.Forms.CheckBox();
            this.dohlistenenableCB = new System.Windows.Forms.CheckBox();
            this.tlslistenenableCB = new System.Windows.Forms.CheckBox();
            this.quiclistenenableCB = new System.Windows.Forms.CheckBox();
            this.dnslistenenableCB = new System.Windows.Forms.CheckBox();
            this.dnscryptlistenTB = new System.Windows.Forms.TextBox();
            this.dohlistenTB = new System.Windows.Forms.TextBox();
            this.dotlistenTB = new System.Windows.Forms.TextBox();
            this.quiclistenTB = new System.Windows.Forms.TextBox();
            this.dnslistenTB = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.bootstrapTA = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.upstreamTA = new System.Windows.Forms.RichTextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.fastestRB = new System.Windows.Forms.RadioButton();
            this.parralelRB = new System.Windows.Forms.RadioButton();
            this.lbRB = new System.Windows.Forms.RadioButton();
            this.fallbackTA = new System.Windows.Forms.RichTextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.listenIPTB = new System.Windows.Forms.TextBox();
            this.cacheenableCB = new System.Windows.Forms.CheckBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.cachesizeTB = new System.Windows.Forms.TextBox();
            this.minttlTB = new System.Windows.Forms.TextBox();
            this.maxttlTB = new System.Windows.Forms.TextBox();
            this.cacheGB = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.completedLbl = new System.Windows.Forms.Label();
            this.tlsconfigGB.SuspendLayout();
            this.ednsGB.SuspendLayout();
            this.dnscryptGB.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.cacheGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // bogusTA
            // 
            this.bogusTA.Location = new System.Drawing.Point(40, 450);
            this.bogusTA.Name = "bogusTA";
            this.bogusTA.Size = new System.Drawing.Size(211, 57);
            this.bogusTA.TabIndex = 34;
            this.bogusTA.Text = "";
            // 
            // tlsconfigGB
            // 
            this.tlsconfigGB.Controls.Add(this.tlskeyBT);
            this.tlsconfigGB.Controls.Add(this.tlscertBT);
            this.tlsconfigGB.Controls.Add(this.Label14);
            this.tlsconfigGB.Controls.Add(this.Label13);
            this.tlsconfigGB.Enabled = false;
            this.tlsconfigGB.Location = new System.Drawing.Point(282, 240);
            this.tlsconfigGB.Name = "tlsconfigGB";
            this.tlsconfigGB.Size = new System.Drawing.Size(278, 94);
            this.tlsconfigGB.TabIndex = 27;
            this.tlsconfigGB.TabStop = false;
            this.tlsconfigGB.Text = "TLS Configuration";
            // 
            // tlskeyBT
            // 
            this.tlskeyBT.Location = new System.Drawing.Point(141, 53);
            this.tlskeyBT.Name = "tlskeyBT";
            this.tlskeyBT.Size = new System.Drawing.Size(109, 23);
            this.tlskeyBT.TabIndex = 3;
            this.tlskeyBT.Text = "Browse...";
            this.tlskeyBT.UseVisualStyleBackColor = true;
            this.tlskeyBT.Click += new System.EventHandler(this.tlskeyBT_Click);
            // 
            // tlscertBT
            // 
            this.tlscertBT.Location = new System.Drawing.Point(141, 24);
            this.tlscertBT.Name = "tlscertBT";
            this.tlscertBT.Size = new System.Drawing.Size(109, 23);
            this.tlscertBT.TabIndex = 2;
            this.tlscertBT.Text = "Browse...";
            this.tlscertBT.UseVisualStyleBackColor = true;
            this.tlscertBT.Click += new System.EventHandler(this.tlscertBT_Click);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(9, 56);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(124, 17);
            this.Label14.TabIndex = 1;
            this.Label14.Text = "TLS Key Location:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(9, 29);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(126, 17);
            this.Label13.TabIndex = 0;
            this.Label13.Text = "TLS Cert Location:";
            // 
            // ednsGB
            // 
            this.ednsGB.Controls.Add(this.ednsipTB);
            this.ednsGB.Controls.Add(this.Label15);
            this.ednsGB.Enabled = false;
            this.ednsGB.Location = new System.Drawing.Point(282, 430);
            this.ednsGB.Name = "ednsGB";
            this.ednsGB.Size = new System.Drawing.Size(278, 98);
            this.ednsGB.TabIndex = 28;
            this.ednsGB.TabStop = false;
            this.ednsGB.Text = "EDNS Client Subset";
            // 
            // ednsipTB
            // 
            this.ednsipTB.Location = new System.Drawing.Point(141, 43);
            this.ednsipTB.Name = "ednsipTB";
            this.ednsipTB.Size = new System.Drawing.Size(109, 22);
            this.ednsipTB.TabIndex = 2;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(12, 46);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(122, 17);
            this.Label15.TabIndex = 1;
            this.Label15.Text = "EDNS IP Address:";
            // 
            // ednsenableCB
            // 
            this.ednsenableCB.AutoSize = true;
            this.ednsenableCB.Location = new System.Drawing.Point(430, 430);
            this.ednsenableCB.Name = "ednsenableCB";
            this.ednsenableCB.Size = new System.Drawing.Size(18, 17);
            this.ednsenableCB.TabIndex = 0;
            this.ednsenableCB.UseVisualStyleBackColor = true;
            this.ednsenableCB.CheckedChanged += new System.EventHandler(this.ednsenableCB_CheckedChanged);
            // 
            // dnscryptGB
            // 
            this.dnscryptGB.Controls.Add(this.dnscryptBT);
            this.dnscryptGB.Controls.Add(this.Label16);
            this.dnscryptGB.Enabled = false;
            this.dnscryptGB.Location = new System.Drawing.Point(282, 341);
            this.dnscryptGB.Name = "dnscryptGB";
            this.dnscryptGB.Size = new System.Drawing.Size(274, 83);
            this.dnscryptGB.TabIndex = 29;
            this.dnscryptGB.TabStop = false;
            this.dnscryptGB.Text = "DNSCrypt Configuration:";
            // 
            // dnscryptBT
            // 
            this.dnscryptBT.Location = new System.Drawing.Point(141, 33);
            this.dnscryptBT.Name = "dnscryptBT";
            this.dnscryptBT.Size = new System.Drawing.Size(109, 23);
            this.dnscryptBT.TabIndex = 1;
            this.dnscryptBT.Text = "Browse...";
            this.dnscryptBT.UseVisualStyleBackColor = true;
            this.dnscryptBT.Click += new System.EventHandler(this.dnscryptBT_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(15, 33);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(118, 17);
            this.Label16.TabIndex = 0;
            this.Label16.Text = "DNSCrypt Config:";
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.logfileBT);
            this.GroupBox7.Controls.Add(this.Label17);
            this.GroupBox7.Controls.Add(this.verboseCB);
            this.GroupBox7.Location = new System.Drawing.Point(567, 320);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(206, 91);
            this.GroupBox7.TabIndex = 30;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "Logs";
            // 
            // logfileBT
            // 
            this.logfileBT.Location = new System.Drawing.Point(109, 54);
            this.logfileBT.Name = "logfileBT";
            this.logfileBT.Size = new System.Drawing.Size(74, 23);
            this.logfileBT.TabIndex = 2;
            this.logfileBT.Text = "Browse...";
            this.logfileBT.UseVisualStyleBackColor = true;
            this.logfileBT.Click += new System.EventHandler(this.logfileBT_Click);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(5, 57);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(95, 17);
            this.Label17.TabIndex = 1;
            this.Label17.Text = "Log File Path:";
            // 
            // verboseCB
            // 
            this.verboseCB.AutoSize = true;
            this.verboseCB.Location = new System.Drawing.Point(8, 30);
            this.verboseCB.Name = "verboseCB";
            this.verboseCB.Size = new System.Drawing.Size(83, 21);
            this.verboseCB.TabIndex = 0;
            this.verboseCB.Text = "Verbose";
            this.verboseCB.UseVisualStyleBackColor = true;
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.noip6CB);
            this.GroupBox8.Controls.Add(this.ratelimTB);
            this.GroupBox8.Controls.Add(this.Label18);
            this.GroupBox8.Controls.Add(this.refuseanyCB);
            this.GroupBox8.Location = new System.Drawing.Point(567, 415);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(206, 113);
            this.GroupBox8.TabIndex = 31;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "Misc";
            // 
            // noip6CB
            // 
            this.noip6CB.AutoSize = true;
            this.noip6CB.Location = new System.Drawing.Point(8, 24);
            this.noip6CB.Name = "noip6CB";
            this.noip6CB.Size = new System.Drawing.Size(158, 21);
            this.noip6CB.TabIndex = 3;
            this.noip6CB.Text = "Disable AAAA (IPv6)";
            this.noip6CB.UseVisualStyleBackColor = true;
            // 
            // ratelimTB
            // 
            this.ratelimTB.Location = new System.Drawing.Point(90, 74);
            this.ratelimTB.Name = "ratelimTB";
            this.ratelimTB.Size = new System.Drawing.Size(100, 22);
            this.ratelimTB.TabIndex = 2;
            this.ratelimTB.Leave += new System.EventHandler(this.cachesizeTB_Leave);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(6, 77);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(75, 17);
            this.Label18.TabIndex = 1;
            this.Label18.Text = "Rate Limit:";
            // 
            // refuseanyCB
            // 
            this.refuseanyCB.AutoSize = true;
            this.refuseanyCB.Location = new System.Drawing.Point(8, 48);
            this.refuseanyCB.Name = "refuseanyCB";
            this.refuseanyCB.Size = new System.Drawing.Size(166, 21);
            this.refuseanyCB.TabIndex = 0;
            this.refuseanyCB.Text = "Refuse ANY requests";
            this.refuseanyCB.UseVisualStyleBackColor = true;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(37, 429);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(129, 17);
            this.Label19.TabIndex = 33;
            this.Label19.Text = "Bogus NXDOMAIN:";
            // 
            // versionBT
            // 
            this.versionBT.Location = new System.Drawing.Point(40, 531);
            this.versionBT.Name = "versionBT";
            this.versionBT.Size = new System.Drawing.Size(733, 29);
            this.versionBT.TabIndex = 32;
            this.versionBT.Text = "dnsproxy Version";
            this.versionBT.UseVisualStyleBackColor = true;
            this.versionBT.Click += new System.EventHandler(this.versionBT_Click);
            // 
            // commandgenBT
            // 
            this.commandgenBT.Location = new System.Drawing.Point(788, 50);
            this.commandgenBT.Name = "commandgenBT";
            this.commandgenBT.Size = new System.Drawing.Size(97, 266);
            this.commandgenBT.TabIndex = 35;
            this.commandgenBT.Text = "Generate Command";
            this.commandgenBT.UseVisualStyleBackColor = true;
            this.commandgenBT.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.dnscryptlistenenableCB);
            this.GroupBox1.Controls.Add(this.dohlistenenableCB);
            this.GroupBox1.Controls.Add(this.tlslistenenableCB);
            this.GroupBox1.Controls.Add(this.quiclistenenableCB);
            this.GroupBox1.Controls.Add(this.dnslistenenableCB);
            this.GroupBox1.Controls.Add(this.dnscryptlistenTB);
            this.GroupBox1.Controls.Add(this.dohlistenTB);
            this.GroupBox1.Controls.Add(this.dotlistenTB);
            this.GroupBox1.Controls.Add(this.quiclistenTB);
            this.GroupBox1.Controls.Add(this.dnslistenTB);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(282, 42);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(278, 191);
            this.GroupBox1.TabIndex = 22;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "DNS Listen Ports";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(214, 8);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 17);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Enable?";
            // 
            // dnscryptlistenenableCB
            // 
            this.dnscryptlistenenableCB.AutoSize = true;
            this.dnscryptlistenenableCB.Location = new System.Drawing.Point(232, 147);
            this.dnscryptlistenenableCB.Name = "dnscryptlistenenableCB";
            this.dnscryptlistenenableCB.Size = new System.Drawing.Size(18, 17);
            this.dnscryptlistenenableCB.TabIndex = 14;
            this.dnscryptlistenenableCB.UseVisualStyleBackColor = true;
            this.dnscryptlistenenableCB.CheckedChanged += new System.EventHandler(this.dnscryptlistenenableCB_CheckedChanged);
            // 
            // dohlistenenableCB
            // 
            this.dohlistenenableCB.AutoSize = true;
            this.dohlistenenableCB.Location = new System.Drawing.Point(232, 117);
            this.dohlistenenableCB.Name = "dohlistenenableCB";
            this.dohlistenenableCB.Size = new System.Drawing.Size(18, 17);
            this.dohlistenenableCB.TabIndex = 13;
            this.dohlistenenableCB.UseVisualStyleBackColor = true;
            this.dohlistenenableCB.CheckedChanged += new System.EventHandler(this.dohlistenenableCB_CheckedChanged);
            // 
            // tlslistenenableCB
            // 
            this.tlslistenenableCB.AutoSize = true;
            this.tlslistenenableCB.Location = new System.Drawing.Point(232, 88);
            this.tlslistenenableCB.Name = "tlslistenenableCB";
            this.tlslistenenableCB.Size = new System.Drawing.Size(18, 17);
            this.tlslistenenableCB.TabIndex = 12;
            this.tlslistenenableCB.UseVisualStyleBackColor = true;
            this.tlslistenenableCB.CheckedChanged += new System.EventHandler(this.tlslistenenableCB_CheckedChanged);
            // 
            // quiclistenenableCB
            // 
            this.quiclistenenableCB.AutoSize = true;
            this.quiclistenenableCB.Location = new System.Drawing.Point(232, 60);
            this.quiclistenenableCB.Name = "quiclistenenableCB";
            this.quiclistenenableCB.Size = new System.Drawing.Size(18, 17);
            this.quiclistenenableCB.TabIndex = 11;
            this.quiclistenenableCB.UseVisualStyleBackColor = true;
            this.quiclistenenableCB.CheckedChanged += new System.EventHandler(this.quiclistenenableCB_CheckedChanged);
            // 
            // dnslistenenableCB
            // 
            this.dnslistenenableCB.AutoSize = true;
            this.dnslistenenableCB.Checked = true;
            this.dnslistenenableCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dnslistenenableCB.Location = new System.Drawing.Point(232, 32);
            this.dnslistenenableCB.Name = "dnslistenenableCB";
            this.dnslistenenableCB.Size = new System.Drawing.Size(18, 17);
            this.dnslistenenableCB.TabIndex = 10;
            this.dnslistenenableCB.UseVisualStyleBackColor = true;
            this.dnslistenenableCB.CheckedChanged += new System.EventHandler(this.dnslistenenableCB_CheckedChanged);
            // 
            // dnscryptlistenTB
            // 
            this.dnscryptlistenTB.Enabled = false;
            this.dnscryptlistenTB.Location = new System.Drawing.Point(126, 143);
            this.dnscryptlistenTB.Name = "dnscryptlistenTB";
            this.dnscryptlistenTB.Size = new System.Drawing.Size(100, 22);
            this.dnscryptlistenTB.TabIndex = 9;
            this.dnscryptlistenTB.Leave += new System.EventHandler(this.listenTB_Leave);
            // 
            // dohlistenTB
            // 
            this.dohlistenTB.Enabled = false;
            this.dohlistenTB.Location = new System.Drawing.Point(126, 116);
            this.dohlistenTB.Name = "dohlistenTB";
            this.dohlistenTB.Size = new System.Drawing.Size(100, 22);
            this.dohlistenTB.TabIndex = 8;
            this.dohlistenTB.Leave += new System.EventHandler(this.listenTB_Leave);
            // 
            // dotlistenTB
            // 
            this.dotlistenTB.Enabled = false;
            this.dotlistenTB.Location = new System.Drawing.Point(126, 84);
            this.dotlistenTB.Name = "dotlistenTB";
            this.dotlistenTB.Size = new System.Drawing.Size(100, 22);
            this.dotlistenTB.TabIndex = 7;
            this.dotlistenTB.Leave += new System.EventHandler(this.listenTB_Leave);
            // 
            // quiclistenTB
            // 
            this.quiclistenTB.Enabled = false;
            this.quiclistenTB.Location = new System.Drawing.Point(126, 56);
            this.quiclistenTB.Name = "quiclistenTB";
            this.quiclistenTB.Size = new System.Drawing.Size(100, 22);
            this.quiclistenTB.TabIndex = 6;
            this.quiclistenTB.Leave += new System.EventHandler(this.listenTB_Leave);
            // 
            // dnslistenTB
            // 
            this.dnslistenTB.Location = new System.Drawing.Point(126, 28);
            this.dnslistenTB.Name = "dnslistenTB";
            this.dnslistenTB.Size = new System.Drawing.Size(100, 22);
            this.dnslistenTB.TabIndex = 5;
            this.dnslistenTB.Text = "53";
            this.dnslistenTB.Leave += new System.EventHandler(this.listenTB_Leave);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 147);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(74, 17);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "DNSCrypt:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(5, 118);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(123, 17);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "DNS over HTTPS:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 89);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(103, 17);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "DNS over TLS:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 61);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(110, 17);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "DNS over QUIC:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 33);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 17);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Regular DNS:";
            // 
            // bootstrapTA
            // 
            this.bootstrapTA.Location = new System.Drawing.Point(37, 264);
            this.bootstrapTA.Name = "bootstrapTA";
            this.bootstrapTA.Size = new System.Drawing.Size(214, 52);
            this.bootstrapTA.TabIndex = 21;
            this.bootstrapTA.Text = "1.1.1.1\n9.9.9.9";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(34, 237);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(173, 17);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Bootstrap DNS Resolvers:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(37, 70);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(173, 17);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Upstream DNS Resolvers:";
            // 
            // upstreamTA
            // 
            this.upstreamTA.Location = new System.Drawing.Point(37, 95);
            this.upstreamTA.Name = "upstreamTA";
            this.upstreamTA.Size = new System.Drawing.Size(217, 129);
            this.upstreamTA.TabIndex = 18;
            this.upstreamTA.Text = "tls://1.1.1.1\n\ntls://9.9.9.9\n\ntls://8.8.8.8\n\nhttps://doh.opendns.com/dns-query";
            this.upstreamTA.Leave += new System.EventHandler(this.upstreamTA_Leave);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.fastestRB);
            this.GroupBox2.Controls.Add(this.parralelRB);
            this.GroupBox2.Controls.Add(this.lbRB);
            this.GroupBox2.Location = new System.Drawing.Point(566, 42);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(207, 130);
            this.GroupBox2.TabIndex = 23;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Query Method";
            // 
            // fastestRB
            // 
            this.fastestRB.AutoSize = true;
            this.fastestRB.Location = new System.Drawing.Point(18, 81);
            this.fastestRB.Name = "fastestRB";
            this.fastestRB.Size = new System.Drawing.Size(131, 21);
            this.fastestRB.TabIndex = 2;
            this.fastestRB.Text = "Fastest Address";
            this.fastestRB.UseVisualStyleBackColor = true;
            // 
            // parralelRB
            // 
            this.parralelRB.AutoSize = true;
            this.parralelRB.Location = new System.Drawing.Point(18, 53);
            this.parralelRB.Name = "parralelRB";
            this.parralelRB.Size = new System.Drawing.Size(121, 21);
            this.parralelRB.TabIndex = 1;
            this.parralelRB.Text = "Parralel Query";
            this.parralelRB.UseVisualStyleBackColor = true;
            // 
            // lbRB
            // 
            this.lbRB.AutoSize = true;
            this.lbRB.Checked = true;
            this.lbRB.Location = new System.Drawing.Point(18, 25);
            this.lbRB.Name = "lbRB";
            this.lbRB.Size = new System.Drawing.Size(127, 21);
            this.lbRB.TabIndex = 0;
            this.lbRB.TabStop = true;
            this.lbRB.Text = "Load Balancing";
            this.lbRB.UseVisualStyleBackColor = true;
            // 
            // fallbackTA
            // 
            this.fallbackTA.Location = new System.Drawing.Point(40, 359);
            this.fallbackTA.Name = "fallbackTA";
            this.fallbackTA.Size = new System.Drawing.Size(214, 52);
            this.fallbackTA.TabIndex = 25;
            this.fallbackTA.Text = "1.0.0.1\n8.8.4.4";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(37, 330);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(131, 17);
            this.Label9.TabIndex = 24;
            this.Label9.Text = "Fallback Resolvers:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 17);
            this.label20.TabIndex = 36;
            this.label20.Text = "Listen IP:";
            // 
            // listenIPTB
            // 
            this.listenIPTB.Location = new System.Drawing.Point(107, 39);
            this.listenIPTB.Name = "listenIPTB";
            this.listenIPTB.Size = new System.Drawing.Size(144, 22);
            this.listenIPTB.TabIndex = 37;
            this.listenIPTB.Text = "127.0.0.1";
            // 
            // cacheenableCB
            // 
            this.cacheenableCB.AutoSize = true;
            this.cacheenableCB.Location = new System.Drawing.Point(620, 182);
            this.cacheenableCB.Name = "cacheenableCB";
            this.cacheenableCB.Size = new System.Drawing.Size(18, 17);
            this.cacheenableCB.TabIndex = 3;
            this.cacheenableCB.UseVisualStyleBackColor = true;
            this.cacheenableCB.CheckedChanged += new System.EventHandler(this.cacheenableCB_CheckedChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 29);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(83, 17);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "Cache Size:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(6, 62);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(97, 17);
            this.Label11.TabIndex = 5;
            this.Label11.Text = "Minimum TTL:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(6, 92);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(100, 17);
            this.Label12.TabIndex = 6;
            this.Label12.Text = "Maximum TTL:";
            // 
            // cachesizeTB
            // 
            this.cachesizeTB.Location = new System.Drawing.Point(108, 26);
            this.cachesizeTB.Name = "cachesizeTB";
            this.cachesizeTB.Size = new System.Drawing.Size(75, 22);
            this.cachesizeTB.TabIndex = 7;
            this.cachesizeTB.Leave += new System.EventHandler(this.cachesizeTB_Leave);
            // 
            // minttlTB
            // 
            this.minttlTB.Location = new System.Drawing.Point(109, 59);
            this.minttlTB.Name = "minttlTB";
            this.minttlTB.Size = new System.Drawing.Size(74, 22);
            this.minttlTB.TabIndex = 8;
            this.minttlTB.Leave += new System.EventHandler(this.cachesizeTB_Leave);
            // 
            // maxttlTB
            // 
            this.maxttlTB.Location = new System.Drawing.Point(108, 89);
            this.maxttlTB.Name = "maxttlTB";
            this.maxttlTB.Size = new System.Drawing.Size(75, 22);
            this.maxttlTB.TabIndex = 9;
            this.maxttlTB.Leave += new System.EventHandler(this.cachesizeTB_Leave);
            // 
            // cacheGB
            // 
            this.cacheGB.Controls.Add(this.maxttlTB);
            this.cacheGB.Controls.Add(this.minttlTB);
            this.cacheGB.Controls.Add(this.cachesizeTB);
            this.cacheGB.Controls.Add(this.Label12);
            this.cacheGB.Controls.Add(this.Label11);
            this.cacheGB.Controls.Add(this.Label10);
            this.cacheGB.Enabled = false;
            this.cacheGB.Location = new System.Drawing.Point(567, 181);
            this.cacheGB.Name = "cacheGB";
            this.cacheGB.Size = new System.Drawing.Size(207, 135);
            this.cacheGB.TabIndex = 26;
            this.cacheGB.TabStop = false;
            this.cacheGB.Text = "Cache";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 201);
            this.button1.TabIndex = 38;
            this.button1.Text = "Download dnsproxy.zip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(788, 324);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(97, 23);
            this.downloadProgressBar.TabIndex = 39;
            this.downloadProgressBar.Visible = false;
            // 
            // completedLbl
            // 
            this.completedLbl.AutoSize = true;
            this.completedLbl.Location = new System.Drawing.Point(800, 328);
            this.completedLbl.Name = "completedLbl";
            this.completedLbl.Size = new System.Drawing.Size(75, 17);
            this.completedLbl.TabIndex = 40;
            this.completedLbl.Text = "Completed";
            this.completedLbl.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 569);
            this.Controls.Add(this.completedLbl);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cacheenableCB);
            this.Controls.Add(this.ednsenableCB);
            this.Controls.Add(this.listenIPTB);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.bogusTA);
            this.Controls.Add(this.tlsconfigGB);
            this.Controls.Add(this.cacheGB);
            this.Controls.Add(this.ednsGB);
            this.Controls.Add(this.dnscryptGB);
            this.Controls.Add(this.GroupBox7);
            this.Controls.Add(this.GroupBox8);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.versionBT);
            this.Controls.Add(this.commandgenBT);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.bootstrapTA);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.upstreamTA);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.fallbackTA);
            this.Controls.Add(this.Label9);
            this.Name = "mainForm";
            this.Text = " DNSProxy Command Gen";
            this.tlsconfigGB.ResumeLayout(false);
            this.tlsconfigGB.PerformLayout();
            this.ednsGB.ResumeLayout(false);
            this.ednsGB.PerformLayout();
            this.dnscryptGB.ResumeLayout(false);
            this.dnscryptGB.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.cacheGB.ResumeLayout(false);
            this.cacheGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RichTextBox bogusTA;
        internal System.Windows.Forms.GroupBox tlsconfigGB;
        internal System.Windows.Forms.Button tlskeyBT;
        internal System.Windows.Forms.Button tlscertBT;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox ednsGB;
        internal System.Windows.Forms.TextBox ednsipTB;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.CheckBox ednsenableCB;
        internal System.Windows.Forms.GroupBox dnscryptGB;
        internal System.Windows.Forms.Button dnscryptBT;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.Button logfileBT;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.CheckBox verboseCB;
        internal System.Windows.Forms.GroupBox GroupBox8;
        internal System.Windows.Forms.CheckBox noip6CB;
        internal System.Windows.Forms.TextBox ratelimTB;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.CheckBox refuseanyCB;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Button versionBT;
        internal System.Windows.Forms.Button commandgenBT;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.CheckBox dnscryptlistenenableCB;
        internal System.Windows.Forms.CheckBox dohlistenenableCB;
        internal System.Windows.Forms.CheckBox tlslistenenableCB;
        internal System.Windows.Forms.CheckBox quiclistenenableCB;
        internal System.Windows.Forms.CheckBox dnslistenenableCB;
        internal System.Windows.Forms.TextBox dnscryptlistenTB;
        internal System.Windows.Forms.TextBox dohlistenTB;
        internal System.Windows.Forms.TextBox dotlistenTB;
        internal System.Windows.Forms.TextBox quiclistenTB;
        internal System.Windows.Forms.TextBox dnslistenTB;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RichTextBox bootstrapTA;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RichTextBox upstreamTA;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton fastestRB;
        internal System.Windows.Forms.RadioButton parralelRB;
        internal System.Windows.Forms.RadioButton lbRB;
        internal System.Windows.Forms.RichTextBox fallbackTA;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox listenIPTB;
        internal System.Windows.Forms.CheckBox cacheenableCB;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox cachesizeTB;
        internal System.Windows.Forms.TextBox minttlTB;
        internal System.Windows.Forms.TextBox maxttlTB;
        internal System.Windows.Forms.GroupBox cacheGB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.Label completedLbl;

    }
}

