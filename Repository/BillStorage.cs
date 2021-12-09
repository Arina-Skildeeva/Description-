using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class BillStorage
    {
        private Dictionary<int, Bill> Bills { get; } = new Dictionary<int, Bill>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public Bill Create(Bill bill)
        {
            Bills.Add(bill.Bankdetail, bill);
            return bill;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Bill Read(int billBankdetail)
        {
            return Bills[billBankdetail];
        }

        public Bill Update(int billBankdetail, Bill newbill)
        {
            Bills[billBankdetail] = newbill;
            return Bills[billBankdetail];
        }

        public bool Delete(int billBankdetail)
        {
            return Bills.Remove(billBankdetail);
        }
    }
}