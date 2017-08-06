using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mp3Ranker
{
    public class Library
    {
        public Library()
        {
            Reset();
        }

        public List<Mp3Info> MP3s { get; set; }

        public void Build(string path)
        {  
            foreach (string d in Directory.GetDirectories(path))
            {
                foreach (string f in Directory.GetFiles(d))
                {
                    if (f.ToLower().Contains("mp3"))
                    {
                        Mp3Info mp3 = new Mp3Info()
                        {
                            Path = f
                        };
                        MP3s.Add(mp3);
                    }
                }
                Build(d);
            }
        }

        public Mp3Info FindByPath(string path)
        {
            var mp3Info =
                (from mp3 in MP3s
                 where mp3.Path == path
                 select mp3).FirstOrDefault();
            return mp3Info;
        }

        public void Save(string path)
        {
            var sLibrary = JsonConvert.SerializeObject(this.MP3s);
            File.WriteAllText(path, sLibrary);
        }

        public void Load(string path)
        {
            var json = File.ReadAllText(path);
            this.MP3s = JsonConvert.DeserializeObject<List<Mp3Info>>(json);            
        }

        private void Reset()
        {
            if (MP3s == null) MP3s = new List<Mp3Info>();
            else MP3s.Clear();
        }
    }
}
