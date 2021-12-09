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
    [Route("/song")]
    public class SongController : ControllerBase
    {
        [HttpPut]
        public Song Create(Song song)
        {
            Storage.SongStorage.Create(song);
            return Storage.SongStorage.Read(song.Id);
        }

        [HttpGet]
        public Song Read(int songId)
        {
            return Storage.SongStorage.Read(songId);
        }

        [HttpPatch]
        public Song Update(int songId, Song newSong)
        {
            return Storage.SongStorage.Update(songId, newSong);
        }

        [HttpDelete]
        public bool Delete(int songId)
        {
            return Storage.SongStorage.Delete(songId);
        }
    }
}