using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.DTOs
{
    public class SomeTrack
    {
        public int IdTrack { get; set; }
        public String TrackName { get; set; }
        public float Duration { get; set; }
        public int? IdMusicAlbum { get; set; }
    }
}
