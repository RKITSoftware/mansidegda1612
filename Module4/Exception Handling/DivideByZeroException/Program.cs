using System;

namespace Dividing_by_zero
{
    class Program
    {
        class DivNumbers
        {
            int result;
            //constructor
            public DivNumbers()
            {
                result = 0;
            }
            public void division(int num1, int num2)
            {
                //try block
                try
                {
                    result = num1 / num2;
                }
                //catch block
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception : {0}", e);
                }
                //finally block
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }
        }
        static void Main(string[] args)
        {
            DivNumbers objDivision = new DivNumbers();
            objDivision.division(10, 0);

        }
    }
}
