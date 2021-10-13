using System;

namespace OperatorsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20, num2=4;
            //Arithmetic Operators

            //addition
            Console.WriteLine("num1+num2=" + (num1 + num2));
            //subtraction
            Console.WriteLine("num1-num2=" + (num1 - num2));
            //multiplication
            Console.WriteLine("num1*num2=" + (num1 * num2));
            //division
            Console.WriteLine("num1/num2=" + (num1 / num2));
            //modulus 
            Console.WriteLine("num1%num2=" + (num1 % num2));
            //Increment 
            num1++;
            Console.WriteLine("num1++ =" + num1);
            //Decrement 
            num2--;
            Console.WriteLine("num2-- =" + num2);


            //Relational Operators

            num1 = 5; num2 = 10;
            //equal 
            if (num1==num2)
                Console.WriteLine(num1+" is equal"+ num2);
            //not equal 
            if (num1 != num2)
                Console.WriteLine(num1 + " is not equal" + num2);
            //greater than 
            if (num1 > num2)
                Console.WriteLine(num1 + " is greater than" + num2);
            //less than
            if (num1 < num2)
                Console.WriteLine(num1 + " is less than" + num2);
            //greater than or equal
            if (num1 >= num2)
                Console.WriteLine(num1 + " is greater than or equal " + num2);
            //less than or equal
            if (num1 <= num2)
                Console.WriteLine(num1 + " is less than or equal " + num2);

            //	Logical Operators

            num1 = 5; num2 = 10;
            //Logical AND  
            if (num1 ==5 && num2==10 )
                Console.WriteLine("Both condition becomes true");
            //not equal 
            if (num1 ==5 || num2==5)
                Console.WriteLine("Any one condition becomes true");
            //greater than 
            if (!(num1 ==10))
                Console.WriteLine("condition becomes false");


            //Bitwise Operators

            num1 = 4; num2 = 7;
            //Binary AND 
            Console.WriteLine("num1&num2=" + (num1 & num2));
            //Binary OR
            Console.WriteLine("num1|num2=" + (num1 | num2));
            //Binary XOR
            Console.WriteLine("num1=" + (num1 ^ num2));
            //Binary Ones Complement 
            Console.WriteLine("~num1=" + (~num1));
            //Binary Left Shift 
            Console.WriteLine("num1<<1=" + (num1 << 1));
            //Binary Right Shift 
            Console.WriteLine("num1>>2=" + (num1 >> 2));

            //Assignment Operators

            int num3;
            //Simple assignment 
            num3 = 5; //num3=5
            //Add AND assignment 
            num3 += 5; //num3=10
            //Subtract AND assignment
            num3 -= 5;//num3=5
            //Multiply AND assignment
            num3 *= 5;//num3=25
            //Divide AND assignment 
            num3 /= 5; //num3=5
            //Modulus AND assignment
            num3 %= 2;//num3=1
            //Left shift AND assignment
            num3 <<= 1;//num3=2
            //Right shift AND assignment
            num3 >>= 1;//num3=1
            //Bitwise AND assignment
            num3 &= 3;//num3=1
            //bitwise exclusive OR and assignment 
            num3 ^= 3;//num3=7
            //bitwise inclusive OR and assignment
            num3 |= 3;//num3=7


            //Ternary Operator 
            num1 = 10; num2 = 5;
            var result = num1 > num2 ? "num1 is greater" : "num2 is greater";
            Console.WriteLine(result);
        }
    }
}
