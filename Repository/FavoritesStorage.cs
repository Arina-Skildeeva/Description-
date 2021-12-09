using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class FavoritesStorage
    {
        private Dictionary<int, Favorites> Favoritess { get; } = new Dictionary<int, Favorites>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public Favorites Create(Favorites favorites)
        {
            Favoritess.Add(favorites.Id, favorites);
            return favorites;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Favorites Read(int favoritesId)
        {
            return Favoritess[favoritesId];
        }

        public Favorites Update(int favoritesId, Favorites newFavorites)
        {
            Favoritess[favoritesId] = newFavorites;
            return Favoritess[favoritesId];
        }

        public bool Delete(int favoritesId)
        {
            return Favoritess.Remove(favoritesId);
        }
    }
}