using Description.Domain;
using System.Collections.Generic;

namespace Description.Repository
{
    public class MusicChartStorage
    {
        private Dictionary<int, MusicChart> MusicCharts { get; } = new Dictionary<int, MusicChart>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public MusicChart Create(MusicChart musicchart)
        {
            MusicCharts.Add(musicchart.Id, musicchart);
            return musicchart;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public MusicChart Read(int musicchartId)
        {
            return MusicCharts[musicchartId];
        }

        public MusicChart Update(int musicchartId, MusicChart newMusicChart)
        {
            MusicCharts[musicchartId] = newMusicChart;
            return MusicCharts[musicchartId];
        }

        public bool Delete(int musicchartId)
        {
            return MusicCharts.Remove(musicchartId);
        }
    }
}