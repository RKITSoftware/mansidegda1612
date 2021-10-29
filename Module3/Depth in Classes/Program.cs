using System;

namespace Depth_in_Classes
{
    class Program
    {
        public class Dog
        {
            // Property 1
            private string _name;
            public string name
            {
                get { return _name; }
                set
                {
                    _name = value;
                }
            }

            // Property 2
            private string _breed;
            public string breed
            {
                get { return _breed; }
                set
                {
                    _breed = value;
                }
            }

            // Property 3
            private int _age;
            public int age
            {
                get { return _age; }
                set
                {
                    _age = value;
                }
            }

            // Property 4
            private string _color;
            public string color
            {
                get { return _color; }
                set
                {
                    _color = value;
                }
            }


            // Constructor Declaration of Class
            public Dog(String name, String breed,
                          int age, String color)
            {
                this.name = name;
                this.breed = breed;
                this.age = age;
                this.color = color;
            }


            // Method 1
            public String toString()
            {
                return ("name :" + this.name
                        + "\nBreed:  " + this.breed
                        + "\nage:" + this.age + "\ncolor: " + this.color);
            }


        }

        static void Main(string[] args)
        {
            // Creating object
            Dog objdog1 = new Dog("candy", "golden retriever", 5, "Golden");
            Console.WriteLine(objdog1.toString());

           

        }
        
    }
}


