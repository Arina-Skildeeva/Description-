using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class StatisticStorage
    {
        private Dictionary<int, Statistic> Statistics { get; } = new Dictionary<int, Statistic>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public StatisticStorage() => Connection.Open();

        public void Create(Statistic Statistic)
        {
            Statistics.Add(Statistic.StatisticId, Statistic);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Statistic Read(int StatisticId)
        {
            return Statistics[StatisticId];
        }

        public Statistic Update(int StatisticId, Statistic newStatistic)
        {
            Statistics[StatisticId] = newStatistic;
            return Statistics[StatisticId];
        }

        public bool Delete(int StatisticId)
        {
            return Statistics.Remove(StatisticId);
        }
    }
}