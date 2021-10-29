using System;

namespace Access_Modifiers
{
    class Shape
    {
        //protected string
        protected string shape = "Circle";
    }
    class circle : Shape
    {
        public void print()
        {
            //accessible as circle is derive from shape 
            Console.WriteLine(shape);
        }
    }
    class Program
    {
        //public class
        public class Person
        {
            //public string
            public string Name = "mansi";
            //private string
            private string lastname = "degda";
            //internal int
            internal int age=21;

        }

        //
        static void Main(string[] args)
        {
            Person objPerson = new Person();
            Shape objShape = new Shape();
            //accessible as it is public
            Console.WriteLine(objPerson.Name);

            //not accessible as it is private
            //Console.WriteLine(objPerson.lastname);

            //not acssible as it is protected
           // Console.WriteLine(objShape.shape);

            //accessible as it is internal
            Console.WriteLine(objPerson.age);

        }
    }
}
