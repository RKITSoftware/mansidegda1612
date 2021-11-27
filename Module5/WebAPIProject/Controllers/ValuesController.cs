using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class ValuesController : ApiController
    {
        List<Book> Books = new List<Book>
            {
                new Book(){BookID=1,BookName="THE GUIDE",AuthorName="R.K"},
                new Book(){BookID=2,BookName="MALGUDI DAYS",AuthorName="R.K"},
                new Book(){BookID=3,BookName="THE PRIVATE LIFE OF AN INDIAN PRINCE",AuthorName="MULK RAJ ANAND"},
                new Book(){BookID=4,BookName="UNTOUCHABLE",AuthorName="MULK RAJ ANAND"},
            };
        // GET api/values
        //action name with Get prefix 
        //Attribute Routing
        [Route("api/values/get/list")]
        public List<Book> GetAll()
        {
            return Books;
        }

        // GET api/values/5
        //Primitive Parameter
        public Book Get(int id)
        {
            return Books.Where(b=>b.BookID== id).FirstOrDefault();
        }

        // POST api/values
        //methods that do not start with an HTTP verb
        //get the value of complex type Parameter from the query string
        [HttpPost]
        public void InsertBook([FromUri] Book objBook)
        {
        }

        // PUT api/values/5
        //Action method name case in-sensitive
        //get the value of Primitive Parameter from the request body
        public void PUT(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        //complex type Parameter
        public void Delete(Book objBook)
        {
        }
    }
}
