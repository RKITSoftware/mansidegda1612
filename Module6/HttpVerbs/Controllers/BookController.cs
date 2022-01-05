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
        /// </summary>
        /// <returns>List<Book></returns>
        public List<Book> GetAll()
        {
            List<Book> books = objBookList.GetCompleteList();
            return books;
        }

        /// <summary>
        /// Get method 
        /// <param name="id">int id</param>
        /// </summary>
        /// <returns>Book</returns>
        public Book Get(int id)
        {
            return objBookList.GetListByID(id);
        }

        /// <summary>
        /// Post method 
        /// <param name="newBook">Book newBook</param>
        /// </summary>
        /// <returns>void</returns>
        public void Post(Book newBook)
        {
            objBookList.AddItem(newBook);
        }

        /// <summary>
        /// Put method 
        /// <param name="id">int id</param>
        /// <param name="newBook">Book EditBook</param>
        /// </summary>
        /// <returns>void</returns>
        public void Put(int id, Book editBook)
        {
            objBookList.EditItem(id, editBook);
        }

        /// <summary>
        /// Delete method 
        /// <param name="id">int id</param>
        /// </summary>
        /// <returns>void</returns>
        public void Delete(int id)
        {
            objBookList.RemoveItem(id);
        }
        #endregion public mambers
    }
}


