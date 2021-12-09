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
    [Route("/statistic")]
    public class StatisticController : ControllerBase
    {
        [HttpPut]
        public Statistic Create(Statistic statistic)
        {
            Storage.StatisticStorage.Create(statistic);
            return Storage.StatisticStorage.Read(statistic.Id);
        }

        [HttpGet]
        public Statistic Read(int statisticId)
        {
            return Storage.StatisticStorage.Read(statisticId);
        }

        [HttpPatch]
        public Statistic Update(int statisticId, Statistic newStatistic)
        {
            return Storage.StatisticStorage.Update(statisticId, newStatistic);
        }

        [HttpDelete]
        public bool Delete(int statisticId)
        {
            return Storage.StatisticStorage.Delete(statisticId);

        }

    }
}