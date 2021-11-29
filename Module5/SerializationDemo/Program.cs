using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //list of Book type
            List<Book> Books = new List<Book>
            {
                new Book(){BookID=1,BookName="THE GUIDE",AuthorName="R.K"},
                new Book(){BookID=2,BookName="MALGUDI DAYS",AuthorName="R.K"},
                new Book(){BookID=3,BookName="THE PRIVATE LIFE OF AN INDIAN PRINCE",AuthorName="MULK RAJ ANAND"},
                new Book(){BookID=4,BookName="UNTOUCHABLE",AuthorName="MULK RAJ ANAND"},
            };

            //Binary Serialization
            FileStream Binarystream = new FileStream("BinaryBooks.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(Binarystream, Books);

            Binarystream.Close();

            //Binary Deserialization
            FileStream DEBinarystream = new FileStream("BinaryBooks.txt", FileMode.OpenOrCreate);
            
            List<Book> ListOfBooks =(List<Book>) formatter.Deserialize(DEBinarystream);

            foreach(var item in ListOfBooks)
            {
                Console.WriteLine("BookID : " + item.BookID);
                Console.WriteLine("BookName : " + item.BookName);
                Console.WriteLine("AuthorName : " + item.AuthorName);
                Console.Write("");
            }

            DEBinarystream.Close();

            //XML Serialization
            FileStream XMLstream = new FileStream("XmlBooks.txt", FileMode.OpenOrCreate);
            XmlSerializer Xml = new XmlSerializer(typeof(List<Book>));

            Xml.Serialize(XMLstream, Books);
            XMLstream.Close();

            //XML Deserialization
            FileStream DEXMLstream = new FileStream("XmlBooks.txt", FileMode.OpenOrCreate);

            List<Book> ListOfBooks2 = (List<Book>)Xml.Deserialize(DEXMLstream);

            foreach (var item in ListOfBooks2)
            {
                Console.WriteLine("BookID : " + item.BookID);
                Console.WriteLine("BookName : " + item.BookName);
                Console.WriteLine("AuthorName : " + item.AuthorName);
                Console.Write("");
            }

            DEXMLstream.Close();


            //json Serialization
            string jsonString = JsonSerializer.Serialize(Books);
            File.WriteAllText("JsonBooks.txt", jsonString);

            //json Deserialization
            string jsonString2 = File.ReadAllText("JsonBooks.txt");
            List<Book> ListOfBooks3 = JsonSerializer.Deserialize<List<Book>>(jsonString2);

            foreach (var item in ListOfBooks3)
            {
                Console.WriteLine("BookID : " + item.BookID);
                Console.WriteLine("BookName : " + item.BookName);
                Console.WriteLine("AuthorName : " + item.AuthorName);
                Console.Write("");
            }
        }
    }
}
