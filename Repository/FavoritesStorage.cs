using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class FavoriteStorage
    {
        private Dictionary<int, Favorite> Favorites { get; } = new Dictionary<int, Favorite>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public FavoriteStorage() => Connection.Open();

        public void Create(Favorite Favorite)
        {
            Favorites.Add(Favorite.Id, Favorite);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Favorite Read(int Id)
        {
            return Favorites[Id];
        }

        public Favorite Update(int Id, Favorite newFavorite)
        {
            Favorites[Id] = newFavorite;
            return Favorites[FavoriteId];
        }

        public bool Delete(int Id)
        {
            return Favorites.Remove(Id);
        }
    }
}