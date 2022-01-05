using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CRUD_Opration.Models;
using MySql.Data.MySqlClient;

namespace CRUD_Opration
{
    /// <summary>
    /// BL class of Book controller
    /// public methods:
    /// selectAll,
    /// getBookById,
    /// addBook,
    /// updateBook,
    /// deleteBook
    /// </summary>
    public class BLBook
    {
        #region public members
        //ConnectionString
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;

        /// <summary>
        /// selectAll method
        /// </summary>
        /// <returns>List<Book></returns>
        public List<Book> selectAll()
        {
            List<Book> books = new List<Book>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from book", conn);

                    //read data
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book()
                            {
                                BookID = Convert.ToInt32(reader["BookID"]),
                                BookName = reader["BookName"].ToString(),
                                AuthorName = reader["AuthorName"].ToString(),
                             
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection !");

                }
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
            return books;
        }

        /// <summary>
        /// getBookById method 
        /// <param name="id">int id</param>
        /// </summary>
        /// <returns>Book</returns>
        public Book getBookById(int id)
        {
            Book books = new Book();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from book where BookID = " + id + ";", conn);

                    //read data
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.BookID = Convert.ToInt32(reader["BookID"]);
                            books.BookName = reader["BookName"].ToString();
                            books.AuthorName = reader["AuthorName"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection !");

                }
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
            return books;
        }

        /// <summary>
        /// addBook method 
        /// <param name="objBook">Book objBook</param>
        /// </summary>
        /// <returns>string</returns>
        public string addBook(Book objBook)
        {
            List<Book> books = new List<Book>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();

                    //add data
                    MySqlCommand cmd = new MySqlCommand("insert into book (BookId,BookName,AuthorName) values('" + objBook.BookID + "','" + objBook.BookName + "','" + objBook.AuthorName +"';", conn);

                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
        }

        /// <summary>
        /// deleteBook method 
        /// <param name="id">int id</param>
        /// </summary>
        /// <returns>string</returns>
        public string deleteBook(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();

                    //delete command with id
                    MySqlCommand cmd = new MySqlCommand("delete from book where id = " + id, conn);

                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
        }

        /// <summary>
        /// updateBook method 
        /// <param name="objBook">Book objBook</param>
        /// </summary>
        /// <returns>string</returns>
        public string updateBook(Book objBook)
        {
            List<Book> books = new List<Book>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();

                    //update data
                    MySqlCommand cmd = new MySqlCommand("update countries set BookName = '" + objBook.BookName + "',AuthorName = '" + objBook.AuthorName + "';", conn);


                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
        }
        #endregion public members
    }
}
