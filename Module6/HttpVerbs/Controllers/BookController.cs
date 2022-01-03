using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HttpVerbs.Models;

namespace HttpVerbs.Controllers
{
    public class BookList
    {
        List<Book> books = new List<Book>();
        public BookList()
        {
            books.Add(new Book { BookID = 1, BookName = "THE GUIDE", AuthorName = "R.K" });
            books.Add(new Book() { BookID = 2, BookName = "MALGUDI DAYS", AuthorName = "R.K" });
            books.Add(new Book() { BookID = 3, BookName = "THE PRIVATE LIFE OF AN INDIAN PRINCE", AuthorName = "MULK RAJ ANAND" });
            books.Add(new Book() { BookID = 4, BookName = "UNTOUCHABLE", AuthorName = "MULK RAJ ANAND" });
                
        }

        public List<Book> GetCompleteList()
        {
            return books;
        }

        public Book GetListByID(int id)
        {
            return books.Where(temp => temp.BookID == id).FirstOrDefault();

        }

        public void AddItem(Book newBook)
        {
            books.Add(newBook);
        }

        public void RemoveItem(int id)
        {
            books.Remove(books.Where(x => x.BookID==id).FirstOrDefault());
        }

        public void EditItem(int id, Book EditBook)
        {
            books[id] = EditBook;
        }
    }
    public class BookController : ApiController
    {
        BookList objBookList = new BookList();
        // GET: api/book
        public List<Book> Get()
        {
            List<Book> books = objBookList.GetCompleteList();
            return books;
        }

        // GET: api/book/5
        public Book Get(int id)
        {
            return objBookList.GetListByID(id);
        }

        // POST: api/book
        public void Post(Book newBook)
        {
            objBookList.AddItem(newBook);
        }

        // PUT: api/book/5
        public void Put(int id, Book editBook)
        {
            objBookList.EditItem(id, editBook);
        }

        // DELETE: api/book/5
        public void Delete(int id)
        {
            objBookList.RemoveItem(id);
        }
    }
}
