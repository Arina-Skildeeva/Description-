using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MusicLibrary.Controllers
{
    [ApiController]
    [Route("/admin")]
    public class AdminController1 : ControllerBase
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

        [HttpGet("ApplicationAnswer")]
        public string ApplicationAnswer(string str)
        {
            return str; //метод ответа на заявки
        }

        [HttpGet("CreateCharts")]
        public string CreateCharts(string str)
        {
            return str; // метод составления чартов
        }

    }

}