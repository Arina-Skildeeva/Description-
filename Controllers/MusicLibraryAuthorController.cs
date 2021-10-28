using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MusicLibrary.Controllers
{

    [ApiController]
    [Route("/author")]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        [Route("/author/RequestingToUpload")]
        public string RequestingToUpload(string str)
        {
            return "Метод подачи заявки на загрузку своих композиций";
        }

        [HttpGet]
        [Route("/author/ViewingStatistics")]
        public string ViewingStatistics(string str)
        {
            return "Метод просмотра статистики";
        }



    }

}