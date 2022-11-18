using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAlbumsAppForms
{
    internal class Track
    {
        public int Id { get; set; }
        public string TrackTitle { get; set; }
        public int Number { get; set; }
        public string VideoURL { get; set; }

        public string Lyrics { get; set; }
    }
}
