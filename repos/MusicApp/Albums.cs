using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Albums
    {
        public int Id { get; set; }
        public string AlbumName { get; set; }

        public static List<Albums> albums = new List<Albums>();

        public Albums(int id, string albumName)
        {
            this.Id = id;
            this.AlbumName = albumName;

        }
    }
}
