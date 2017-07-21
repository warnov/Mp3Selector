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
using Newtonsoft.Json;

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
        int index;



        public Form1()
        {
            InitializeComponent();
            LoadLibrary();
        }
        #endregion


        #region Events

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tmrMain.Enabled = true;
            newSong = true;
            PlayNext();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ManualStop();
            tmrMain.Enabled = false;
        }

        private void btnBuildLibrary_Click(object sender, EventArgs e)
        {
            currentLibrary = new List<string>();
            selectedLibrary = new List<string>();
            discardedLibrary = new List<string>();
            BuildLibrary(LIBPATH, currentLibrary);
            WriteLibraries();
            MessageBox.Show("Library Created and Written!");
        }

        private void btnLikeNext_Click(object sender, EventArgs e)
        {
            newSong = false;
            ManualStop();
            LikeNext();
        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            newSong = false;
            lblDiscarded.Text = Path.GetFileNameWithoutExtension(currentLibrary[index]);
            ManualStop();           
            discardedLibrary.Add(currentLibrary[index]);
            currentLibrary.RemoveAt(index);
            WriteLibraries();
            PlayNext();
        }

        private void btnPlainPlay_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.play();
            newSong = true;
        }

        private void btnPlayerStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Estado: {wmpMain.playState}");
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Posición: {wmpMain.Ctlcontrols.currentPosition} de {wmpMain.currentMedia.duration}");
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.currentPosition += 60;
        }

        private void btnHop_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.currentPosition += 30;
        }

        private void wmpMain_PlayStateChange(object sender,
            AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (wmpMain.playState == WMPLib.WMPPlayState.wmppsStopped && newSong)
            {
                LikeNext();
            }
        }

        private void LikeNext()
        {
            newSong = false;
            selectedLibrary.Add(currentLibrary[index]);
            currentLibrary.RemoveAt(index);
            WriteLibraries();
            PlayNext();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (wmpMain.playState == WMPLib.WMPPlayState.wmppsReady||
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
        }


        #endregion


        #region Methods


        private void PlayNext()
        {           
            var length = currentLibrary.Count;
            var rnd = new Random();
            index = rnd.Next(length);
            var trackPath = currentLibrary[index];
            wmpMain.URL = trackPath;          
            lblTrack.Text = Path.GetFileNameWithoutExtension(trackPath);
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
                            lblTrack.Text = f;
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

        private void LoadLibrary()
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
        #endregion


    }
}
