using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class AdminStorage
    {
        private Dictionary<int, Admin> Admins { get; } = new Dictionary<int, Admin>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public Admin Create(Admin admin)
        {
            Admins.Add(admin.Id, admin);
            return admin;
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
            Admins[adminId] = newAdmin;
            return Admins[adminId];
        }

        public bool Delete(int adminId)
        {
            return Admins.Remove(adminId);
        }
    }
}