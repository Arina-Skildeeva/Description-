using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class AuthorStorage
    {
        private Dictionary<int, Author> Authors { get; } = new Dictionary<int, Author>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Author author)
        {
            Authors.Add(author.AuthorId, author);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Author Read(int authorId)
        {
            return Authors[authorId];
        }

        public Author Update(int authorId, Author newAuthor)
        {
            Authors[authorId] = newAuthor;
            return Authors[authorId];
        }

        public bool Delete(int authorId)
        {
            return Authors.Remove(authorId);
        }
    }
}