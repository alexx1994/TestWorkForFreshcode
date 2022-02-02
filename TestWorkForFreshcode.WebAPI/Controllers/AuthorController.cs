using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWorkForFreshcode.WebAPI.Contexts;
using TestWorkForFreshcode.WebAPI.Interfaces;
using TestWorkForFreshcode.WebAPI.Models;
using TestWorkForFreshcode.WebAPI.Repositories;

namespace TestWorkForFreshcode.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase 
    { 
        IRepository<Author> db;

        public AuthorController(LibraryContext context)
        {
            db = new AuthorRepository(context);
        }

        [HttpGet("Id")]
        public async Task<string> Author(int Id)
        {
            Author author = await db.Get(Id);
            if (author != null)
                return JsonConvert.SerializeObject(author);

            return "Database did not have author with Id - " + Id.ToString() + ".";
        }

        [HttpGet]
        public async Task<string> Authors()
        {
            var authors = await db.GetAll();
            if (authors != null) 
                return JsonConvert.SerializeObject(authors);

            return "Database did not have any author.";
        }

        [HttpPost]
        public async Task<string> Add(Author author)
        {
            if (author != null)
            {
                db.Create(author);

                return "Author successfully added.";
            }

            return "Can not add author to database.";
        }

        [HttpPut]
        public async Task<string> Edit(Author author)
        {
            if (author != null && author.Id != null)
            {
                db.Update(author);

                return "Author successfully updated.";
            }

            return "Can not update author in database.";
        }

        [HttpDelete("Id")]
        public async Task<string> Remove(int Id)
        {
            if (Id != null)
            {
                db.Delete(Id);

                return "Author successfully removed.";
            }

            return "Can not remove author in database.";
        }
    }
}
