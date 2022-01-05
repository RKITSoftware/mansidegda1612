using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HttpVerbs.Models;
using HttpVerbs.BL_class;

namespace HttpVerbs.Controllers
{
    /// <summary>
    /// Controller class of Book
    /// public methods:
    /// GetAll,
    /// Get,
    /// Post,
    /// Put,
    /// Delete
    /// </summary>
    public class BookController : ApiController
    {
        //object of BL class
        BLBook objBookList = new BLBook();

        #region public mambers

        /// <summary>
        /// GetAll method 
        /// return type : List<Book>
        /// </summary>
        public List<Book> GetAll()
        {
            List<Book> books = objBookList.GetCompleteList();
            return books;
        }

        /// <summary>
        /// Get method 
        /// return type : Book
        /// parameter :int id
        /// </summary>
        public Book Get(int id)
        {
            return objBookList.GetListByID(id);
        }

        /// <summary>
        /// Post method 
        /// return type : void
        /// parameter : Book newBook
        /// </summary>
        public void Post(Book newBook)
        {
            objBookList.AddItem(newBook);
        }

        /// <summary>
        /// Put method 
        /// return type : void
        /// parameter : int id, Book EditBook
        /// </summary>
        public void Put(int id, Book editBook)
        {
            objBookList.EditItem(id, editBook);
        }

        /// <summary>
        /// Delete method 
        /// return type : void
        /// parameter : int id
        /// </summary>
        public void Delete(int id)
        {
            objBookList.RemoveItem(id);
        }
        #endregion public mambers
    }
}

