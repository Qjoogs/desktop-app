using MusicalChannels.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalChannels.Models.Services
{
    public static class DataService
    {
        public static IEnumerable<Channel> GetChannels()
        {
            var listOfChannels = new List<Channel>();
            using (DBContext context = new DBContext())
            {
                foreach (Channel channel in context.Channels)
                {
                    listOfChannels.Add(channel);
                }
            }
            return listOfChannels;
        }
        public static IEnumerable<Song> GetSongs()
        {
            var listOfSongs = new List<Song>();
            using (DBContext context = new DBContext())
            {
                foreach (Song song in context.Songs)
                {
                    listOfSongs.Add(song);
                }
            }
            return listOfSongs;
        }
        public static IEnumerable<Artist> GetArtists()
        {
            var listOfArtists = new List<Artist>();
            using (DBContext context = new DBContext())
            {
                foreach (Artist artist in context.Artist)
                {
                    listOfArtists.Add(artist);
                }
            }
            return listOfArtists;
        }



        public static (bool,string) AddChannel(Channel channel)
        {
            bool isTrue = false;
            string error = null;
            using (DBContext context = new DBContext())
            {
                var currSong = context.Songs.Where(x => x.Name == channel.Name).FirstOrDefault();

                if (currSong == null)
                {
                    context.Channels.Add(channel);
                    context.SaveChanges();
                    isTrue = true;
                }
                else
                {
                    error = "the channel already exists";
                }
            }
            return (isTrue, error);
        }
        
        public static (bool, string) AddSong(Song song)
        {
            bool isTrue = false;
            string error = null;

            using(DBContext context = new DBContext())
            {
                var currSong = context.Songs.Where(x => x.Name == song.Name).FirstOrDefault();

                if (currSong == null)
                {
                    context.Songs.Add(song);
                    context.SaveChanges();
                    isTrue = true;
                }
                else
                {
                    error = "the song already exists";
                }
            }
            return (isTrue, error);
        }
        public static (bool, string) AddArtist(Artist artist)
        {
            bool isTrue = false;
            string error = null;

            using (DBContext context = new DBContext())
            {
                var currArtist = context.Artist.Where(x => x.Name == artist.Name).FirstOrDefault();

                if (currArtist == null)
                {
                    context.Artist.Add(artist);
                    context.SaveChanges();
                    isTrue = true;
                }
                else
                {
                    error = "the artist already exists";
                }
            }
            return (isTrue, error);
        }

        public static (bool, string) AddArtistSong(Artist artist)
        {
            bool isTrue = false;
            string error = null;

            using (DBContext context = new DBContext())
            {
                var currArtist = context.Artist.Where(x => x.Name == artist.Name).FirstOrDefault();

                if (currArtist != null)
                {
                    context.Artist.Add(artist);
                    context.SaveChanges();
                    isTrue = true;
                }
                else
                {
                    error = "the artist doesn't exists";
                }
            }
            return (isTrue, error);
        }

        public static void RemoveSong(Song song)
        {
            using(DBContext context = new DBContext())
            {
                context.Remove(song);
                context.SaveChanges();
            }
        }

        public static void RemoveChannel(Channel channel)
        {
            using(DBContext context = new DBContext())
            {
                context.Remove(channel);
                context.SaveChanges();
            }
        }
    }
}
