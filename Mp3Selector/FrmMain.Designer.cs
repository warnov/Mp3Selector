namespace Mp3Selector
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
            this.wmpMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.btnLikeNext = new System.Windows.Forms.Button();
            this.btnDislike = new System.Windows.Forms.Button();
            this.lblDiscarded = new System.Windows.Forms.Label();
            this.btnJump = new System.Windows.Forms.Button();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.sstMain = new System.Windows.Forms.StatusStrip();
            this.tssMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHop = new System.Windows.Forms.Button();
            this.lblArtistAlbum = new System.Windows.Forms.Label();
            this.lblStarts = new System.Windows.Forms.Label();
            this.Btn1Star = new System.Windows.Forms.Button();
            this.Btn2Stars = new System.Windows.Forms.Button();
            this.Btn3Stars = new System.Windows.Forms.Button();
            this.Btn4Stars = new System.Windows.Forms.Button();
            this.Btn5Stars = new System.Windows.Forms.Button();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.BtnShowPropertiers = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnTestStars = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMain)).BeginInit();
            this.sstMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmpMain
            // 
            this.wmpMain.Enabled = true;
            this.wmpMain.Location = new System.Drawing.Point(555, 240);
            this.wmpMain.Name = "wmpMain";
            this.wmpMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMain.OcxState")));
            this.wmpMain.Size = new System.Drawing.Size(75, 23);
            this.wmpMain.TabIndex = 0;
            this.wmpMain.UseWaitCursor = true;
            this.wmpMain.Visible = false;
            this.wmpMain.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WmpMain_PlayStateChange);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(33, 116);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(33, 145);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrack.Location = new System.Drawing.Point(30, 19);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(0, 24);
            this.lblTrack.TabIndex = 4;
            // 
            // btnLikeNext
            // 
            this.btnLikeNext.Location = new System.Drawing.Point(33, 198);
            this.btnLikeNext.Name = "btnLikeNext";
            this.btnLikeNext.Size = new System.Drawing.Size(75, 23);
            this.btnLikeNext.TabIndex = 5;
            this.btnLikeNext.Text = "like but next";
            this.btnLikeNext.UseVisualStyleBackColor = true;
            this.btnLikeNext.Click += new System.EventHandler(this.BtnLikeNext_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.Location = new System.Drawing.Point(33, 227);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(75, 23);
            this.btnDislike.TabIndex = 6;
            this.btnDislike.Text = "don\'t like";
            this.btnDislike.UseVisualStyleBackColor = true;
            this.btnDislike.Click += new System.EventHandler(this.BtnDislike_Click);
            // 
            // lblDiscarded
            // 
            this.lblDiscarded.AutoSize = true;
            this.lblDiscarded.Location = new System.Drawing.Point(30, 266);
            this.lblDiscarded.Name = "lblDiscarded";
            this.lblDiscarded.Size = new System.Drawing.Size(0, 13);
            this.lblDiscarded.TabIndex = 7;
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(300, 116);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(75, 23);
            this.btnJump.TabIndex = 11;
            this.btnJump.Text = "jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.BtnJump_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.TmrMain_Tick);
            // 
            // sstMain
            // 
            this.sstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMain,
            this.tssCount});
            this.sstMain.Location = new System.Drawing.Point(0, 261);
            this.sstMain.Name = "sstMain";
            this.sstMain.Size = new System.Drawing.Size(402, 22);
            this.sstMain.TabIndex = 13;
            this.sstMain.Text = "Ready";
            // 
            // tssMain
            // 
            this.tssMain.Name = "tssMain";
            this.tssMain.Size = new System.Drawing.Size(39, 17);
            this.tssMain.Text = "Ready";
            // 
            // tssCount
            // 
            this.tssCount.Name = "tssCount";
            this.tssCount.Size = new System.Drawing.Size(0, 17);
            // 
            // btnHop
            // 
            this.btnHop.Location = new System.Drawing.Point(300, 147);
            this.btnHop.Name = "btnHop";
            this.btnHop.Size = new System.Drawing.Size(75, 23);
            this.btnHop.TabIndex = 14;
            this.btnHop.Text = "hop";
            this.btnHop.UseVisualStyleBackColor = true;
            this.btnHop.Click += new System.EventHandler(this.BtnHop_Click);
            // 
            // lblArtistAlbum
            // 
            this.lblArtistAlbum.AutoSize = true;
            this.lblArtistAlbum.Location = new System.Drawing.Point(31, 55);
            this.lblArtistAlbum.Name = "lblArtistAlbum";
            this.lblArtistAlbum.Size = new System.Drawing.Size(0, 13);
            this.lblArtistAlbum.TabIndex = 15;
            // 
            // lblStarts
            // 
            this.lblStarts.AutoSize = true;
            this.lblStarts.Location = new System.Drawing.Point(187, 116);
            this.lblStarts.Name = "lblStarts";
            this.lblStarts.Size = new System.Drawing.Size(29, 13);
            this.lblStarts.TabIndex = 17;
            this.lblStarts.Text = "stars";
            // 
            // Btn1Star
            // 
            this.Btn1Star.Location = new System.Drawing.Point(114, 145);
            this.Btn1Star.Name = "Btn1Star";
            this.Btn1Star.Size = new System.Drawing.Size(30, 23);
            this.Btn1Star.TabIndex = 18;
            this.Btn1Star.Text = "1";
            this.Btn1Star.UseVisualStyleBackColor = true;
            this.Btn1Star.Click += new System.EventHandler(this.Btn1Star_Click);
            // 
            // Btn2Stars
            // 
            this.Btn2Stars.Location = new System.Drawing.Point(150, 145);
            this.Btn2Stars.Name = "Btn2Stars";
            this.Btn2Stars.Size = new System.Drawing.Size(30, 23);
            this.Btn2Stars.TabIndex = 19;
            this.Btn2Stars.Text = "2";
            this.Btn2Stars.UseVisualStyleBackColor = true;
            this.Btn2Stars.Click += new System.EventHandler(this.Btn2Stars_Click);
            // 
            // Btn3Stars
            // 
            this.Btn3Stars.Location = new System.Drawing.Point(186, 145);
            this.Btn3Stars.Name = "Btn3Stars";
            this.Btn3Stars.Size = new System.Drawing.Size(30, 23);
            this.Btn3Stars.TabIndex = 20;
            this.Btn3Stars.Text = "3";
            this.Btn3Stars.UseVisualStyleBackColor = true;
            this.Btn3Stars.Click += new System.EventHandler(this.Btn3Stars_Click);
            // 
            // Btn4Stars
            // 
            this.Btn4Stars.Location = new System.Drawing.Point(222, 145);
            this.Btn4Stars.Name = "Btn4Stars";
            this.Btn4Stars.Size = new System.Drawing.Size(30, 23);
            this.Btn4Stars.TabIndex = 21;
            this.Btn4Stars.Text = "4";
            this.Btn4Stars.UseVisualStyleBackColor = true;
            this.Btn4Stars.Click += new System.EventHandler(this.Btn4Stars_Click);
            // 
            // Btn5Stars
            // 
            this.Btn5Stars.Location = new System.Drawing.Point(258, 145);
            this.Btn5Stars.Name = "Btn5Stars";
            this.Btn5Stars.Size = new System.Drawing.Size(30, 23);
            this.Btn5Stars.TabIndex = 22;
            this.Btn5Stars.Text = "5";
            this.Btn5Stars.UseVisualStyleBackColor = true;
            this.Btn5Stars.Click += new System.EventHandler(this.Btn5Stars_Click);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPath.Location = new System.Drawing.Point(32, 87);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(342, 17);
            this.txtBoxPath.TabIndex = 23;
            // 
            // BtnShowPropertiers
            // 
            this.BtnShowPropertiers.Location = new System.Drawing.Point(57, 169);
            this.BtnShowPropertiers.Name = "BtnShowPropertiers";
            this.BtnShowPropertiers.Size = new System.Drawing.Size(51, 23);
            this.BtnShowPropertiers.TabIndex = 24;
            this.BtnShowPropertiers.Text = "props";
            this.BtnShowPropertiers.UseVisualStyleBackColor = true;
            this.BtnShowPropertiers.Click += new System.EventHandler(this.BtnShowPropertiers_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(123, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(164, 66);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // BtnTestStars
            // 
            this.BtnTestStars.Location = new System.Drawing.Point(300, 176);
            this.BtnTestStars.Name = "BtnTestStars";
            this.BtnTestStars.Size = new System.Drawing.Size(51, 23);
            this.BtnTestStars.TabIndex = 26;
            this.BtnTestStars.Text = "props";
            this.BtnTestStars.UseVisualStyleBackColor = true;
            this.BtnTestStars.Click += new System.EventHandler(this.BtnTestStars_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Location = new System.Drawing.Point(300, 227);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(75, 23);
            this.btnLibrary.TabIndex = 3;
            this.btnLibrary.Text = "build library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.BtnBuildLibrary_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 283);
            this.Controls.Add(this.BtnTestStars);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnShowPropertiers);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.Btn5Stars);
            this.Controls.Add(this.Btn4Stars);
            this.Controls.Add(this.Btn3Stars);
            this.Controls.Add(this.Btn2Stars);
            this.Controls.Add(this.Btn1Star);
            this.Controls.Add(this.lblStarts);
            this.Controls.Add(this.lblArtistAlbum);
            this.Controls.Add(this.btnHop);
            this.Controls.Add(this.sstMain);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.lblDiscarded);
            this.Controls.Add(this.btnDislike);
            this.Controls.Add(this.btnLikeNext);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.wmpMain);
            this.Name = "FrmMain";
            this.Text = "Mp3Ranker";
            ((System.ComponentModel.ISupportInitialize)(this.wmpMain)).EndInit();
            this.sstMain.ResumeLayout(false);
            this.sstMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpMain;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Button btnLikeNext;
        private System.Windows.Forms.Button btnDislike;
        private System.Windows.Forms.Label lblDiscarded;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.StatusStrip sstMain;
        private System.Windows.Forms.ToolStripStatusLabel tssMain;
        private System.Windows.Forms.Button btnHop;
        private System.Windows.Forms.Label lblArtistAlbum;
        private System.Windows.Forms.ToolStripStatusLabel tssCount;
        private System.Windows.Forms.Label lblStarts;
        private System.Windows.Forms.Button Btn1Star;
        private System.Windows.Forms.Button Btn2Stars;
        private System.Windows.Forms.Button Btn3Stars;
        private System.Windows.Forms.Button Btn4Stars;
        private System.Windows.Forms.Button Btn5Stars;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button BtnShowPropertiers;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnTestStars;
        private System.Windows.Forms.Button btnLibrary;
    }
}

