using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalChannels.Models.Data
{
    public class Channel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChannelLogo { get; set; }
        public int? SongId { get; set; }

        public Song Song { get; set; }

    }
}
