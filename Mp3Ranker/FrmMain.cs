using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Ranker
{
    public partial class FrmMain : Form
    {
        #region Init and Fields
        Library _lib, _session;
        const string _LIB_PATH = "mp3Ranker.lib.json";
        const string _MEM_PATH = "mp3Ranker.mem.json";
        bool _newSong = false;
        bool _auto = false;
        int _index = -1;
        string _oldPath;
        string _sessionPath;
        Mp3Info _oldMp3Info;

        public FrmMain()
        {
            InitializeComponent();
            SetupLibraries();
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
                BtnContinueSession.Visible = true;
                BtnContinueSession.Text = $"Continue with {Path.GetFileNameWithoutExtension(_sessionPath)}";
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

        #region Spetial Events
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

        private void button1_Click(object sender, EventArgs e)
        {
            var carMp3s =
                 from mp3 in _lib.MP3s
                 where mp3.IsForCar
                 select mp3;
            MessageBox.Show($"{carMp3s.Count()} files to be copied!");
            var idxs = new List<int>();
            for (int i = 0; i < carMp3s.Count(); i++)
            {
                idxs.Add(i);
            }

            var rnd = new Random();
            foreach(var mp3 in carMp3s)
            {
                var pointer = rnd.Next(0, idxs.Count());
                var idx = ++idxs[pointer];
                idxs.RemoveAt(pointer);
                using (TagLib.File MP3 = TagLib.File.Create(mp3.Path))
                {
                    var tag = MP3.GetTag(TagLib.TagTypes.Id3v2);
                    var title = tag.Title != null ? tag.Title.Replace(":", "").Replace("?", "").Replace("*", "") : Path.GetFileName(mp3.Path);
                    var album = tag.Artists.Length > 0 ? $" - {tag.Artists[0]}" : string.Empty;
                    var newPath = $@"c:\tmp\carMp3\{idx} - {title}{album}.mp3";

                    File.Copy(mp3.Path, newPath);                   
                }
            }
            MessageBox.Show("Files copied!!");
        }

        private void btnElitePlayList_Click(object sender, EventArgs e)
        {
            var carMp3s =
                 from mp3 in _lib.MP3s
                 where mp3.IsElite
                 select mp3;
            MessageBox.Show($"{carMp3s.Count()} files to be copied!");
            var idxs = new List<int>();
            for (int i = 0; i < carMp3s.Count(); i++)
            {
                idxs.Add(i);
            }

            var rnd = new Random();
            foreach (var mp3 in carMp3s)
            {
                var pointer = rnd.Next(0, idxs.Count());
                var idx = ++idxs[pointer];
                idxs.RemoveAt(pointer);
                using (TagLib.File MP3 = TagLib.File.Create(mp3.Path))
                {
                    var tag = MP3.GetTag(TagLib.TagTypes.Id3v2);
                    var title = tag.Title != null ? tag.Title.Replace(":", "").Replace("?", "").Replace("*", "") : Path.GetFileName(mp3.Path);
                    var album = tag.Artists.Length > 0 ? $" - {tag.Artists[0]}" : string.Empty;
                    var newPath = $@"c:\tmp\eliteMp3\{idx} - {title}{album}.mp3";

                    File.Copy(mp3.Path, newPath);
                }
            }
            MessageBox.Show("Files copied!!");
        }

        private void Tbr_Scroll(object sender, EventArgs e)
        {
            var trackBar = (TrackBar)sender;
            var index = Convert.ToInt16(trackBar.Tag);
            AdjustValue(index, (short)trackBar.Value);
        }
        #endregion
    }
}
