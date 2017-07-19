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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmpMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.btnLoadLibrary = new System.Windows.Forms.Button();
            this.btnDislike = new System.Windows.Forms.Button();
            this.lblDiscarded = new System.Windows.Forms.Label();
            this.btnPlayerStatus = new System.Windows.Forms.Button();
            this.btnPlainPlay = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnJump = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMain)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpMain
            // 
            this.wmpMain.Enabled = true;
            this.wmpMain.Location = new System.Drawing.Point(197, 218);
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
            this.btnPlay.Location = new System.Drawing.Point(33, 61);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(160, 61);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Location = new System.Drawing.Point(160, 189);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(75, 23);
            this.btnLibrary.TabIndex = 3;
            this.btnLibrary.Text = "build library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(30, 129);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(35, 13);
            this.lblTrack.TabIndex = 4;
            this.lblTrack.Text = "label1";
            // 
            // btnLoadLibrary
            // 
            this.btnLoadLibrary.Location = new System.Drawing.Point(33, 189);
            this.btnLoadLibrary.Name = "btnLoadLibrary";
            this.btnLoadLibrary.Size = new System.Drawing.Size(75, 23);
            this.btnLoadLibrary.TabIndex = 5;
            this.btnLoadLibrary.Text = "load library";
            this.btnLoadLibrary.UseVisualStyleBackColor = true;
            this.btnLoadLibrary.Click += new System.EventHandler(this.btnLoadLibrary_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.Location = new System.Drawing.Point(33, 226);
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
            // btnPlayerStatus
            // 
            this.btnPlayerStatus.Location = new System.Drawing.Point(287, 61);
            this.btnPlayerStatus.Name = "btnPlayerStatus";
            this.btnPlayerStatus.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerStatus.TabIndex = 8;
            this.btnPlayerStatus.Text = "status";
            this.btnPlayerStatus.UseVisualStyleBackColor = true;
            this.btnPlayerStatus.Click += new System.EventHandler(this.btnPlayerStatus_Click);
            // 
            // btnPlainPlay
            // 
            this.btnPlainPlay.Location = new System.Drawing.Point(33, 90);
            this.btnPlainPlay.Name = "btnPlainPlay";
            this.btnPlainPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlainPlay.TabIndex = 9;
            this.btnPlainPlay.Text = "plainPlay";
            this.btnPlainPlay.UseVisualStyleBackColor = true;
            this.btnPlainPlay.Click += new System.EventHandler(this.btnPlainPlay_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(287, 90);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(75, 23);
            this.btnPosition.TabIndex = 10;
            this.btnPosition.Text = "position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(160, 90);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(75, 23);
            this.btnJump.TabIndex = 11;
            this.btnJump.Text = "jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 288);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnPlainPlay);
            this.Controls.Add(this.btnPlayerStatus);
            this.Controls.Add(this.lblDiscarded);
            this.Controls.Add(this.btnDislike);
            this.Controls.Add(this.btnLoadLibrary);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.wmpMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wmpMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpMain;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Button btnLoadLibrary;
        private System.Windows.Forms.Button btnDislike;
        private System.Windows.Forms.Label lblDiscarded;
        private System.Windows.Forms.Button btnPlayerStatus;
        private System.Windows.Forms.Button btnPlainPlay;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnJump;
    }
}

