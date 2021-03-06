﻿using System;
using System.Linq;
using System.Windows.Forms;
using TagLib.Id3v2;

namespace Mp3Ranker
{
    public partial class FrmMain
    {
        #region Properties

        public string CurrentPath
        {
            get
            {
                return _session.MP3s[_index].Path;
            }
        }

        public Mp3Info CurrentMp3Info
        {
            get
            {
                return _session.MP3s[_index];
            }
        }

        #endregion

        #region Playing Logic
        private void LikeNext()
        {
            _newSong = false;
            _oldPath = _index >= 0 ? CurrentPath : string.Empty;
            _oldMp3Info = CurrentMp3Info;
            if (TbrRanking.Value != 0) _session.MP3s.RemoveAt(_index);
            _session.Save(_sessionPath);
            PlayNext();
        }

        private void PlayNext()
        {
            var length = _session.MP3s.Count;
            var rnd = new Random();
            _index = rnd.Next(length);
            WMPMain.URL = CurrentPath;
            SaveRanking();
            DisplayMP3Info();
        }

        private void ManualStop()
        {
            WMPMain.Ctlcontrols.stop();
            _newSong = false;
        }

        private void DisplayMP3Info()
        {
            try
            {
                if (CurrentMp3Info.Values == null)
                    CurrentMp3Info.Values = new short[Mp3Info.ATT_NUMBER];
                var MP3 = TagLib.File.Create(CurrentPath);
                var tag = MP3.GetTag(TagLib.TagTypes.Id3v2);
                var tagAdv = (TagLib.Id3v2.Tag)tag;
                var UTIF = UserTextInformationFrame.Get(tagAdv, "MP3Ranker", true);
                if (UTIF.Text.Length > 0)
                {
                    var rankingInfo = UTIF.Text[0];
                    CurrentMp3Info.SetAttributes(rankingInfo);
                    SetTrackBarValues();
                }
                else
                {
                    ResetTrackBars();
                }
                lblTrack.Text = tag.Title;
                lblArtistAlbum.Text = $"{tag.Artists[0]} ({tag.Album})";
                txtBoxPath.Text = CurrentPath;
                MP3.Dispose();
            }
            catch
            {
                lblTrack.Text = "!";
                lblArtistAlbum.Text = CurrentPath;
            }
        } 
        #endregion

        #region TrackBar Actions
        private void SetTrackBarValues()
        {
            for (short i = 0; i < CurrentMp3Info.Values.Length; i++)
            {
                SetTrackBarValues(i, CurrentMp3Info.Values[i]);
            }
        }

        private void SetTrackBarValues(short index, short value)
        {
            foreach (var control in Controls.OfType<TrackBar>())
            {
                var trackBar = (TrackBar)control;
                short tag = (short)trackBar.Tag;
                if (tag == index)
                {
                    trackBar.Value = value;
                    break;
                }
            }
        }

        private void ResetTrackBars()
        {
            foreach (var control in Controls.OfType<TrackBar>())
            {
                var trackBar = (TrackBar)control;
                trackBar.Value = 0;
            }
        }
        #endregion

        #region Ranking Management
        private void AdjustValue(short index, short value)
        {
            if (_session != null)
            {
                CurrentMp3Info.Values[index] = value;
            }
            else
            {
                MessageBox.Show("No session chosen");
                ResetTrackBars();
            }
        }

        private void SaveRanking()
        {
            if (!string.IsNullOrEmpty(_oldPath))
            {
                var MP3 = TagLib.File.Create(_oldPath);
                var tag = (TagLib.Id3v2.Tag)MP3.GetTag(TagLib.TagTypes.Id3v2);
                var UTIF = UserTextInformationFrame.Get(tag, "MP3Ranker", true);
                UTIF.Text = new string[] { _oldMp3Info.AttributesLine };
                MP3.Save();
                MP3.Dispose();

                //Now writing the main library
                var libraryMp3 = _lib.FindByPath(_oldPath);
                libraryMp3.CopyAttributes(_oldMp3Info);
                _lib.Save(_LIB_PATH);
            }
        }
        #endregion

        #region Session Management
        private void RebuildSession()
        {
            if (_lib != null)
            {
                if (SfdMain.ShowDialog() == DialogResult.OK)
                {
                    _session = new Library();
                    foreach(var mp3 in _lib.MP3s)
                    {
                        if (!mp3.IsRanked) _session.MP3s.Add(mp3);
                    }

                    //not load all; just create a new one without rankings _session.Load(_LIB_PATH);
                    _sessionPath = SfdMain.FileName;
                    _session.Save(_sessionPath);
                    var sessionName = SetSessionName(_sessionPath);
                    MessageBox.Show($"Session {sessionName} rebuilt and saved");
                    SaveLastSessionUsed();
                }
            }
            else
            {
                MessageBox.Show("Please create a library first");
            }
        }
        #endregion
    }
}
