using Description.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Description.Repository
{
    public class MusicChartStorage
    {
        private Dictionary<int, MusicChart> MusicCharts { get; } = new Dictionary<int, MusicChart>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public MusicChartStorage() => Connection.Open();

        public void Create(MusicChart MusicChart)
        {
            MusicCharts.Add(MusicChart.MusicChartId, MusicChart);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public MusicChart Read(int MusicChartId)
        {
            return MusicCharts[MusicChartId];
        }

        public MusicChart Update(int MusicChartId, MusicChart newMusicChart)
        {
            MusicCharts[MusicChartId] = newMusicChart;
            return MusicCharts[MusicChartId];
        }

        public bool Delete(int MusicChartId)
        {
            return MusicCharts.Remove(MusicChartId);
        }
    }
}