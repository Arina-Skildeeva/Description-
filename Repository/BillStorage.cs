using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class BillStorage
    {
        private Dictionary<int, Bill> Bills { get; } = new Dictionary<int, Bill>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Bill bill)
        {
            Bills.Add(bill.AuthorId, bill);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Bill Read(int BillDetail)
        {
            return Bills[BillDetail];
        }

        public Bill Update(int BillDetail, Bill newBill)
        {
            Bills[BillDetail] = newBill;
            return Bills[BillDetail];
        }

        public bool Delete(int authorId)
        {
            return Bills.Remove(BillDetail);
        }
    }
}