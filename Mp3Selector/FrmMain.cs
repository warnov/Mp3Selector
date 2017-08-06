using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using TagLib.Id3v2;

namespace Mp3Selector
{
    public partial class FrmMain : Form
    {

        #region Class Definition
        List<string> currentLibrary;
        List<string> discardedLibrary;
        List<string> selectedLibrary;
        const string LIBPATH = @"d:\music\";
        const string CURLIB = "currentLibrary.txt";
        const string SELLIB = "selectedLibrary.txt";
        const string DISLIB = "discardedLibrary.txt";
        bool newSong = false;
        bool auto = false;
        int index = -1;
        int stars = 0;
        string oldPath;



        public FrmMain()
        {
            InitializeComponent();
            LoadLibraries();
        }
        #endregion


        #region Events

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            tmrMain.Enabled = true;
            newSong = true;
            auto = true;
            PlayNext();

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            auto = false;
            ManualStop();
            tmrMain.Enabled = false;
            tssMain.Text = "Ready";
        }

        private void BtnBuildLibrary_Click(object sender, EventArgs e)
        {
            currentLibrary = new List<string>();
            selectedLibrary = new List<string>();
            discardedLibrary = new List<string>();
            BuildLibrary(LIBPATH, currentLibrary);
            WriteLibraries();
            MessageBox.Show("Library Created and Written!");
        }

        private void BtnLikeNext_Click(object sender, EventArgs e)
        {
            LikeNext();
            newSong = false;
            ManualStop();
        }

        private void BtnDislike_Click(object sender, EventArgs e)
        {
            discardedLibrary.Add(CurrentPath);
            currentLibrary.RemoveAt(index);
            PlayNext();
            newSong = false;
            ManualStop();
            WriteLibraries();
        }

