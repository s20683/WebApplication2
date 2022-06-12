using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.DTOs
{
    public class SomeAlbum
    {
        public int IdAlbum { get; set; }
        public String AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public int IdMusicLabel { get; set; }
        public IEnumerable<SomeTrack> Tracks { get; set; }

    }
}
