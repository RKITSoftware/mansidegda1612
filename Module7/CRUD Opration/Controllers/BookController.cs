using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUD_Opration.Models;

namespace CRUD_Opration.Controllers
{
    /// <summary>
    /// Controller class of Book
    /// public methods:
    /// GetAll,
    /// Get,
    /// Add,
    /// Update,
    /// Delete
    /// </summary>
    public class BookController : ApiController
    {
        #region Public members

        //object of BL class
        BLBook objdatabase = new BLBook();

        /// <summary>
        /// GetAll method 
        /// </summary>
        /// <returns>List<Book></returns>

        //api/Getall
        [Route("api/Getall")]
        public List<Book> GetAll()
        {
            return (objdatabase.selectAll());
        }

        /// <summary>
        /// Get method 
        /// <param name="id">int id</param>
        /// </summary>
        /// <returns>Book</returns>

        //api/Get/4
        [Route("api/Get/{id}")]
        public Book Get(int id)
        {
            return (objdatabase.getBookById(id));
        }

        /// <summary>
        /// Add method 
        /// <param name="objBook">Book objBook</param>
        /// </summary>
        /// <returns>string</returns>

        //api/Add
        [HttpPost]
        [Route("api/Add")]
        public string Add([FromBody]Book objBook)
        {
            return objdatabase.addBook(objBook);
        }

        /// <summary>
        /// Update method 
        /// <param name="objBook">Book objBook</param>
        /// </summary>
        /// <returns>string</returns>

        //api/Update
        [HttpPost]
        [Route("api/Update")]
        public string Update([FromBody] Book objBook)
        {
            return objdatabase.updateBook(objBook);
        }

        /// <summary>
        /// Delete method 
        /// <param name="id">int id</param>
        /// </summary>
        /// <returns>string</returns>

        //api/delete
        [Route("api/Delete/{id}")]
        public string Delete(int id)
        {
           return objdatabase.deleteBook(id);
        }
        #endregion Public members
    }
}
