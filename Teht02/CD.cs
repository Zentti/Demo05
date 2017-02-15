using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class CD
    {
        

        public string CDName { get; set; }
        public string CDArtist { get; set; }
        public string CDLength { get; set; }

        public List<Song> songs = new List<Song>();

        public CD(string name, string artist, string length)
        {
            CDName = name;
            CDArtist = artist;
            CDLength = length;
        }

        public override string ToString()
        {
            StringBuilder newsongs = new StringBuilder();

            foreach (Song song in songs)
            {
                newsongs.Append("  - " + song.ToString() + "\r\n");
            }
            return "CD data:\r\n- name: " + CDName + "\r\n- artist: " + CDArtist + "\r\n- length: " + CDLength + "\r\n- songs:\r\n" + newsongs.ToString();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }
        
    }
}
