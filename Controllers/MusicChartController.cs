using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Description.Domain;
using Description.Repository;
using Microsoft.Extensions.Logging;

namespace MusicLibrary.Controllers
{
    [ApiController]
    [Route("/musicchart")]
    public class MusicChartController : ControllerBase
    {
        [HttpPut]
        public MusicChart Create(MusicChart musicchart)
        {
            Storage.MusicChartStorage.Create(musicchart);
            return Storage.MusicChartStorage.Read(musicchart.Id);
        }

        [HttpGet]
        public MusicChart Read(int musicchartId)
        {
            return Storage.MusicChartStorage.Read(musicchartId);
        }

        [HttpPatch]
        public MusicChart Update(int musicchartId, MusicChart newMusicChart)
        {
            return Storage.MusicChartStorage.Update(musicchartId, newMusicChart);
        }

        [HttpDelete]
        public bool Delete(int musicchartId)
        {
            return Storage.MusicChartStorage.Delete(musicchartId);
        }
    }
}