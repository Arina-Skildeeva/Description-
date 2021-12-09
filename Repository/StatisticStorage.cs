using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class StatisticStorage
    {
        private Dictionary<int, Statistic> Statistics { get; } = new Dictionary<int, Statistic>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public Statistic Create(Statistic statistic)
        {
            Statistics.Add(statistic.Id, statistic);
            return statistic;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Statistic Read(int statisticId)
        {
            return Statistics[statisticId];
        }

        public Statistic Update(int statisticId, Statistic newStatistic)
        {
            Statistics[statisticId] = newStatistic;
            return Statistics[statisticId];
        }

        public bool Delete(int statisticId)
        {
            return Statistics.Remove(statisticId);
        }
    }
}