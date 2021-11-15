using System;
using System.Collections.Generic;

namespace IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            //try block
            try
            {
                //array
                int[] arr = new int[5] { 1,2,3,4,5 };
                int i, j;
                // error
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("Element[{0}] = {1}", i, arr[i]);
                }
                
            }
            //catch block
            catch (Exception e)
            {
                //IndexOutOfRangeException
                Console.WriteLine("Exception :{0}",e);
            }


            //try block
            try
            {
                //list
               List<int> list = new List<int> { 1, 2, 3, 4, 5 };
                int i, j;
                // error
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("Element[{0}] = {1}", i, list[i]);
                }

            }
            //catch block
            catch (Exception e)
            {
                //ArgumentOutOfRangeException
                Console.WriteLine("Exception :{0}", e);
            }
        }
    }
}
