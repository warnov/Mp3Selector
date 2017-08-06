using System.Text;
using Newtonsoft.Json;

namespace Mp3Ranker
{
    public class Mp3Info
    {
        public const char SEP = '-';
        public string Path { get; set; }
        public short[] Values { get; set; }
        [JsonIgnore]
        public string AttributesLine
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (short value in Values)
                {
                    sb.Append($"{value}{SEP}");
                }
                sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            }
        }

        public void SetAttributes(string attributesLine)
        {
            var attributesArray = attributesLine.Split(SEP);
            for (int i = 0; i < attributesArray.Length; i++)
            {
                Values[i] = short.Parse(attributesArray[i]);
            }            
        }

        public void CopyAttributes(Mp3Info source)
        {
            Values = new short[21];
            for (int i = 0; i < source.Values.Length; i++)
            {
                Values[i] = source.Values[i];
            }
        }
    }
}

/*
0 Ranking
1 Happiness
2 Sadness
3 Anger
4 Energetic
5 Cultured
6 Car
7 HeavyCar
8 Sleepy
9 RockWithFriends
10 Electro
11 Minimal
12 Rock
13 Pop
14 Jazz
15 Classic
16 Folk
17 Nineties
18 Focus
19 Instrumental
20 Spanish
*/