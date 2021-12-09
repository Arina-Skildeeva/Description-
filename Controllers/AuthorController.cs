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
    [Route("/author")]
    public class AuthorController1 : ControllerBase
    {
        [HttpPut]
        public Author Create(Author author)
        {
            Storage.AuthorStorage.Create(author);
            return Storage.AuthorStorage.Read(author.Id);
        }

        [HttpGet]
        public Author Read(int authorId)
        {
            return Storage.AuthorStorage.Read(authorId);
        }

        [HttpPatch]
        public Author Update(int authorId, Author newAuthor)
        {
            return Storage.AuthorStorage.Update(authorId, newAuthor);
        }

        [HttpDelete]
        public bool Delete(int authorId)
        {
            return Storage.AuthorStorage.Delete(authorId);
        }

        [HttpGet("SendApplication")]
        public string SendApplication(string str)
        {
            return str; //метод подачи заявки на загрузку своих композиций 
        }

        [HttpGet("StatisticView")]
        public string StatisticView(string str)
        {
            return str; //метод просмотра статистики
        }

    }

}