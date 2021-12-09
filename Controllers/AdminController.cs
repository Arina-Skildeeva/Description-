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
    [Route("/admin")]
    public class AdminController1 : ControllerBase
    {
        [HttpPut]
        public Admin Create(Admin admin)
        {
            Storage.AdminStorage.Create(admin);
            return Storage.AdminStorage.Read(admin.Id);
        }

        [HttpGet]
        public Admin Read(int adminId)
        {
            return Storage.AdminStorage.Read(adminId);
        }

        [HttpPatch]
        public Admin Update(int adminId, Admin newAdmin)
        {
            return Storage.AdminStorage.Update(adminId, newAdmin);
        }

        [HttpDelete]
        public bool Delete(int adminId)
        {
            return Storage.AdminStorage.Delete(adminId);
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