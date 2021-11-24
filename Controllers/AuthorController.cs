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
    public class AuthorController1 : ControllerBase
    {
        [HttpPut("Create")]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet("Read")]
        public string Read(string str)
        {
            return str;
        }

        [HttpGet("SendApplication")]
        public string SendApplication(string str)
        {
            return str; //метод подачи заявки на загрузку своих композиций 
        }

        [HttpGet("StatisticView")]
        public string StatisticView(string str)
        {
            return str; //метод просмотра статистики
        }

    }

}