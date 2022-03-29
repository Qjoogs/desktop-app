using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalChannels.Models.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongType> SongTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artist { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-R5985IM\SQLSERVER;Initial Catalog=MusicChannelsDB;Trusted_Connection=True");
        }

    }
}
