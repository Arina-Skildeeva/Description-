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
    [Route("/artist")]
    public class ArtistController : ControllerBase
    {
        [HttpPut]
        public Artist Create(Artist artist)
        {
            Storage.ArtistStorage.Create(artist);
            return Storage.ArtistStorage.Read(artist.Id);
        }

        [HttpGet]
        public Artist Read(int artistId)
        {
            return Storage.ArtistStorage.Read(artistId);
        }

        [HttpPatch]
        public Artist Update(int artistId, Artist newArtist)
        {
            return Storage.ArtistStorage.Update(artistId, newArtist);
        }

        [HttpDelete]
        public bool Delete(int artistId)
        {
            return Storage.ArtistStorage.Delete(artistId);
        }


    }

}