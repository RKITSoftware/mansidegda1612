using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serialization.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialization.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        List<Book> Books = new List<Book>
            {
                new Book(){BookID=1,BookName="THE GUIDE",AuthorName="R.K"},
                new Book(){BookID=2,BookName="MALGUDI DAYS",AuthorName="R.K"},
                new Book(){BookID=3,BookName="THE PRIVATE LIFE OF AN INDIAN PRINCE",AuthorName="MULK RAJ ANAND"},
                new Book(){BookID=4,BookName="UNTOUCHABLE",AuthorName="MULK RAJ ANAND"},
            };
        public IActionResult Index()
        {
            //use camel casing 
            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy =JsonNamingPolicy.CamelCase
            };
            return Json(Books, options);
        }

       
      
    }
}
