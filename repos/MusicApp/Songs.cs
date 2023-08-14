using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Songs
    {
        public int SongId { get; set; }
        public string Artist { get; set; }
        public int ArtistID { get; set; }   

        public static List<Songs> songs = new List<Songs>();

        public Songs(int id, string artist, int artistID    )
        {
            this.SongId = id;
            this.Artist = artist;
            this.ArtistID = artistID;
        }
    }
}
