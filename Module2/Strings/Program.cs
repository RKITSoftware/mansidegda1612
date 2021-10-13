using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // from string literal and string concatenation
            string fname, lname;
            fname = "Mansi";
            lname = "Degda";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "RKIT" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor 
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //methods returning string 
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = DateTime.Now;
            string chat = String.Format("Message sent at " + waiting);
            Console.WriteLine("Message: {0}", chat);

            //String Property 

            //Chars
            Console.WriteLine("Char at position 2: {0}", fname[2]);

            //Length
            Console.WriteLine("length of fname : {0}", fname.Length);


            //Methods of String class

            //Compare
            if(String.Compare(fname,lname)==0)
                Console.WriteLine(fname+" and "+lname+ " are Equal.");
            else
                Console.WriteLine(fname + " and " + lname + " are not Equal.");

            //Concat
            String fullName = String.Concat(fname, " ", lname);
            Console.WriteLine(fullName);

            //Contains
            if (fullName.Contains(fname))
                Console.WriteLine(fname + " is in " + fullName);
            else
                Console.WriteLine(fname + " is not in " + fullName);

            //Equals
            if (String.Equals(fname, lname))
                Console.WriteLine(fname + " and " + lname + " are Equal.");
            else
                Console.WriteLine(fname + " and " + lname + " are not Equal.");

            //IndexOf
            Console.WriteLine("Index of n in " + fname + " is " + fname.IndexOf('n'));

            //Insert
            fullName = fullName.Insert(6 , "Hiteshbhai ");
            Console.WriteLine(fullName);

            //Remove
            Console.WriteLine(fullName.Remove(6,11));

            //Replace
            Console.WriteLine(fullName.Replace("Mansi","MANSI"));


            //split 
            String[] strArray= fullName.Split(" ");
            foreach (String item in strArray)
                Console.WriteLine(item);

            //Substring
            String subStr = fullName.Substring(0,16);
            Console.WriteLine(subStr);

            //Trim
            fname = "       Mansi      ";
            Console.WriteLine(fname.Trim());

        }
    }
}
