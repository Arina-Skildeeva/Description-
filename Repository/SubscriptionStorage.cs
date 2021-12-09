using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class SubscriptionStorage
    {
        private Dictionary<int, Subscription> Subscriptions { get; } = new Dictionary<int, Subscription>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public Subscription Create(Subscription subscription)
        {
            Subscriptions.Add(subscription.Id, subscription);
            return subscription;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Subscription Read(int subscriptionId)
        {
            return Subscriptions[subscriptionId];
        }

        public Subscription Update(int subscriptionId, Subscription newSubscription)
        {
            Subscriptions[subscriptionId] = newSubscription;
            return Subscriptions[subscriptionId];
        }

        public bool Delete(int subscriptionId)
        {
            return Subscriptions.Remove(subscriptionId);
        }
    }
}
