using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalChannels.Models.Data
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Channel> Channels { get; set; }
        public List<SongType> SongTypes { get; set; }
        public List<Artist> Artists { get; set; }

    }
}
