using System;

namespace Methods
{
    class Program
    {
        //value type Parameters
        public int findMax(int num1, int num2)
        {
            //local variable 
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        //Reference type Parameters
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; 
            x = y;    
            y = temp;
        }

        //num3 is Optional Parameter
        public void display(int num1,int num2,int num3=30)
        {
            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);
        }

        static void Main(string[] args)
        {
            //local variable 
            int num1 = 10;
            int num2 = 20;
            int result;
            Program obj1 = new Program();

            //calling method
            result = obj1.findMax(num1, num2);//Passing Parameters by Value
            Console.WriteLine("Max value is : {0}", result);


            obj1.swap(ref num1, ref num2);//Passing Parameters by Reference
            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);

            obj1.display(num1, num2);//num3 is Optional Parameter
        }
    }
}
