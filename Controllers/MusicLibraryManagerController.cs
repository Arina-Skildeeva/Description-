using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MusicLibrary.Controllers
{
    [ApiController]
    [Route("/manager")]
    public class ManagerController : ControllerBase
    {
        [HttpGet]
        [Route("/manager/Charting")]
        public string Charting(string str)
        {
            return "Метод составления чартов";
        }

        [HttpGet]
        [Route("/manager/ApprovingApplications")]
        public string ApprovingApplications(string str)
        {
            return "Метод согласия на заявки авторов";
        }

        [HttpGet]
        [Route("/manager/RejectionOfApplications")]
        public string RejectionOfApplications(string str)
        {
            return "Метод отказа от заявки авторов";
        }

        [HttpGet]
        [Route("/manager/UserAccounting")]
        public string UserAccounting(string str)
        {
            return "Метод учёта пользователей";
        }
    }
}
