using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimensional array
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

            //two dimensional array
            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };
            // print 2d array element
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++) 
                { 
                    Console.WriteLine("Element[{0},{1}] = {2}", i,j, arr2d[i,j]);
                }
            }


            //Jagged Array 

            int[][] jArray = new int[2][]{
                new int[3]{1, 2, 3},

                new int[4]{4, 5, 6, 7}
            };

            // print Jagged array element
            for (int i = 0; i < jArray.Length; i++)
            {
                for (int j = 0; j < (jArray[i]).Length; j++)
                    Console.WriteLine(jArray[i][j]);
            }

        }
    }
}
