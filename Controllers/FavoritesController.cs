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
    [Route("/favorites")]
    public class FavoritesController : ControllerBase
    {
        [HttpPut]
        public Favorites Create(Favorites favorites)
        {
            Storage.FavoritesStorage.Create(favorites);
            return Storage.FavoritesStorage.Read(favorites.Id);
        }

        [HttpGet]
        public Favorites Read(int favoritesId)
        {
            return Storage.FavoritesStorage.Read(favoritesId);
        }

        [HttpPatch]
        public Favorites Update(int FavoritesId, Favorites newFavorites)
        {
            return Storage.FavoritesStorage.Update(FavoritesId, newFavorites);
        }

        [HttpDelete]
        public bool Delete(int favoritesId)
        {
            return Storage.FavoritesStorage.Delete(favoritesId);
        }



    }

}