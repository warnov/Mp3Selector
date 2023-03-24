using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
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
                short tag = short.Parse(trackBar.Tag.ToString());
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

        #region List Management
        /// <summary>
        /// Selects a set of MP3s that have at least the ranking specified in the Numeric updown control of the form. Remember that the ranking is the index 0 in Values.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Mp3Info> GetRankedList()
        {
            var rank = nudRanking.Value;
            var selectedMp3s =
                 from mp3 in _lib.MP3s
                 where mp3.MinimumRanked(rank)
                 select mp3;
            return selectedMp3s;
        }

        /// <summary>
        /// Physycally makes a copy of all the mp3s specified in the selectedMp3s list, to the given path. This is usefuyl for example to physically take a set of songs to the car or an usb.
        /// </summary>
        /// <param name="selectedMp3s"></param>
        /// <param name="destinationPath"></param>
        private void CopyList(List<Mp3Info> selectedMp3s, string destinationPath)
        {
            var currentListSize = 0L;
            long maxListSize = long.TryParse(txtListSize.Text, out maxListSize) ? maxListSize *= 1024 * 1024 : long.MaxValue;

            MessageBox.Show($"{selectedMp3s.Count()} files to choose from!");
            var idxs = new List<int>();
            for (int i = 0; i < selectedMp3s.Count(); i++)
            {
                idxs.Add(i);
            }

            var rnd = new Random();
            var effectiveSongs = 0;
            while (currentListSize <= maxListSize && effectiveSongs <= selectedMp3s.Count())
            {
                var pointer = rnd.Next(0, idxs.Count());
                var idx = ++idxs[pointer];
                idxs.RemoveAt(pointer);
                Mp3Info mp3 = selectedMp3s[pointer];
                using (TagLib.File MP3 = TagLib.File.Create(mp3.Path))
                {
                    var tag = MP3.GetTag(TagLib.TagTypes.Id3v2);

                    var title = tag.Title != null ? tag.Title.Replace(":", "").
                        Replace("?", string.Empty).
                        Replace("*", string.Empty).
                        Replace("\"", string.Empty).
                        Replace("/", string.Empty).
                        Replace("\\", string.Empty) : Path.GetFileName(mp3.Path);

                    var album = tag.Artists.Length > 0 ? $" - {tag.Artists[0]}" : string.Empty;
                    var newPath = $@"{destinationPath}\{++effectiveSongs} - {title}{album}.mp3";
                    var fi = new FileInfo(mp3.Path);

                    currentListSize += fi.Length;
                    File.Copy(mp3.Path, newPath, true);
                }
            }
            MessageBox.Show($"{effectiveSongs} songs copied totalizing {currentListSize / 1024 / 1024} MiB");
        }

        /// <summary>
        /// Creates a playlist text file to be imported in other music services such as spotify or youtube music,
        /// using the set of songs specified in selectedMp3s. It has the format: Title - Artist
        /// </summary>
        /// <param name="selectedMp3s"></param>
        /// <param name="destinationPath"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ExportList(List<Mp3Info> selectedMp3s, string destinationPath)
        {
            MessageBox.Show($"{selectedMp3s.Count()} files for your playlist!");
            var sb = new StringBuilder();
            for (int i = 0; i < selectedMp3s.Count(); i++)
            {
                Mp3Info mp3 = selectedMp3s[i];
                using (TagLib.File MP3 = TagLib.File.Create(mp3.Path))
                {
                    var tag = MP3.GetTag(TagLib.TagTypes.Id3v2);

                    var title = tag.Title != null ? tag.Title.Replace(":", "").
                        Replace("?", string.Empty).
                        Replace("*", string.Empty).
                        Replace("\"", string.Empty).
                        Replace("/", string.Empty).
                        Replace("\\", string.Empty) : Path.GetFileName(mp3.Path);

                    var artist = tag.Artists.Length > 0 ? tag.Artists[0].ToString() : string.Empty;
                    sb.AppendLine($"{title} - {artist}");
                }
            }
            File.WriteAllText($"{destinationPath}Mp3Ranker-Playlist.txt", sb.ToString());
            //Open the file with the default program
            Process.Start($"{destinationPath}Mp3Ranker-Playlist.txt");

            MessageBox.Show($"Your list is ready!");
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
