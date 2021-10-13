using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5]; //n is an array of 10 integers 
       
            // initialize elements  
            for (int i = 0; i < 5; i++)
            {
                array[i] = i + 10;
            }

            //   print array element value 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Element[{0}] = {1}", i, array[i]);
            }
           
        }
    }
}
