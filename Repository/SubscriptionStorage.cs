using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class SubscriptionStorage
    {
        private Dictionary<int, Subscription> Subscriptions { get; } = new Dictionary<int, Subscription>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Number=myUsername;Password=myPassword;");
        //public SubscriptionStorage() => Connection.Open();

        public voNumber Create(Subscription Subscription)
        {
            Subscriptions.Add(Subscription.SubscriptionNumber, Subscription);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Subscription Read(int SubscriptionNumber)
        {
            return Subscriptions[SubscriptionNumber];
        }

        public Subscription Update(int SubscriptionNumber, Subscription newSubscription)
        {
            Subscriptions[SubscriptionNumber] = newSubscription;
            return Subscriptions[SubscriptionNumber];
        }

        public bool Delete(int SubscriptionNumber)
        {
            return Subscriptions.Remove(SubscriptionNumber);
        }
    }
}