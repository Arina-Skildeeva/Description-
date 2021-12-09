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
    [Route("/application")]
    public class ApplicationController : ControllerBase
    {
        [HttpPut]
        public Application Create(Application application)
        {
            Storage.ApplicationStorage.Create(application);
            return Storage.ApplicationStorage.Read(application.Id);
        }

        [HttpGet]
        public Application Read(int applicationId)
        {
            return Storage.ApplicationStorage.Read(applicationId);
        }

        [HttpPatch]
        public Application Update(int applicationId, Application newApplication)
        {
            return Storage.ApplicationStorage.Update(applicationId, newApplication);
        }

        [HttpDelete]
        public bool Delete(int applicationId)
        {
            return Storage.ApplicationStorage.Delete(applicationId);
        }
        
    }

}