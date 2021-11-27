using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serialization.Models;

namespace Serialization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        List<Book> Books = new List<Book>
            {
                new Book(){BookID=1,BookName="THE GUIDE",AuthorName="R.K"},
                new Book(){BookID=2,BookName="MALGUDI DAYS",AuthorName="R.K"},
                new Book(){BookID=3,BookName="THE PRIVATE LIFE OF AN INDIAN PRINCE",AuthorName="MULK RAJ ANAND"},
                new Book(){BookID=4,BookName="UNTOUCHABLE",AuthorName="MULK RAJ ANAND"},
            };
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {

            return Books.ToList<Book>();
        }
    }
}
