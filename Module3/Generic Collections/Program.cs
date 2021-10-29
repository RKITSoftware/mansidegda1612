using System;
using System.Collections.Generic;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List 

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(9);

            var cities = new List<string>();
            cities.Add("Rajkot");
            cities.Add("Ahemdabad");
            cities.Add("Mumbai");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "Rajkot",
                        "Ahemdabad",
                        "Mumbai",
                    };

            //insert 
            primeNumbers.Insert(1, 3);//insert 3 at index 1

            //remove 
            cities.Remove("Rajkot");//reomve first rajkot

            bigCities.RemoveAt(2); //remove element at index 2
            //contain
            Console.WriteLine(cities.Contains("mumbai"));

            // Accsess elment of list
            for (int i = 0; i < primeNumbers.Count; i++)
                Console.WriteLine(primeNumbers[i]);

            for (int i = 0; i < cities.Count; i++)
                Console.WriteLine(cities[i]);

            for (int i = 0; i < bigCities.Count; i++)
                Console.WriteLine(bigCities[i]);

            //Dictionary

            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var City = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            //update dict
            City["UK"] = "Liverpool, Bristol"; // update value of UK key
            City["USA"] = "Los Angeles, Boston"; // update value of USA key

            //remove elemants
            City.Remove("UK");
            if (City.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
                cities.Remove("France");
            }
            //access elements
            foreach (var kvp in City)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //SortedList

            //using collection-initializer syntax
           
            SortedList<int, string> numbers = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };
            //add element
            numbers.Add(6, "Six");
            numbers.Add(2, "Two");

            //updates value
            numbers[2] = "TWO";

            //containkey
            if (numbers.ContainsKey(4))
            {
                numbers[4] = "four";
            }

            //TryGetValue
            string result;
            if (numbers.TryGetValue(4, out result))
                Console.WriteLine("Key: {0}, Value: {1}", 4, result);

            //remove
            numbers.Remove(0);//removes key pair
            numbers.Remove(10);//removes key pair, no error if not exists

            //removeAt
            numbers.RemoveAt(2);//removes key-value pair from index 0 
                                //numbers.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException

            //access element
            foreach (var kvp in numbers)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            //Queue

            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            //count
            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            //Dequeue remove first element from queue and return it
            Console.WriteLine(strQ.Dequeue());

            //peak return first element without removing it
            Console.WriteLine(strQ.Peek());

            //contain
            Console.WriteLine(strQ.Contains("e"));

            //access element
            foreach (var id in strQ)
                Console.Write(id);
            Console.WriteLine("");

            //stack

            //add element in stack
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack = new Stack<int>(arr);

            //push
            myStack.Push(5);

            //pop remove last element from stack and return it
            Console.WriteLine(myStack.Pop());

            //peak return last element without removing it
            Console.WriteLine(myStack.Peek());

            //contain
            Console.WriteLine(myStack.Contains(5));

            // access element
            foreach (var item in myStack)
                Console.Write(item + ",");
            Console.Write("");

            //hashset
           
            HashSet<int> myhash = new HashSet<int>() {1,
                               1,2,3,5};
            HashSet<int> myhash1 = new HashSet<int>() {1,
                               1,2,3,5,6};
            HashSet<int> myhash2 = new HashSet<int>() {5,6,
                               6,7,8};

            //add
            myhash.Add(3);

            //remove
            myhash.Remove(1);

            //UnionWith
            myhash1.UnionWith(myhash2);
            Console.WriteLine("Union");
            foreach (var valu in myhash1)
            {
                Console.WriteLine(valu);
            }

            //IntersectWith
            myhash1.IntersectWith(myhash2);
            Console.WriteLine("Intersection");
            foreach (var valu in myhash1)
            {
                Console.WriteLine(valu);
            }

            //ExceptWith
            myhash1.IntersectWith(myhash2);

            Console.WriteLine("ExceptWith");
            foreach (var valu in myhash1)
            {
                Console.WriteLine(valu);
            }

            // access elements
            Console.WriteLine("acsess hash");
            foreach (var valu in myhash)
            {
                Console.WriteLine(valu);
            }

        }
    }
}
