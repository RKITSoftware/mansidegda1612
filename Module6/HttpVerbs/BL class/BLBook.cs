using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HttpVerbs.Models;

namespace HttpVerbs.BL_class
{
    /// <summary>
    /// BL class of Book controller
    /// public methods:
    /// GetCompleteList,
    /// GetListByID,
    /// AddItem,
    /// EditItem,
    /// RemoveItem
    /// </summary>
    public class BLBook
    {
        //list of books
        List<Book> books = new List<Book>();

        #region public mamber
        //constructor
        public BLBook()
        {
            books.Add(new Book { BookID = 1, BookName = "THE GUIDE", AuthorName = "R.K" });
            books.Add(new Book() { BookID = 2, BookName = "MALGUDI DAYS", AuthorName = "R.K" });
            books.Add(new Book() { BookID = 3, BookName = "THE PRIVATE LIFE OF AN INDIAN PRINCE", AuthorName = "MULK RAJ ANAND" });
            books.Add(new Book() { BookID = 4, BookName = "UNTOUCHABLE", AuthorName = "MULK RAJ ANAND" });

        }

        /// <summary>
        /// GetCompleteList method 
        /// return type : List<Book>
        /// </summary>
        public List<Book> GetCompleteList()
        {
            return books;
        }

        /// <summary>
        /// GetListByID method 
        /// return type : Book
        /// parameter :int id
        /// </summary>
        public Book GetListByID(int id)
        {
            return books.Where(temp => temp.BookID == id).FirstOrDefault();

        }

        /// <summary>
        /// AddItem method 
        /// return type : void
        /// parameter : Book newBook
        /// </summary>
        public void AddItem(Book newBook)
        {
            books.Add(newBook);
        }

        /// <summary>
        /// RemoveItem method 
        /// return type : void
        /// parameter : int id
        /// </summary>
        public void RemoveItem(int id)
        {
            books.Remove(books.Where(x => x.BookID == id).FirstOrDefault());
        }

        /// <summary>
        /// EditItem method 
        /// return type : void
        /// parameter : int id, Book EditBook
        /// </summary>
        public void EditItem(int id, Book EditBook)
        {
            books[id] = EditBook;
        }
        #endregion public mamber
    }
}