        private void BtnPlainPlay_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.play();
            newSong = true;
            auto = true;
        }

        private void BtnJump_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.currentPosition += 60;
        }

        private void BtnHop_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.currentPosition += 30;
        }

        private void WmpMain_PlayStateChange(object sender,
            AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (wmpMain.playState == WMPLib.WMPPlayState.wmppsStopped && newSong && auto)
            {
                LikeNext();
            }
        }

        private void TmrMain_Tick(object sender, EventArgs e)
        {
            if (wmpMain.playState == WMPLib.WMPPlayState.wmppsReady ||
                wmpMain.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                wmpMain.Ctlcontrols.play();
                newSong = true;
            }

            else if (wmpMain.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                var timing = $"{wmpMain.Ctlcontrols.currentPositionString} / {wmpMain.currentMedia.durationString}";
                tssMain.Text = $"Playing - {timing}";
            }
            else tssMain.Text = $"Ready";
            var processed = selectedLibrary.Count + discardedLibrary.Count;
            var total = processed + currentLibrary.Count;
            tssCount.Text = $"{ processed}/{total} processed.";
        }

        #region SetStars
        private void Btn1Star_Click(object sender, EventArgs e)
        {
            stars = 1;
            lblStarts.Text = stars.ToString();
        }

        private void Btn2Stars_Click(object sender, EventArgs e)
        {
            stars = 2;
            lblStarts.Text = stars.ToString();
        }

        private void Btn3Stars_Click(object sender, EventArgs e)
        {
            stars = 3;
            lblStarts.Text = stars.ToString();
        }

        private void Btn4Stars_Click(object sender, EventArgs e)
        {
            stars = 4;
            lblStarts.Text = stars.ToString();
        }

        private void Btn5Stars_Click(object sender, EventArgs e)
        {
            stars = 5;
            lblStarts.Text = stars.ToString();
        }
        #endregion


        #endregion


        #region Methods


        private void PlayNext()
        {
            var length = currentLibrary.Count;            
            var rnd = new Random();
            index = rnd.Next(length);
            wmpMain.URL = CurrentPath;
            if (!string.IsNullOrEmpty(oldPath)) SetStars(oldPath);
            AssembleTitle();
        }

        private void LikeNext()
        {
            newSong = false;
            oldPath = index >= 0 ? CurrentPath : string.Empty;
            selectedLibrary.Add(CurrentPath);
            currentLibrary.RemoveAt(index);
            WriteLibraries();
            PlayNext();
        }

        private void ManualStop()
        {
            wmpMain.Ctlcontrols.stop();
            newSong = false;
        }

        private void WriteLibraries()
        {
            var sLibrary = JsonConvert.SerializeObject(currentLibrary);
            File.WriteAllText($"{LIBPATH}{CURLIB}", sLibrary);

            sLibrary = JsonConvert.SerializeObject(selectedLibrary);
            File.WriteAllText($"{LIBPATH}{SELLIB}", sLibrary);

            sLibrary = JsonConvert.SerializeObject(discardedLibrary);
            File.WriteAllText($"{LIBPATH}{DISLIB}", sLibrary);
        }

        void BuildLibrary(string directory, List<string> library)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(directory))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        if (f.ToLower().Contains("mp3"))
                        {
                            library.Add(f);
                        }
                    }
                    BuildLibrary(d, library);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

        }

        private void LoadLibraries()
        {
            var fileName = $"{LIBPATH}{CURLIB}";
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                currentLibrary = JsonConvert.DeserializeObject<List<string>>(json);
                tssMain.Text = $"{currentLibrary.Count} songs loaded to classify";

                json = File.ReadAllText($"{LIBPATH}{SELLIB}");
                selectedLibrary = JsonConvert.DeserializeObject<List<string>>(json);

                json = File.ReadAllText($"{LIBPATH}{DISLIB}");
                discardedLibrary = JsonConvert.DeserializeObject<List<string>>(json);
            }
            else MessageBox.Show("You must build a library first");
        }

        private string CurrentPath
        {
            get
            {
                return currentLibrary[index];
            }
        }

        private void AssembleTitle()
        {
            try
            {
                var MP3 = TagLib.File.Create(CurrentPath);
                var tag = MP3.GetTag(TagLib.TagTypes.Id3v2);
                lblTrack.Text = tag.Title;
                lblArtistAlbum.Text = $"{tag.Artists[0]} ({tag.Album})";
                lblStarts.Text = Stars;
                MP3.Dispose();
            }
            catch
            {
                lblTrack.Text = "!";
                lblArtistAlbum.Text = CurrentPath;
            }
        }

        private string Stars
        {
            //unrated=0, 1=1-63, 2=64-127, 3=128-191, 4=192-254, 5=255           
            get
            {
                var MP3 = TagLib.File.Create(CurrentPath);
                var tag = (TagLib.Id3v2.Tag)MP3.GetTag(TagLib.TagTypes.Id3v2);
                var POPM = PopularimeterFrame.Get(tag, "no@email", true);
                var byteValue = POPM.Rating;
                if (byteValue != 0)
                {
                    var log2 = (int)Math.Log(byteValue, 2);
                    var stars = log2 - 3;
                    return stars < 0 ? "0" : stars.ToString();
                }
                return "0";
            }
        }

        private void SetStars(string oldPath)
        {
            var MP3 = TagLib.File.Create(oldPath);
            var tag = (TagLib.Id3v2.Tag)MP3.GetTag(TagLib.TagTypes.Id3v2);
            var POPM = PopularimeterFrame.Get(tag, "no@email", true);

            var intValue = (int)Math.Pow(2, 3 + stars);
            byte byteValue = intValue > 255 ? (byte)255 : (byte)intValue;
            POPM.Rating = byteValue;
            MP3.Save();
            MP3.Dispose();


        }
        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {

            // var mp3 = TagLib.File.Create(@"D:\music\Limp Bizkit\2011 - Gold Cobra\01 - Introbra.mp3");
            var mp3 = TagLib.File.Create(@"D:\music\Limp Bizkit\2011 - Gold Cobra\03 - Gold Cobra.mp3");

            // var mp3 = TagLib.File.Create(@"D:\music\2 Pac\1996 - Don Killuminati the 7 Day Theory\1 - Intro-Bomb First (My Second Reply).mp3");
            var tag = (TagLib.Id3v2.Tag)mp3.GetTag(TagLib.TagTypes.Id3v2);

            var PopM = PopularimeterFrame.Get(tag, "no@email", true);

            var popf1 = new PopularimeterFrame("no@email")
            {
                Rating = 50
            };
            var popf2 = new PopularimeterFrame("Windows Media Player 9 Series")
            {
                Rating = 50
            };
            tag.AddFrame(popf1);
            PopM.Rating = 100;

            mp3.Save();
            mp3.Dispose();

        }

        private void BtnShowPropertiers_Click(object sender, EventArgs e)
        {
            var MP3 = TagLib.File.Create(txtBoxPath.Text);
            var tag = (TagLib.Id3v2.Tag)MP3.GetTag(TagLib.TagTypes.Id3v2);
            var POPM = PopularimeterFrame.Get(tag, "no@email", true);
            var POPM1 = PopularimeterFrame.Get(tag, "warnov@gmail.com", true);
            richTextBox1.Text = $"{JsonConvert.SerializeObject(POPM)}\n\n{JsonConvert.SerializeObject(POPM1)}";
            MP3.Dispose();
        }

        private void BtnTestStars_Click(object sender, EventArgs e)
        {
            var MP3 = TagLib.File.Create(txtBoxPath.Text);
            var tag = (TagLib.Id3v2.Tag)MP3.GetTag(TagLib.TagTypes.Id3v2);
            var POPM = PopularimeterFrame.Get(tag, "no@email", false);
            var POPM1 = PopularimeterFrame.Get(tag, "warnov@gmail.com", true);
            var UTIF = UserTextInformationFrame.Get(tag, "warnovrate", true);

            var intValue = (int)Math.Pow(2, 3 + stars);
            byte byteValue = intValue > 255 ? (byte)255 : (byte)intValue;
            POPM.Rating = byteValue;
            POPM1.Rating = byteValue;
            UTIF.Text = new string[] { byteValue.ToString() };
            MP3.Save();
            MP3.Dispose();
        }
    }
}
