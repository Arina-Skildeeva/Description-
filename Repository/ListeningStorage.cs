using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class ListeningStorage
    {
        private Dictionary<int, Listening> Listenings { get; } = new Dictionary<int, Listening>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Number=myUsername;Password=myPassword;");
        //public ListeningStorage() => Connection.Open();

        public voNumber Create(Listening Listening)
        {
            Listenings.Add(Listening.ListeningNumber, Listening);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Listening Read(int ListeningNumber)
        {
            return Listenings[ListeningNumber];
        }

        public Listening Update(int ListeningNumber, Listening newListening)
        {
            Listenings[ListeningNumber] = newListening;
            return Listenings[ListeningNumber];
        }

        public bool Delete(int ListeningNumber)
        {
            return Listenings.Remove(ListeningNumber);
        }
    }
}