using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class ApplicationStorage
    {
        private Dictionary<int, Application> Applications { get; } = new Dictionary<int, Application>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Application application)
        {
            Applications.Add(application.ApplicationId, application);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Application Read(int applicationId)
        {
            return Applications[applicationId];
        }

        public Application Update(int applicationId, Application newApplication)
        {
            Applications[applicationId] = newApplication;
            return Applications[applicationId];
        }

        public bool Delete(int applicationId)
        {
            return Applications.Remove(applicationId);
        }
    }
}