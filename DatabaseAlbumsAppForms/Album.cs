using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAlbumsAppForms
{
    internal class Album
    {
        public int Id { get; set; }
        public string AlbumTitle { get; set; }

        public string Artist { get; set; }

        public int Year { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        public List<Track> Tracks { get; set; }


    }
}
