using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Song
    {
        public string Duration { get; set; }
        public string Name { get; set; }

        public Song(string name, string duration)
        {
            Name = name;
            Duration = duration;
        }

        public override string ToString()
        {
            return Name + ", " + Duration;
        }
    }
}
