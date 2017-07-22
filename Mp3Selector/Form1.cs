using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Id3;
using Newtonsoft.Json;
using Id3.Info;

namespace Mp3Selector
{
    public partial class Form1 : Form
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
        int index;



        public Form1()
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
            newSong = false;
            ManualStop();
            LikeNext();
        }

        private void BtnDislike_Click(object sender, EventArgs e)
        {
            newSong = false;            
            ManualStop();
            discardedLibrary.Add(CurrentPath);
            currentLibrary.RemoveAt(index);
            WriteLibraries();
            PlayNext();
        }

        private void BtnPlainPlay_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.play();
            newSong = true;
            auto = true;
        }

        private void BtnPlayerStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Estado: {wmpMain.playState}");
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Posición: {wmpMain.Ctlcontrols.currentPosition} de {wmpMain.currentMedia.duration}");
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
                Thread.Sleep(3000);
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


        #endregion


        #region Methods


        private void PlayNext()
        {
            var length = currentLibrary.Count;
            var rnd = new Random();
            index = rnd.Next(length);          
            wmpMain.URL = CurrentPath;
            AssembleTitle();
            //lblTrack.Text = Path.GetFileNameWithoutExtension(trackPath);
        }

        private void LikeNext()
        {
            newSong = false;
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
            var mp3 = new Mp3File(CurrentPath);
            try
            {
                Id3Tag tag = mp3.GetTag(Id3TagFamily.FileStartTag);
                lblTrack.Text = tag.Title;
                lblArtistAlbum.Text = $"{tag.Artists.Value} ({tag.Album})";
            }
            catch
            {
                lblTrack.Text = "!";
                lblArtistAlbum.Text = CurrentPath;
            }
        }
        #endregion


    }
}
