using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class ArtistStorage
    {
        private Dictionary<int, Artist> Artists { get; } = new Dictionary<int, Artist>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public Artist Create(Artist artist)
        {
            Artists.Add(artist.Id, artist);
            return artist;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Artist Read(int artistId)
        {
            return Artists[artistId];
        }

        public Artist Update(int artistId, Artist newArtist)
        {
            Artists[artistId] = newArtist;
            return Artists[artistId];
        }

        public bool Delete(int artistId)
        {
            return Artists.Remove(artistId);
        }
    }
}