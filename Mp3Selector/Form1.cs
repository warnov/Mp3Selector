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

        List<string> currentLibrary;
        List<string> discardedLibrary;
        List<string> selectedLibrary;
        const string LIBPATH = @"d:\music\";
        const string CURLIB = "currentLibrary.txt";
        const string SELLIB = "selectedLibrary.txt";
        const string DISLIB = "discardedLibrary.txt";
        bool auto = false;
        int index;

        public Form1()
        {
            InitializeComponent();           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayNext();            
        }

        private void PlayNext()
        {
            auto = true;
            var length = currentLibrary.Count;
            var rnd = new Random();
            index = rnd.Next(length);
            var trackPath = currentLibrary[index];
            wmpMain.URL = trackPath;
            wmpMain.Ctlcontrols.play();
            lblTrack.Text = Path.GetFileNameWithoutExtension(trackPath);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ManualStop();            
        }

        private void ManualStop()
        {
            auto = false;
            wmpMain.Ctlcontrols.stop();
        }        

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            currentLibrary = new List<string>();
            selectedLibrary = new List<string>();
            discardedLibrary = new List<string>();
            BuildLibrary(LIBPATH, currentLibrary);
            WriteLibraries();
            MessageBox.Show("Library Created and Written!");
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

        private void btnLoadLibrary_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText($"{LIBPATH}{CURLIB}");
            currentLibrary = JsonConvert.DeserializeObject<List<string>>(json);
            MessageBox.Show($"{currentLibrary.Count} songs loaded to classify");

            json = File.ReadAllText($"{LIBPATH}{SELLIB}");
            selectedLibrary = JsonConvert.DeserializeObject<List<string>>(json);

            json = File.ReadAllText($"{LIBPATH}{DISLIB}");
            discardedLibrary = JsonConvert.DeserializeObject<List<string>>(json);
        }

        private void wmpMain_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 10 && auto)
            {
                ManualStop();
                var currentPath = currentLibrary[index];
                selectedLibrary.Add(currentPath);
                currentLibrary.RemoveAt(index);
                WriteLibraries();                
                PlayNext();
            }
        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            lblDiscarded.Text = Path.GetFileNameWithoutExtension(currentLibrary[index]);
            ManualStop();
            var currentPath = currentLibrary[index];
            discardedLibrary.Add(currentPath);
            currentLibrary.RemoveAt(index);
            WriteLibraries();
            PlayNext();
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

        private void btnPlainPlay_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.play();
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
            wmpMain.Ctlcontrols.currentPosition += 50;
        }
    }
}
