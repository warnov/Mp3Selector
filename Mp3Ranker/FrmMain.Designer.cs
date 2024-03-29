﻿namespace Mp3Ranker
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.TsmLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.TmiNewLibray = new System.Windows.Forms.ToolStripMenuItem();
            this.TmiLoadLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmiNewSession = new System.Windows.Forms.ToolStripMenuItem();
            this.TmiLoadSession = new System.Windows.Forms.ToolStripMenuItem();
            this.TmiRebuildSessio = new System.Windows.Forms.ToolStripMenuItem();
            this.FbdMain = new System.Windows.Forms.FolderBrowserDialog();
            this.WMPMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnHop = new System.Windows.Forms.Button();
            this.btnJump = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.TmrMain = new System.Windows.Forms.Timer(this.components);
            this.SstMain = new System.Windows.Forms.StatusStrip();
            this.TssMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.lblArtistAlbum = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.SfdMain = new System.Windows.Forms.SaveFileDialog();
            this.OfdMain = new System.Windows.Forms.OpenFileDialog();
            this.TbrRanking = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TbrHappiness = new System.Windows.Forms.TrackBar();
            this.TbrSadness = new System.Windows.Forms.TrackBar();
            this.TbrEnergetic = new System.Windows.Forms.TrackBar();
            this.TbrAnger = new System.Windows.Forms.TrackBar();
            this.TbrSleepy = new System.Windows.Forms.TrackBar();
            this.TbrHeavyCar = new System.Windows.Forms.TrackBar();
            this.TbrCar = new System.Windows.Forms.TrackBar();
            this.TbrCultured = new System.Windows.Forms.TrackBar();
            this.TbrRock = new System.Windows.Forms.TrackBar();
            this.TbrMinimal = new System.Windows.Forms.TrackBar();
            this.TbrElectro = new System.Windows.Forms.TrackBar();
            this.TbrRockWFriends = new System.Windows.Forms.TrackBar();
            this.TbrFolk = new System.Windows.Forms.TrackBar();
            this.TbrClassic = new System.Windows.Forms.TrackBar();
            this.TbrJazz = new System.Windows.Forms.TrackBar();
            this.TbrPop = new System.Windows.Forms.TrackBar();
            this.TbrNineties = new System.Windows.Forms.TrackBar();
            this.TbrSpanish = new System.Windows.Forms.TrackBar();
            this.TbrInstrumental = new System.Windows.Forms.TrackBar();
            this.TbrFocus = new System.Windows.Forms.TrackBar();
            this.BtnSkip = new System.Windows.Forms.Button();
            this.BtnDoubleJump = new System.Windows.Forms.Button();
            this.BtnQuadJump = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnContinueSession = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnCarPlaylist = new System.Windows.Forms.Button();
            this.btnElitePlayList = new System.Windows.Forms.Button();
            this.nudRanking = new System.Windows.Forms.NumericUpDown();
            this.btnRankingPlaylist = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txtListSize = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbxDrives = new System.Windows.Forms.ComboBox();
            this.lblDestiny = new System.Windows.Forms.Label();
            this.btnRefreshDrives = new System.Windows.Forms.Button();
            this.btnExportPlaylist = new System.Windows.Forms.Button();
            this.MnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMain)).BeginInit();
            this.SstMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbrRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrHappiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrSadness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrEnergetic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrAnger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrSleepy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrHeavyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrCultured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrMinimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrElectro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrRockWFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrFolk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrClassic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrJazz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrNineties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrSpanish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrInstrumental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.BackColor = System.Drawing.Color.Lime;
            this.MnuMain.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold);
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmLibrary,
            this.sessionToolStripMenuItem});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(823, 24);
            this.MnuMain.TabIndex = 0;
            this.MnuMain.Text = "Library";
            // 
            // TsmLibrary
            // 
            this.TsmLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TmiNewLibray,
            this.TmiLoadLibrary});
            this.TsmLibrary.Name = "TsmLibrary";
            this.TsmLibrary.Size = new System.Drawing.Size(68, 20);
            this.TsmLibrary.Text = "&Library";
            // 
            // TmiNewLibray
            // 
            this.TmiNewLibray.BackColor = System.Drawing.Color.Lime;
            this.TmiNewLibray.ForeColor = System.Drawing.Color.Black;
            this.TmiNewLibray.Name = "TmiNewLibray";
            this.TmiNewLibray.Size = new System.Drawing.Size(102, 22);
            this.TmiNewLibray.Text = "&New";
            this.TmiNewLibray.Click += new System.EventHandler(this.TmiNewLibray_Click);
            // 
            // TmiLoadLibrary
            // 
            this.TmiLoadLibrary.BackColor = System.Drawing.Color.Lime;
            this.TmiLoadLibrary.Name = "TmiLoadLibrary";
            this.TmiLoadLibrary.Size = new System.Drawing.Size(102, 22);
            this.TmiLoadLibrary.Text = "&Load";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TmiNewSession,
            this.TmiLoadSession,
            this.TmiRebuildSessio});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.sessionToolStripMenuItem.Text = "&Session";
            // 
            // TmiNewSession
            // 
            this.TmiNewSession.BackColor = System.Drawing.Color.Lime;
            this.TmiNewSession.Name = "TmiNewSession";
            this.TmiNewSession.Size = new System.Drawing.Size(123, 22);
            this.TmiNewSession.Text = "&New";
            this.TmiNewSession.Click += new System.EventHandler(this.TmiNewSession_Click);
            // 
            // TmiLoadSession
            // 
            this.TmiLoadSession.BackColor = System.Drawing.Color.Lime;
            this.TmiLoadSession.Name = "TmiLoadSession";
            this.TmiLoadSession.Size = new System.Drawing.Size(123, 22);
            this.TmiLoadSession.Text = "&Load";
            this.TmiLoadSession.Click += new System.EventHandler(this.TmiLoadSession_Click);
            // 
            // TmiRebuildSessio
            // 
            this.TmiRebuildSessio.BackColor = System.Drawing.Color.Lime;
            this.TmiRebuildSessio.Name = "TmiRebuildSessio";
            this.TmiRebuildSessio.Size = new System.Drawing.Size(123, 22);
            this.TmiRebuildSessio.Text = "&Rebuild";
            this.TmiRebuildSessio.Click += new System.EventHandler(this.TmiRebuildSession_Click);
            // 
            // FbdMain
            // 
            this.FbdMain.Description = "Choose your music folder";
            // 
            // WMPMain
            // 
            this.WMPMain.Enabled = true;
            this.WMPMain.Location = new System.Drawing.Point(638, 12);
            this.WMPMain.Name = "WMPMain";
            this.WMPMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPMain.OcxState")));
            this.WMPMain.Size = new System.Drawing.Size(75, 23);
            this.WMPMain.TabIndex = 1;
            this.WMPMain.Visible = false;
            this.WMPMain.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WMPMain_PlayStateChange);
            // 
            // btnHop
            // 
            this.btnHop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHop.Location = new System.Drawing.Point(454, 125);
            this.btnHop.Name = "btnHop";
            this.btnHop.Size = new System.Drawing.Size(39, 32);
            this.btnHop.TabIndex = 18;
            this.btnHop.Text = ">>5";
            this.btnHop.UseVisualStyleBackColor = true;
            this.btnHop.Click += new System.EventHandler(this.BtnHop_Click);
            // 
            // btnJump
            // 
            this.btnJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJump.Location = new System.Drawing.Point(498, 125);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(39, 32);
            this.btnJump.TabIndex = 17;
            this.btnJump.Text = ">>15";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.BtnJump_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Location = new System.Drawing.Point(375, 125);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(34, 32);
            this.BtnPlay.TabIndex = 15;
            this.BtnPlay.Text = "►";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // TmrMain
            // 
            this.TmrMain.Interval = 1000;
            this.TmrMain.Tick += new System.EventHandler(this.TmrMain_Tick);
            // 
            // SstMain
            // 
            this.SstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssMain,
            this.TssCount});
            this.SstMain.Location = new System.Drawing.Point(0, 507);
            this.SstMain.Name = "SstMain";
            this.SstMain.Size = new System.Drawing.Size(823, 22);
            this.SstMain.TabIndex = 19;
            this.SstMain.Text = "Ready";
            // 
            // TssMain
            // 
            this.TssMain.Name = "TssMain";
            this.TssMain.Size = new System.Drawing.Size(39, 17);
            this.TssMain.Text = "Ready";
            // 
            // TssCount
            // 
            this.TssCount.Name = "TssCount";
            this.TssCount.Size = new System.Drawing.Size(0, 17);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPath.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPath.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPath.Location = new System.Drawing.Point(12, 101);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(342, 10);
            this.txtBoxPath.TabIndex = 26;
            // 
            // lblArtistAlbum
            // 
            this.lblArtistAlbum.AutoSize = true;
            this.lblArtistAlbum.Location = new System.Drawing.Point(11, 69);
            this.lblArtistAlbum.Name = "lblArtistAlbum";
            this.lblArtistAlbum.Size = new System.Drawing.Size(0, 13);
            this.lblArtistAlbum.TabIndex = 25;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrack.Location = new System.Drawing.Point(10, 33);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(0, 24);
            this.lblTrack.TabIndex = 24;
            // 
            // OfdMain
            // 
            this.OfdMain.FileName = "openFileDialog1";
            // 
            // TbrRanking
            // 
            this.TbrRanking.Location = new System.Drawing.Point(12, 124);
            this.TbrRanking.Maximum = 100;
            this.TbrRanking.Name = "TbrRanking";
            this.TbrRanking.Size = new System.Drawing.Size(342, 45);
            this.TbrRanking.TabIndex = 27;
            this.TbrRanking.Tag = "0";
            this.TbrRanking.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(22, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Happiness";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(22, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Anger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(22, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cultured";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(212, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "HeavyCar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(212, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "RockWFriends";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(415, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Rock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(415, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Jazz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(618, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Folk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(618, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Nineties";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(22, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Sadness";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(22, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Energetic";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(212, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Car";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(212, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Sleepy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(212, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Electro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(415, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Pop";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(415, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Classic";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(617, 310);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Focus";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(415, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Minimal";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Lime;
            this.label20.Location = new System.Drawing.Point(617, 370);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Spanish";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(618, 340);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Instrumental";
            // 
            // TbrHappiness
            // 
            this.TbrHappiness.Location = new System.Drawing.Point(98, 250);
            this.TbrHappiness.Name = "TbrHappiness";
            this.TbrHappiness.Size = new System.Drawing.Size(104, 45);
            this.TbrHappiness.TabIndex = 48;
            this.TbrHappiness.Tag = "1";
            this.TbrHappiness.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrSadness
            // 
            this.TbrSadness.Location = new System.Drawing.Point(98, 278);
            this.TbrSadness.Name = "TbrSadness";
            this.TbrSadness.Size = new System.Drawing.Size(104, 45);
            this.TbrSadness.TabIndex = 49;
            this.TbrSadness.Tag = "2";
            this.TbrSadness.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrEnergetic
            // 
            this.TbrEnergetic.Location = new System.Drawing.Point(98, 340);
            this.TbrEnergetic.Name = "TbrEnergetic";
            this.TbrEnergetic.Size = new System.Drawing.Size(104, 45);
            this.TbrEnergetic.TabIndex = 51;
            this.TbrEnergetic.Tag = "4";
            this.TbrEnergetic.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrAnger
            // 
            this.TbrAnger.Location = new System.Drawing.Point(98, 308);
            this.TbrAnger.Name = "TbrAnger";
            this.TbrAnger.Size = new System.Drawing.Size(104, 45);
            this.TbrAnger.TabIndex = 50;
            this.TbrAnger.Tag = "3";
            this.TbrAnger.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrSleepy
            // 
            this.TbrSleepy.Location = new System.Drawing.Point(288, 310);
            this.TbrSleepy.Name = "TbrSleepy";
            this.TbrSleepy.Size = new System.Drawing.Size(104, 45);
            this.TbrSleepy.TabIndex = 55;
            this.TbrSleepy.Tag = "8";
            this.TbrSleepy.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrHeavyCar
            // 
            this.TbrHeavyCar.Location = new System.Drawing.Point(288, 280);
            this.TbrHeavyCar.Name = "TbrHeavyCar";
            this.TbrHeavyCar.Size = new System.Drawing.Size(104, 45);
            this.TbrHeavyCar.TabIndex = 54;
            this.TbrHeavyCar.Tag = "7";
            this.TbrHeavyCar.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrCar
            // 
            this.TbrCar.Location = new System.Drawing.Point(288, 248);
            this.TbrCar.Name = "TbrCar";
            this.TbrCar.Size = new System.Drawing.Size(104, 45);
            this.TbrCar.TabIndex = 53;
            this.TbrCar.Tag = "6";
            this.TbrCar.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrCultured
            // 
            this.TbrCultured.Location = new System.Drawing.Point(98, 368);
            this.TbrCultured.Name = "TbrCultured";
            this.TbrCultured.Size = new System.Drawing.Size(104, 45);
            this.TbrCultured.TabIndex = 52;
            this.TbrCultured.Tag = "5";
            this.TbrCultured.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrRock
            // 
            this.TbrRock.Location = new System.Drawing.Point(491, 280);
            this.TbrRock.Name = "TbrRock";
            this.TbrRock.Size = new System.Drawing.Size(104, 45);
            this.TbrRock.TabIndex = 59;
            this.TbrRock.Tag = "12";
            this.TbrRock.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrMinimal
            // 
            this.TbrMinimal.Location = new System.Drawing.Point(491, 250);
            this.TbrMinimal.Name = "TbrMinimal";
            this.TbrMinimal.Size = new System.Drawing.Size(104, 45);
            this.TbrMinimal.TabIndex = 58;
            this.TbrMinimal.Tag = "11";
            this.TbrMinimal.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrElectro
            // 
            this.TbrElectro.Location = new System.Drawing.Point(288, 370);
            this.TbrElectro.Name = "TbrElectro";
            this.TbrElectro.Size = new System.Drawing.Size(104, 45);
            this.TbrElectro.TabIndex = 57;
            this.TbrElectro.Tag = "10";
            this.TbrElectro.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrRockWFriends
            // 
            this.TbrRockWFriends.Location = new System.Drawing.Point(288, 337);
            this.TbrRockWFriends.Name = "TbrRockWFriends";
            this.TbrRockWFriends.Size = new System.Drawing.Size(104, 45);
            this.TbrRockWFriends.TabIndex = 56;
            this.TbrRockWFriends.Tag = "9";
            this.TbrRockWFriends.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrFolk
            // 
            this.TbrFolk.Location = new System.Drawing.Point(694, 250);
            this.TbrFolk.Name = "TbrFolk";
            this.TbrFolk.Size = new System.Drawing.Size(104, 45);
            this.TbrFolk.TabIndex = 63;
            this.TbrFolk.Tag = "16";
            this.TbrFolk.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrClassic
            // 
            this.TbrClassic.Location = new System.Drawing.Point(491, 370);
            this.TbrClassic.Name = "TbrClassic";
            this.TbrClassic.Size = new System.Drawing.Size(104, 45);
            this.TbrClassic.TabIndex = 62;
            this.TbrClassic.Tag = "15";
            this.TbrClassic.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrJazz
            // 
            this.TbrJazz.Location = new System.Drawing.Point(491, 340);
            this.TbrJazz.Name = "TbrJazz";
            this.TbrJazz.Size = new System.Drawing.Size(104, 45);
            this.TbrJazz.TabIndex = 61;
            this.TbrJazz.Tag = "14";
            this.TbrJazz.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrPop
            // 
            this.TbrPop.Location = new System.Drawing.Point(491, 310);
            this.TbrPop.Name = "TbrPop";
            this.TbrPop.Size = new System.Drawing.Size(104, 45);
            this.TbrPop.TabIndex = 60;
            this.TbrPop.Tag = "13";
            this.TbrPop.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrNineties
            // 
            this.TbrNineties.Location = new System.Drawing.Point(694, 280);
            this.TbrNineties.Name = "TbrNineties";
            this.TbrNineties.Size = new System.Drawing.Size(104, 45);
            this.TbrNineties.TabIndex = 64;
            this.TbrNineties.Tag = "17";
            this.TbrNineties.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrSpanish
            // 
            this.TbrSpanish.Location = new System.Drawing.Point(694, 370);
            this.TbrSpanish.Name = "TbrSpanish";
            this.TbrSpanish.Size = new System.Drawing.Size(104, 45);
            this.TbrSpanish.TabIndex = 67;
            this.TbrSpanish.Tag = "20";
            this.TbrSpanish.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrInstrumental
            // 
            this.TbrInstrumental.Location = new System.Drawing.Point(694, 340);
            this.TbrInstrumental.Name = "TbrInstrumental";
            this.TbrInstrumental.Size = new System.Drawing.Size(104, 45);
            this.TbrInstrumental.TabIndex = 66;
            this.TbrInstrumental.Tag = "19";
            this.TbrInstrumental.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // TbrFocus
            // 
            this.TbrFocus.Location = new System.Drawing.Point(694, 310);
            this.TbrFocus.Name = "TbrFocus";
            this.TbrFocus.Size = new System.Drawing.Size(104, 45);
            this.TbrFocus.TabIndex = 65;
            this.TbrFocus.Tag = "18";
            this.TbrFocus.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // BtnSkip
            // 
            this.BtnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSkip.Location = new System.Drawing.Point(631, 125);
            this.BtnSkip.Name = "BtnSkip";
            this.BtnSkip.Size = new System.Drawing.Size(49, 32);
            this.BtnSkip.TabIndex = 69;
            this.BtnSkip.Text = "→";
            this.BtnSkip.UseVisualStyleBackColor = true;
            this.BtnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // BtnDoubleJump
            // 
            this.BtnDoubleJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoubleJump.Location = new System.Drawing.Point(542, 125);
            this.BtnDoubleJump.Name = "BtnDoubleJump";
            this.BtnDoubleJump.Size = new System.Drawing.Size(39, 32);
            this.BtnDoubleJump.TabIndex = 70;
            this.BtnDoubleJump.Text = ">>30";
            this.BtnDoubleJump.UseVisualStyleBackColor = true;
            this.BtnDoubleJump.Click += new System.EventHandler(this.BtnDoubleJump_Click);
            // 
            // BtnQuadJump
            // 
            this.BtnQuadJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuadJump.Location = new System.Drawing.Point(586, 125);
            this.BtnQuadJump.Name = "BtnQuadJump";
            this.BtnQuadJump.Size = new System.Drawing.Size(39, 32);
            this.BtnQuadJump.TabIndex = 71;
            this.BtnQuadJump.Text = ">>60";
            this.BtnQuadJump.UseVisualStyleBackColor = true;
            this.BtnQuadJump.Click += new System.EventHandler(this.BtnQuadJump_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPause.Location = new System.Drawing.Point(414, 125);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(35, 32);
            this.BtnPause.TabIndex = 73;
            this.BtnPause.Text = "Ⅱ";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnContinueSession
            // 
            this.BtnContinueSession.BackColor = System.Drawing.Color.Black;
            this.BtnContinueSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinueSession.Location = new System.Drawing.Point(25, 176);
            this.BtnContinueSession.Name = "BtnContinueSession";
            this.BtnContinueSession.Size = new System.Drawing.Size(265, 23);
            this.BtnContinueSession.TabIndex = 74;
            this.BtnContinueSession.UseVisualStyleBackColor = false;
            this.BtnContinueSession.Visible = false;
            this.BtnContinueSession.Click += new System.EventHandler(this.BtnContinueSession_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(694, 434);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 90;
            this.trackBar1.Tag = "28";
            this.trackBar1.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(694, 404);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 89;
            this.trackBar2.Tag = "24";
            this.trackBar2.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(491, 434);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 88;
            this.trackBar3.Tag = "27";
            this.trackBar3.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(491, 404);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 87;
            this.trackBar4.Tag = "23";
            this.trackBar4.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(288, 434);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 45);
            this.trackBar5.TabIndex = 86;
            this.trackBar5.Tag = "26";
            this.trackBar5.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(288, 401);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(104, 45);
            this.trackBar6.TabIndex = 85;
            this.trackBar6.Tag = "22";
            this.trackBar6.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(98, 432);
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(104, 45);
            this.trackBar7.TabIndex = 84;
            this.trackBar7.Tag = "25";
            this.trackBar7.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(98, 404);
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(104, 45);
            this.trackBar8.TabIndex = 83;
            this.trackBar8.Tag = "21";
            this.trackBar8.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(617, 434);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "MasterPiece";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Lime;
            this.label22.Location = new System.Drawing.Point(618, 404);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 81;
            this.label22.Text = "Dance";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Lime;
            this.label23.Location = new System.Drawing.Point(415, 434);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 80;
            this.label23.Text = "Depresive";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Lime;
            this.label24.Location = new System.Drawing.Point(212, 434);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 79;
            this.label24.Text = "Punk";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Lime;
            this.label25.Location = new System.Drawing.Point(22, 404);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 13);
            this.label25.TabIndex = 78;
            this.label25.Text = "HipHop";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Lime;
            this.label26.Location = new System.Drawing.Point(415, 404);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 77;
            this.label26.Text = "Romantic";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Lime;
            this.label27.Location = new System.Drawing.Point(212, 404);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 76;
            this.label27.Text = "Weird";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Lime;
            this.label28.Location = new System.Drawing.Point(22, 434);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 13);
            this.label28.TabIndex = 75;
            this.label28.Text = "Party";
            // 
            // btnCarPlaylist
            // 
            this.btnCarPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPlaylist.Location = new System.Drawing.Point(496, 200);
            this.btnCarPlaylist.Name = "btnCarPlaylist";
            this.btnCarPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnCarPlaylist.TabIndex = 91;
            this.btnCarPlaylist.Text = "Car Playlist";
            this.btnCarPlaylist.UseVisualStyleBackColor = true;
            this.btnCarPlaylist.Click += new System.EventHandler(this.BtnCarPlayList_Click);
            // 
            // btnElitePlayList
            // 
            this.btnElitePlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElitePlayList.Location = new System.Drawing.Point(578, 200);
            this.btnElitePlayList.Name = "btnElitePlayList";
            this.btnElitePlayList.Size = new System.Drawing.Size(75, 23);
            this.btnElitePlayList.TabIndex = 92;
            this.btnElitePlayList.Text = "Elite Playlist";
            this.btnElitePlayList.UseVisualStyleBackColor = true;
            this.btnElitePlayList.Click += new System.EventHandler(this.BtnElitePlayList_Click);
            // 
            // nudRanking
            // 
            this.nudRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nudRanking.Location = new System.Drawing.Point(659, 200);
            this.nudRanking.Name = "nudRanking";
            this.nudRanking.Size = new System.Drawing.Size(54, 20);
            this.nudRanking.TabIndex = 93;
            // 
            // btnRankingPlaylist
            // 
            this.btnRankingPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankingPlaylist.Location = new System.Drawing.Point(719, 200);
            this.btnRankingPlaylist.Name = "btnRankingPlaylist";
            this.btnRankingPlaylist.Size = new System.Drawing.Size(92, 23);
            this.btnRankingPlaylist.TabIndex = 94;
            this.btnRankingPlaylist.Text = "Ranking Playlist";
            this.btnRankingPlaylist.UseVisualStyleBackColor = true;
            this.btnRankingPlaylist.Click += new System.EventHandler(this.BtnRankingPlaylist_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(498, 176);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 13);
            this.label29.TabIndex = 95;
            this.label29.Text = "List Size (MiB)";
            // 
            // txtListSize
            // 
            this.txtListSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtListSize.Location = new System.Drawing.Point(579, 175);
            this.txtListSize.Name = "txtListSize";
            this.txtListSize.Size = new System.Drawing.Size(133, 20);
            this.txtListSize.TabIndex = 96;
            // 
            // BtnClear
            // 
            this.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Location = new System.Drawing.Point(703, 481);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 97;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // cbxDrives
            // 
            this.cbxDrives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbxDrives.FormattingEnabled = true;
            this.cbxDrives.Location = new System.Drawing.Point(375, 191);
            this.cbxDrives.Name = "cbxDrives";
            this.cbxDrives.Size = new System.Drawing.Size(109, 21);
            this.cbxDrives.TabIndex = 98;
            this.cbxDrives.SelectedIndexChanged += new System.EventHandler(this.CbxDrives_SelectedIndexChanged);
            // 
            // lblDestiny
            // 
            this.lblDestiny.AutoSize = true;
            this.lblDestiny.Location = new System.Drawing.Point(372, 175);
            this.lblDestiny.Name = "lblDestiny";
            this.lblDestiny.Size = new System.Drawing.Size(42, 13);
            this.lblDestiny.TabIndex = 99;
            this.lblDestiny.Text = "Destiny";
            // 
            // btnRefreshDrives
            // 
            this.btnRefreshDrives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDrives.Location = new System.Drawing.Point(375, 213);
            this.btnRefreshDrives.Name = "btnRefreshDrives";
            this.btnRefreshDrives.Size = new System.Drawing.Size(109, 23);
            this.btnRefreshDrives.TabIndex = 100;
            this.btnRefreshDrives.Text = "Refresh";
            this.btnRefreshDrives.UseVisualStyleBackColor = true;
            this.btnRefreshDrives.Click += new System.EventHandler(this.BtnRefreshDrives_Click);
            // 
            // btnExportPlaylist
            // 
            this.btnExportPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPlaylist.Location = new System.Drawing.Point(719, 172);
            this.btnExportPlaylist.Name = "btnExportPlaylist";
            this.btnExportPlaylist.Size = new System.Drawing.Size(92, 23);
            this.btnExportPlaylist.TabIndex = 101;
            this.btnExportPlaylist.Text = "&Export Playlist";
            this.btnExportPlaylist.UseVisualStyleBackColor = true;
            this.btnExportPlaylist.Click += new System.EventHandler(this.BtnExportPlaylist_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.BtnClear;
            this.ClientSize = new System.Drawing.Size(823, 529);
            this.Controls.Add(this.btnExportPlaylist);
            this.Controls.Add(this.btnRefreshDrives);
            this.Controls.Add(this.lblDestiny);
            this.Controls.Add(this.cbxDrives);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.txtListSize);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btnRankingPlaylist);
            this.Controls.Add(this.nudRanking);
            this.Controls.Add(this.btnElitePlayList);
            this.Controls.Add(this.btnCarPlaylist);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.BtnContinueSession);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnQuadJump);
            this.Controls.Add(this.BtnDoubleJump);
            this.Controls.Add(this.BtnSkip);
            this.Controls.Add(this.TbrSpanish);
            this.Controls.Add(this.TbrInstrumental);
            this.Controls.Add(this.TbrFocus);
            this.Controls.Add(this.TbrNineties);
            this.Controls.Add(this.TbrFolk);
            this.Controls.Add(this.TbrClassic);
            this.Controls.Add(this.TbrJazz);
            this.Controls.Add(this.TbrPop);
            this.Controls.Add(this.TbrRock);
            this.Controls.Add(this.TbrMinimal);
            this.Controls.Add(this.TbrElectro);
            this.Controls.Add(this.TbrRockWFriends);
            this.Controls.Add(this.TbrSleepy);
            this.Controls.Add(this.TbrHeavyCar);
            this.Controls.Add(this.TbrCar);
            this.Controls.Add(this.TbrCultured);
            this.Controls.Add(this.TbrEnergetic);
            this.Controls.Add(this.TbrAnger);
            this.Controls.Add(this.TbrSadness);
            this.Controls.Add(this.TbrHappiness);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbrRanking);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.lblArtistAlbum);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.SstMain);
            this.Controls.Add(this.btnHop);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.WMPMain);
            this.Controls.Add(this.MnuMain);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MnuMain;
            this.Name = "FrmMain";
            this.Text = "Mp3Ranker";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMain)).EndInit();
            this.SstMain.ResumeLayout(false);
            this.SstMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbrRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrHappiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrSadness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrEnergetic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrAnger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrSleepy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrHeavyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrCultured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrMinimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrElectro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrRockWFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrFolk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrClassic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrJazz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrNineties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrSpanish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrInstrumental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem TsmLibrary;
        private System.Windows.Forms.ToolStripMenuItem TmiNewLibray;
        private System.Windows.Forms.ToolStripMenuItem TmiLoadLibrary;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TmiNewSession;
        private System.Windows.Forms.ToolStripMenuItem TmiLoadSession;
        private System.Windows.Forms.FolderBrowserDialog FbdMain;
        private AxWMPLib.AxWindowsMediaPlayer WMPMain;
        private System.Windows.Forms.Button btnHop;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Timer TmrMain;
        private System.Windows.Forms.StatusStrip SstMain;
        private System.Windows.Forms.ToolStripStatusLabel TssMain;
        private System.Windows.Forms.ToolStripStatusLabel TssCount;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Label lblArtistAlbum;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.SaveFileDialog SfdMain;
        private System.Windows.Forms.OpenFileDialog OfdMain;
        private System.Windows.Forms.TrackBar TbrRanking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TrackBar TbrHappiness;
        private System.Windows.Forms.TrackBar TbrSadness;
        private System.Windows.Forms.TrackBar TbrEnergetic;
        private System.Windows.Forms.TrackBar TbrAnger;
        private System.Windows.Forms.TrackBar TbrSleepy;
        private System.Windows.Forms.TrackBar TbrHeavyCar;
        private System.Windows.Forms.TrackBar TbrCar;
        private System.Windows.Forms.TrackBar TbrCultured;
        private System.Windows.Forms.TrackBar TbrRock;
        private System.Windows.Forms.TrackBar TbrMinimal;
        private System.Windows.Forms.TrackBar TbrElectro;
        private System.Windows.Forms.TrackBar TbrRockWFriends;
        private System.Windows.Forms.TrackBar TbrFolk;
        private System.Windows.Forms.TrackBar TbrClassic;
        private System.Windows.Forms.TrackBar TbrJazz;
        private System.Windows.Forms.TrackBar TbrPop;
        private System.Windows.Forms.TrackBar TbrNineties;
        private System.Windows.Forms.TrackBar TbrSpanish;
        private System.Windows.Forms.TrackBar TbrInstrumental;
        private System.Windows.Forms.TrackBar TbrFocus;        
        private System.Windows.Forms.Button BtnSkip;
        private System.Windows.Forms.Button BtnDoubleJump;
        private System.Windows.Forms.Button BtnQuadJump;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnContinueSession;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnCarPlaylist;
        private System.Windows.Forms.Button btnElitePlayList;
        private System.Windows.Forms.NumericUpDown nudRanking;
        private System.Windows.Forms.Button btnRankingPlaylist;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtListSize;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ToolStripMenuItem TmiRebuildSessio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbxDrives;
        private System.Windows.Forms.Label lblDestiny;
        private System.Windows.Forms.Button btnRefreshDrives;
        private System.Windows.Forms.Button btnExportPlaylist;
    }
}

