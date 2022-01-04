using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CRUD_Opration.Models;
using MySql.Data.MySqlClient;

namespace CRUD_Opration
{
    public class database
    {
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;

        //retrive all data
        public List<Book> selectAll()
        {
            List<Book> books = new List<Book>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from book", conn);

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

            }
            return books;
        }

        //retrive data by id
        public Book getBookById(int id)
        {
            Book books = new Book();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from book where BookID = " + id + ";", conn);

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
                    conn.Close();
                }

            }
            return books;
        }

        //add data
        public string addBook(Book objBook)
        {
            List<Book> books = new List<Book>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

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
                    conn.Close();
                }

            }
        }

        //delete data
        public string deleteBook(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

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
                    conn.Close();
                }

            }
        }

        //update data
        public string updateBook(Book objBook)
        {
            List<Book> books = new List<Book>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

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
                    conn.Close();
                }

            }
        }
    }
}