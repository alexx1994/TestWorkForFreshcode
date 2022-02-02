using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestWorkForFreshcode.WebAPI.Contexts;
using TestWorkForFreshcode.WebAPI.Interfaces;
using TestWorkForFreshcode.WebAPI.Models;

namespace TestWorkForFreshcode.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IRepository<Book> db;

        public BookController(LibraryContext context)
        {
            //db = new BookRepository(context);
        }

    }
}
