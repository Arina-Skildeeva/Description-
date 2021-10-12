using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MusicLibrary.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        [HttpPost]
        [Route("/client/Subscribing")]
        public string Subscribing(string str)
        {
            return "Метод оформления подписки";
        }

        [HttpPost]
        [Route("/client/Unsubscribing")]
        public string Unsubscribing(string str)
        {
            return "Метод отказа подписки";
        }

        [HttpPost]
        [Route("/client/LeavingReviews")]
        public string LeavingReviews(string str)
        {
            return "Метод оставления отзывов";
        }

        [HttpPost]
        [Route("/client/AddingToFavorites")]
        public string AddingToFavoraites(string str)
        {
            return "Метод добавления в избранное ";
        }

        [HttpPost]
        [Route("/client/MakingPlaylists")]
        public string MakingPlaylists(string str)
        {
            return "Метод составления наборов плейлистов";
        }

    }

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
