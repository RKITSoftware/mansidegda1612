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
        /// return type : List<Book>
        /// </summary>
        
        //api/Getall
        [Route("api/Getall")]
        public List<Book> GetAll()
        {
            return (objdatabase.selectAll());
        }

        /// <summary>
        /// Get method 
        /// return type : Book
        /// parameter :int id
        /// </summary>

        //api/Get/4
        [Route("api/Get/{id}")]
        public Book Get(int id)
        {
            return (objdatabase.getBookById(id));
        }

        /// <summary>
        /// Add method 
        /// return type : string
        /// parameter : Book objBook
        /// </summary>

        //api/Add
        [HttpPost]
        [Route("api/Add")]
        public string Add([FromBody]Book objBook)
        {
            return objdatabase.addBook(objBook);
        }

        /// <summary>
        /// Update method 
        /// return type : string
        /// parameter : Book objBook
        /// </summary>

        //api/Update
        [HttpPost]
        [Route("api/Update")]
        public string Update([FromBody] Book objBook)
        {
            return objdatabase.updateBook(objBook);
        }

        /// <summary>
        /// Delete method 
        /// return type : string
        /// parameter : int id
        /// </summary>

        //api/delete
        [Route("api/Delete/{id}")]
        public string Delete(int id)
        {
           return objdatabase.deleteBook(id);
        }
        #endregion Public members
    }
}
