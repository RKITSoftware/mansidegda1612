using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        List<Book> Books = new List<Book>
            {
                new Book(){BookID=1,BookName="THE GUIDE",AuthorName="R.K"},
                new Book(){BookID=2,BookName="MALGUDI DAYS",AuthorName="R.K"},
                new Book(){BookID=3,BookName="THE PRIVATE LIFE OF AN INDIAN PRINCE",AuthorName="MULK RAJ ANAND"},
                new Book(){BookID=4,BookName="UNTOUCHABLE",AuthorName="MULK RAJ ANAND"},
            };
        public IActionResult Book()
        {
            return View(Books);
        }
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book objBook)
        {
            Books.Add(objBook);
            return RedirectToAction("Book");

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
