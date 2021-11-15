using System;

namespace User_Defined_Exceptions
{
    class Program
    {
        //User-Defined Exception derived from the Exception class
        public class UnderAgeException : Exception
        {
            public UnderAgeException(string message) : base(message)
            {
            }
        }
        public class Age
        {
            int age = 0;

            public void testAge(int age)
            {
                this.age = age;
                if (age <= 18)
                {
                    //throw Exception
                    throw (new UnderAgeException("You are under age"));
                }
                else
                {
                    Console.WriteLine("Age: {0}", age);
                }
            }
            static void Main(string[] args)
            {
                Age objAge = new Age();
                //try block
                try
                {
                    objAge.testAge(15);
                }
                //catch block
                catch(UnderAgeException e)
                {
                    Console.WriteLine("UnderAgeException : {0}", e.Message);
                }
            }
        }
    }
}
