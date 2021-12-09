using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class SongStorage
    {
        private Dictionary<int, Song> Songs { get; } = new Dictionary<int, Song>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public Song Create(Song song)
        {
            Songs.Add(song.Id, song);
            return song;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Song Read(int songId)
        {
            return Songs[songId];
        }

        public Song Update(int songId, Song newSong)
        {
            Songs[songId] = newSong;
            return Songs[songId];
        }

        public bool Delete(int songId)
        {
            return Songs.Remove(songId);
        }
    }
}