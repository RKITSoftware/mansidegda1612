using System;

namespace Enumerations
{
    //Define an Enum
    enum WeekDays
    {
        // Default Enum Values
        Monday,    //0
        Tuesday,   //1
        Wednesday, //3
        Thursday,  //4
        Friday,    //5
        Saturday,  //6
        Sunday     //7
    }

    enum Months
    {
        //Assign Values to Enum Members
        Jan,    // 0
        Feb,     // 1
        Jul = 6,   // 6
        Aug = 6,  // 6
        Oct    // 7
    }

    //byte enum
    enum Age : byte
    {
        Mansi = 20,
        Drasti = 16,
        Geeta = 40,
    }

    class Perimeter
    {

        // declaring enum
        public enum shapes
        {
            circle,
            square
        }

        public void peri(int val, shapes s1)
        {

            // checking for shape to be circle
            if (s1 == 0)
            {

                // Output the circumference
                Console.WriteLine("Circumference of the circle is " +
                                                      2 * 3.14 * val);
            }

            else
            {

                // else output the perimeter of the square
                Console.WriteLine("Perimeter of the square is " +
                                                         4 * val);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Access enum
            Console.WriteLine("--WeekDays--");
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine(WeekDays.Saturday);
            Console.WriteLine(WeekDays.Sunday);

            Console.WriteLine("--Months--");
            //Conversion enum to int
            Console.WriteLine((int)Months.Jan);
            Console.WriteLine((int)Months.Feb);
            Console.WriteLine((int)Months.Jul);
            Console.WriteLine((int)Months.Aug);
            Console.WriteLine((int)Months.Oct);

            //Access enum
            Console.WriteLine("--Age--");
            Console.WriteLine(Age.Mansi + "'s age is " + (int)Age.Mansi);
            Console.WriteLine(Age.Drasti + "'s age is " + (int)Age.Drasti);
            Console.WriteLine(Age.Geeta + "'s age is " + (int)Age.Geeta);

            //pass enum member as parameter 
            Perimeter objPerimeter = new Perimeter();
            objPerimeter.peri(3, Perimeter.shapes.circle);
            objPerimeter.peri(4, Perimeter.shapes.square);

        }
    }
}
