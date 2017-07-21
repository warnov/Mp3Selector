namespace Mp3Selector
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmpMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.btnLikeNext = new System.Windows.Forms.Button();
            this.btnDislike = new System.Windows.Forms.Button();
            this.lblDiscarded = new System.Windows.Forms.Label();
            this.btnJump = new System.Windows.Forms.Button();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.sstMain = new System.Windows.Forms.StatusStrip();
            this.tssMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHop = new System.Windows.Forms.Button();
            this.lblArtistAlbum = new System.Windows.Forms.Label();
            this.tssCount = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.wmpMain.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpMain_PlayStateChange);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(33, 94);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(33, 123);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Location = new System.Drawing.Point(261, 205);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(75, 23);
            this.btnLibrary.TabIndex = 3;
            this.btnLibrary.Text = "build library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnBuildLibrary_Click);
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
            this.btnLikeNext.Location = new System.Drawing.Point(33, 176);
            this.btnLikeNext.Name = "btnLikeNext";
            this.btnLikeNext.Size = new System.Drawing.Size(75, 23);
            this.btnLikeNext.TabIndex = 5;
            this.btnLikeNext.Text = "like but next";
            this.btnLikeNext.UseVisualStyleBackColor = true;
            this.btnLikeNext.Click += new System.EventHandler(this.btnLikeNext_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.Location = new System.Drawing.Point(33, 205);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(75, 23);
            this.btnDislike.TabIndex = 6;
            this.btnDislike.Text = "don\'t like";
            this.btnDislike.UseVisualStyleBackColor = true;
            this.btnDislike.Click += new System.EventHandler(this.btnDislike_Click);
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
            this.btnJump.Location = new System.Drawing.Point(261, 94);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(75, 23);
            this.btnJump.TabIndex = 11;
            this.btnJump.Text = "jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // sstMain
            // 
            this.sstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMain,
            this.tssCount});
            this.sstMain.Location = new System.Drawing.Point(0, 261);
            this.sstMain.Name = "sstMain";
            this.sstMain.Size = new System.Drawing.Size(364, 22);
            this.sstMain.TabIndex = 13;
            this.sstMain.Text = "Ready";
            // 
            // tssMain
            // 
            this.tssMain.Name = "tssMain";
            this.tssMain.Size = new System.Drawing.Size(39, 17);
            this.tssMain.Text = "Ready";
            // 
            // btnHop
            // 
            this.btnHop.Location = new System.Drawing.Point(261, 123);
            this.btnHop.Name = "btnHop";
            this.btnHop.Size = new System.Drawing.Size(75, 23);
            this.btnHop.TabIndex = 14;
            this.btnHop.Text = "hop";
            this.btnHop.UseVisualStyleBackColor = true;
            this.btnHop.Click += new System.EventHandler(this.btnHop_Click);
            // 
            // lblArtistAlbum
            // 
            this.lblArtistAlbum.AutoSize = true;
            this.lblArtistAlbum.Location = new System.Drawing.Point(31, 55);
            this.lblArtistAlbum.Name = "lblArtistAlbum";
            this.lblArtistAlbum.Size = new System.Drawing.Size(0, 13);
            this.lblArtistAlbum.TabIndex = 15;
            // 
            // tssCount
            // 
            this.tssCount.Name = "tssCount";
            this.tssCount.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 283);
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
            this.Name = "Form1";
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
        private System.Windows.Forms.Button btnLibrary;
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
    }
}

