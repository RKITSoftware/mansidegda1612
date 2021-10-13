using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // foreach
            int[] array = new int[] { 1, 2, 3, 4, 5};
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }

            // while
            int num1 = 5;
            while (num1 < 10)
            {
                Console.WriteLine(num1);
                num1++;
            }

            // do..while
            num1 = 5;
            do
            {
                Console.WriteLine(num1);
                num1++;
            }
            while (num1 < 5);

            //break
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }

            //continue
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
