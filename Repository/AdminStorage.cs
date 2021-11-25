using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class AuthorStorage
    {
        private Dictionary<int, Admin> Admin { get; } = new Dictionary<int, Admin>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Admin admin)
        {
            Admins.Add(admin.AdminId, admin);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Admin Read(int adminId)
        {
            return Admins[adminId];
        }

        public Admin Update(int adminId, Admin newAdmin)
        {
            Admin[adminId] = newAdmin;
            return Admins[adminId];
        }

        public bool Delete(int adminId)
        {
            return Admins.Remove(authorId);
        }
    }
}