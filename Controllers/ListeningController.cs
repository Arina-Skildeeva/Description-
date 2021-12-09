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
    [Route("/listening")]
    public class ListeningController1 : ControllerBase
    {
        [HttpPut]
        public Listening Create(Listening listening)
        {
            Storage.ListeningStorage.Create(listening);
            return Storage.ListeningStorage.Read(listening.Listeningnumber);
        }

        [HttpGet]
        public Listening Read(int Listeningnumber)
        {
            return Storage.ListeningStorage.Read(Listeningnumber);
        }

        [HttpPatch]
        public Listening Update(int Listeningnumber, Listening newListening)
        {
            return Storage.ListeningStorage.Update(Listeningnumber, newListening);
        }

        [HttpDelete]
        public bool Delete(int Listeningnumber)
        {
            return Storage.ListeningStorage.Delete(Listeningnumber);
        }
        
    }

}