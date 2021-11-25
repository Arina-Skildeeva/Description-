using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class SongStorage
    {
        private Dictionary<int, Song> Songs { get; } = new Dictionary<int, Song>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public SongStorage() => Connection.Open();

        public void Create(Song Song)
        {
            Songs.Add(Song.SongId, Song);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Song Read(int SongId)
        {
            return Songs[SongId];
        }

        public Song Update(int SongId, Song newSong)
        {
            Songs[SongId] = newSong;
            return Songs[SongId];
        }

        public bool Delete(int SongId)
        {
            return Songs.Remove(SongId);
        }
    }
}