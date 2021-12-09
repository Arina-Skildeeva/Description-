using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class ListeningStorage
    {
        private Dictionary<int, Listening> Listenings { get; } = new Dictionary<int, Listening>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public Listening Create(Listening listening)
        {
            Listenings.Add(listening.Listeningnumber, listening);
            return listening;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Listening Read(int Listeningnumber)
        {
            return Listenings[Listeningnumber];
        }

        public Listening Update(int Listeningnumber, Listening newListening)
        {
            Listenings[Listeningnumber] = newListening;
            return Listenings[Listeningnumber];
        }

        public bool Delete(int Listeningnumber)
        {
            return Listenings.Remove(Listeningnumber);
        }
    }
}