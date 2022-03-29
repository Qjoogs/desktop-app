using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalChannels.Models.Data
{
    public class SongType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int SongId { get; set; }

        [Required]
        public Song Song { get; set; }
    }
}
