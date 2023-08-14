using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Artists
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public static List<Artists> artist = new List<Artists>();

        public Artists(int id, string name) 
        {
            this.Id = id;
            this.Name = name;
        }
    }

}
