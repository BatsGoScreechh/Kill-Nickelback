using System;
using System.Collections.Generic;
using System.Collections;

namespace kill_nickelback
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Dictionary<string, string>> goodSongs = new List<Dictionary<string, string>>();

            HashSet<Dictionary<string, string>> allSongs = new HashSet<Dictionary<string, string>>(){
            new Dictionary<string, string>(){
                {"Nickelback", "Rockstar"}
            },
            new Dictionary<string, string>(){
                {"Nickelback", "How You Remind Me"}
            },
            new Dictionary<string, string>(){
                {"Nickelback", "Far Away"}
            },
            new Dictionary<string, string>(){
                {"Aerosmith", "Crying"}
            },
            new Dictionary<string, string>(){
                {"Johnny Cash", "Ring Of Fire"}
            }
        };

            foreach (Dictionary<string, string> songDictionary in allSongs)
            {
                foreach (KeyValuePair<string, string> songKeyValuePair in songDictionary)
                {
                    if (songKeyValuePair.Key != "Nickelback")
                    {
                        goodSongs.Add(songDictionary);
                    }
                }
            }
            foreach(Dictionary<string, string> songDictionary in goodSongs){
                foreach(KeyValuePair<string, string> songKeyValuePair in songDictionary){
                    Console.WriteLine($"{songKeyValuePair.Value} by {songKeyValuePair.Key}");
                }
            }
        }
    }
}
