using System;

namespace NullReferenceException
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            //try block
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            //catch block
            catch(Exception e)
            {
                //NullReferenceException
                Console.WriteLine("Exception :" + e);
            }

            object obj = new Object();
            int i;
            //try block
            try
            {
                i = (int)obj;
            }
            //catch block
            catch (Exception e)
            {
                //InvalidCastException
                Console.WriteLine("Exception :" + e);
            }
        }
    }
}
