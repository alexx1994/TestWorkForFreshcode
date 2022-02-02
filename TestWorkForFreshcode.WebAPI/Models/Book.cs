using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWorkForFreshcode.WebAPI.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public DateTime Published { get; set; }
        public string Language { get; set; }
        public string Redaction { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public DateTime Published { get; set; }
        public string Language { get; set; }
        public string Redaction { get; set; }
        public int AuthorId { get; set; }
    }
}
