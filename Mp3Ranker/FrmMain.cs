using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Mp3Ranker
{
    public partial class FrmMain : Form
    {
        #region Init and Fields
        Library _lib, _session;
        const string _LIB_PATH = @"C:\Users\warnov\OneDrive\WarNovFiles\Art\mp3Ranker.lib.json";
        const string _MEM_PATH = "mp3Ranker.mem.json";
        const string _RANK_PATH = @"c:\tmp\rankMp3";
        const string _EXPORT_PATH= @"c:\tmp\";
        const string _CAR_PATH = @"c:\tmp\carMp3";
        const string _ELITE_PATH = @"c:\tmp\eliteMp3";
        bool _newSong = false;
        bool _auto = false;
        int _index = -1;
        string _oldPath;
        string _sessionPath;
        string _destinyVolume;
        Mp3Info _oldMp3Info;

        public FrmMain()
        {
            InitializeComponent();
            RefreshDrives();
            SetupLibraries();
            Subscribe();
        }

        private void SetupLibraries()
        {
            if (File.Exists(_LIB_PATH))
            {
                _lib = new Library();
                LoadLibrary();
                CheckExistingSession();
            }
            else
            {
                MessageBox.Show("Library not found. You can build or load one from the menu");
            }
        }

        private void CheckExistingSession()
        {
            if (File.Exists(_MEM_PATH))
            {
                _sessionPath = File.ReadAllText(_MEM_PATH);
                if (File.Exists(_sessionPath))
                {
                    BtnContinueSession.Visible = true;
                    BtnContinueSession.Text = $"Continue with {Path.GetFileNameWithoutExtension(_sessionPath)}";
                }
                else
                {
                    if (MessageBox.Show("Do you want to rebuild a session from the current library?", "MP3Ranker", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        RebuildSession();
                    }
                }
            }
        }

        private void LoadLibrary()
        {
            _lib = new Library();
            _lib.Load(_LIB_PATH);
        }

        private string SetSessionName(string fileName)
        {
            var sessionName = Path.GetFileNameWithoutExtension(fileName);
            this.Text = $"MP3Ranker - {sessionName}";
            TssMain.Text = $"{_session.MP3s.Count} songs loaded to classify";
            return sessionName;
        }
        #endregion

        #region Menu Management
        private void TmiNewLibray_Click(object sender, EventArgs e)
        {
            _lib = new Library();
            string musicPath =
                FbdMain.ShowDialog() == DialogResult.OK ?
                FbdMain.SelectedPath : string.Empty;
            if (!string.IsNullOrEmpty(musicPath))
            {
                _lib.Build(musicPath);
                _lib.Save(_LIB_PATH);
                MessageBox.Show("Library Created and Written!");
            }
            else
            {
                MessageBox.Show("No music folder was selected");
            }
        }

        private void TmiNewSession_Click(object sender, EventArgs e)
        {
            if (_lib != null)
            {
                if (SfdMain.ShowDialog() == DialogResult.OK)
                {
                    _session = new Library();
                    _session.Load(_LIB_PATH);
                    _sessionPath = SfdMain.FileName;
                    _session.Save(_sessionPath);
                    var sessionName = SetSessionName(_sessionPath);
                    MessageBox.Show($"Session {sessionName} created and saved");
                    SaveLastSessionUsed();
                }
            }
            else
            {
                MessageBox.Show("Please create a library first");
            }
        }

        private void TmiLoadSession_Click(object sender, EventArgs e)
        {
            OfdMain.Title = "Open Session File";
            if (OfdMain.ShowDialog() == DialogResult.OK)
            {
                _session = new Library();
                _sessionPath = OfdMain.FileName;
                _session.Load(_sessionPath);
                SetSessionName(_sessionPath);
                SaveLastSessionUsed();
            }
        }

        private void BtnContinueSession_Click(object sender, EventArgs e)
        {
            _session = new Library();
            _session.Load(_sessionPath);
            SetSessionName(_sessionPath);
            TmrMain.Enabled = true;
            _newSong = true;
            _auto = true;
            PlayNext();
        }

        private void SaveLastSessionUsed()
        {
            File.WriteAllText(_MEM_PATH, _sessionPath);
        }

        private void TmiRebuildSession_Click(object sender, EventArgs e)
        {
            RebuildSession();
        }

        #endregion

        #region Playing Controls Events
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (WMPMain.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                WMPMain.Ctlcontrols.play();
            }
            else if (_session != null)
            {
                TmrMain.Enabled = true;
                _newSong = true;
                _auto = true;
                PlayNext();
            }
            else
            {
                MessageBox.Show("Please load a session first");
            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void PlayPause()
        {
            if (WMPMain.playState == WMPLib.WMPPlayState.wmppsPlaying)
                WMPMain.Ctlcontrols.pause();
            else if (WMPMain.playState == WMPLib.WMPPlayState.wmppsPaused)
                WMPMain.Ctlcontrols.play();
        }

        private void BtnLikeNext_Click(object sender, EventArgs e)
        {
            LikeNext();
            _newSong = false;
            ManualStop();
        }


        private void BtnSkip_Click(object sender, EventArgs e)
        {
            Skip();
        }

        private void Skip()
        {
            _oldPath = _index >= 0 ? CurrentPath : string.Empty;
            _oldMp3Info = CurrentMp3Info;
            _session.MP3s.RemoveAt(_index);
            _session.Save(_sessionPath);
            PlayNext();
            _newSong = false;
            ManualStop();
        }

        private void BtnHop_Click(object sender, EventArgs e)
        {
            WMPMain.Ctlcontrols.currentPosition += 5;
        }

        private void BtnJump_Click(object sender, EventArgs e)
        {
            WMPMain.Ctlcontrols.currentPosition += 15;
        }

        private void BtnDoubleJump_Click(object sender, EventArgs e)
        {
            WMPMain.Ctlcontrols.currentPosition += 30;
        }

        private void BtnQuadJump_Click(object sender, EventArgs e)
        {
            WMPMain.Ctlcontrols.currentPosition += 60;
        }
        #endregion

        #region Special Events
        private void WMPMain_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (WMPMain.playState == WMPLib.WMPPlayState.wmppsStopped && _newSong && _auto)
            {
                LikeNext();
            }
        }

        private void TmrMain_Tick(object sender, EventArgs e)
        {
            if (WMPMain.playState == WMPLib.WMPPlayState.wmppsReady ||
                WMPMain.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                WMPMain.Ctlcontrols.play();
                _newSong = true;
            }

            else if (WMPMain.playState == WMPLib.WMPPlayState.wmppsPlaying
                || WMPMain.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                var status = WMPMain.playState == WMPLib.WMPPlayState.wmppsPaused ? "PAUSED" : "Playing";
                var timing = $"{WMPMain.Ctlcontrols.currentPositionString} / {WMPMain.currentMedia.durationString}";
                TssMain.Text = $"{status} - {timing}";
            }
            else TssMain.Text = $"Ready";
            var processed = _lib.MP3s.Count - _session.MP3s.Count;
            var total = _lib.MP3s.Count;
            TssCount.Text = $"{processed}/{total} processed.";
        }

       

        private void BtnCarPlayList_Click(object sender, EventArgs e)
        {
            var selectedMp3s =
                 from mp3 in _lib.MP3s
                 where mp3.IsForCar
                 select mp3;

            DeleteSource();
            CopyList(selectedMp3s.ToList(), _destinyVolume);
        }

        private void DeleteSource()
        {
            var di = new DirectoryInfo(_destinyVolume);
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.EnumerateDirectories())
            {
                dir.Delete(true);
            }
        }

        private void BtnElitePlayList_Click(object sender, EventArgs e)
        {
            var selectedMp3s =
                 from mp3 in _lib.MP3s
                 where mp3.IsElite
                 select mp3;

            CopyList(selectedMp3s.ToList(), _ELITE_PATH);
        }

        private void BtnRankingPlaylist_Click(object sender, EventArgs e)
        {
            var selectedMp3s = GetRankedList();
            CopyList(selectedMp3s.ToList(), _RANK_PATH);
        }



        private void BtnExportPlaylist_Click(object sender, EventArgs e)
        {
            var selectedMp3s = GetRankedList();
            ExportList(selectedMp3s.ToList(), _RANK_PATH);
        }


        private void Tbr_Scroll(object sender, EventArgs e)
        {
            var trackBar = (TrackBar)sender;
            var index = Convert.ToInt16(trackBar.Tag);
            AdjustValue(index, (short)trackBar.Value);
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar.ToString().ToLower()[0];
            switch (ch)
            {
                case 'c':
                    AdjustBar(TbrCar, 1);
                    break;
                case 'x':
                    AdjustBar(TbrCar, -1);
                    break;
                case 'r':
                    AdjustBar(TbrRanking, 10, 100);
                    break;
                case 'e':
                    AdjustBar(TbrRanking, -10, 100);
                    break;
                case 'm':
                    AdjustBar(TbrMinimal, 1);
                    break;
                case 'n':
                    AdjustBar(TbrMinimal, -1);
                    break;
            }
        }

        private void AdjustBar(TrackBar tbr, int delta, int size = 10)
        {
            var current = tbr.Value;
            var next = current + delta < 0 ? 0 : current + delta;
            tbr.Value = next > size ? size : next;
            Tbr_Scroll(tbr, null);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ResetTrackBars();
        }

        private void BtnRefreshDrives_Click(object sender, EventArgs e)
        {
            RefreshDrives();
        }

        private void RefreshDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string> removableDriveLetters = new List<string>();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    if (drive.IsReady)
                        removableDriveLetters.Add($"{drive.Name} {drive.VolumeLabel}");
                }
            }
            cbxDrives.DataSource = removableDriveLetters;
        }

        private void CbxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {

            _destinyVolume = cbxDrives.SelectedItem.ToString().Substring(0, 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var current = TbrRanking.Value;
            var delta = e.Delta > 0 ? 10 : -10;
            var next = current + delta < 0 ? 0 : current + delta;
            TbrRanking.Value = next > 100 ? 100 : next;
            Tbr_Scroll(TbrRanking, null);
        }
        #endregion

        #region GlobalKeyHooks
        private IKeyboardMouseEvents m_GlobalHook;
        bool called = false;

        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += GlobalHook_KeyDown;
        }

        private void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.MediaNextTrack)
            {
                Skip();
                called = false;
            }
            else if (e.KeyCode == Keys.MediaPlayPause)
            {
                PlayPause();
                called = false;
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                if(called)
                {
                    TbrRanking.Value = 2;
                    Skip();
                }                
                called = false;
            }
            else if (e.KeyCode == Keys.Subtract && e.Shift && e.Control)
            {
                called = true;
            }
        }
        #endregion
    }
}
