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

}