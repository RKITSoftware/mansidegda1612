using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUD_Opration.Models;

namespace CRUD_Opration.Controllers
{
    public class BookController : ApiController
    {
        database objdatabase = new database();
        // GET: api/Book
        [Route("api/Getall")]
        public List<Book> GetAll()
        {
            return (objdatabase.selectAll());
        }

        // GET: api/Book/5
        [Route("api/Get/{id}")]
        public Book Get(int id)
        {
            return (objdatabase.getBookById(id));
        }

        // POST: api/Book
        [HttpPost]
        [Route("api/Add")]
        public void Add([FromBody]Book objBook)
        {
            objdatabase.addBook(objBook);
        }
        [HttpPost]
        [Route("api/Update")]
        public void Update([FromBody] Book objBook)
        {
            objdatabase.updateBook(objBook);
        }

        // DELETE: api/Book/5
        [Route("api/Delete/{id}")]
        public void Delete(int id)
        {
            objdatabase.deleteBook(id);
        }
    }
}
