using System;

namespace DateTimeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create DateTime object
            DateTime dt = new DateTime(2021, 10, 13 ,12, 56,20 );
            Console.WriteLine(dt.ToString());

            //Properties of DateTime 

            //DayOfWeek
            Console.WriteLine(dt.DayOfWeek);

            //DayOfYear 
            Console.WriteLine(dt.DayOfYear);

            //TimeOfDay
            Console.WriteLine(dt.TimeOfDay);

            //Today  
            Console.WriteLine(DateTime.Today);

            //Now    
            Console.WriteLine(DateTime.Now);


            //DateTime Class methods

            //DaysInMonth
            Console.WriteLine(DateTime.DaysInMonth(2021,10));

            //IsLeapYear
            if(DateTime.IsLeapYear(2021))
                Console.WriteLine("2021 is leap year");
            else
                Console.WriteLine("2021 is not leap year");

            //Equals
            DateTime dt1 = new DateTime(2020, 12, 16);
            DateTime dt2 = new DateTime(2021, 12, 16);

            if(dt1.Equals(dt2))
                Console.WriteLine("Dates are equal");
            else
                Console.WriteLine("Dates are not equal");

            //Compare

            if (DateTime.Compare(dt1,dt2)>0)
                Console.WriteLine("date 1 is grater ");
            else if (DateTime.Compare(dt1, dt2) < 0)
                Console.WriteLine("date 2 is grater ");
            else
                Console.WriteLine("Dates are equal");
        }
    }
}
