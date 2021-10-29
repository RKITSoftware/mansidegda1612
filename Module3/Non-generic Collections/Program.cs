using System;
using System.Collections;

namespace Non_generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList

            ArrayList arrlist = new ArrayList();

            //adding elements using object initializer syntax
            var arrlist1 = new ArrayList()
                {
                    1, "Mansi", " ", true, 9.5, null
                };

            //add
            arrlist1.Add("degda");

            var arrlist2 = new ArrayList()
                    {
                        1, "RKIT", " "
                    };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");

            arrlist.AddRange(arrlist2); //adding arraylist in arraylist 
            arrlist.AddRange(arr); //adding array in arraylist 
            arrlist.AddRange(myQ); //adding Queue in arraylist 

            //InsertRange
            arrlist1.InsertRange(2, arrlist2);

            //remove
            arrlist.Remove(null); //Removes first occurance of null
            arrlist.RemoveAt(4); //Removes element at index 4
            arrlist.RemoveRange(0, 2);//Removes two elements starting from 1st item 

            //Contain
            Console.WriteLine(arrlist.Contains("Mansi")); // true

            //access element
            foreach (var item in arrlist)
                Console.WriteLine(item);

            //SortedList

            SortedList numbers = new SortedList()
            {
                { 3, "Three"},
                { 5, true},
                { 1, "One"}
            };

            //add element
            numbers.Add(6, "Six");
            numbers.Add(2, null);

            //updates value
            numbers[2] = "TWO";

            //containkey
            if (numbers.ContainsKey(4))
            {
                numbers[4] = "four";
            }

            //remove
            numbers.Remove(0);//removes key pair

            //removeAt
            numbers.RemoveAt(2);//removes key-value pair from index 0 

            //access element
            foreach (DictionaryEntry kvp in numbers)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            //Stack

            //add element in stack
            int[] array = new int[] { 1, 2, 3, 4 };
            Stack myStack = new Stack(array);

            //push
            myStack.Push("hello");

            //pop remove last element from stack and return it
            Console.WriteLine(myStack.Pop());

            //peak return last element without removing it
            Console.WriteLine(myStack.Peek());

            //contain
            Console.WriteLine(myStack.Contains("hello"));

            // access element
            foreach (var item in myStack)
                Console.Write(item + ",");
            Console.Write("");

            //Queue

            Queue strQ = new Queue();
            strQ.Enqueue("R");
            strQ.Enqueue("K");
            strQ.Enqueue("I");
            strQ.Enqueue("T");
            strQ.Enqueue(1);

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


            //Hashtable

            //creating a Hashtable using collection-initializer syntax
            Hashtable numberNames = new Hashtable()
            {
                {1,"one" },
                {2,"two" },
                {3,"three" }
            };

            //Add element in key value format

            numberNames.Add(4, "four");

            //update
            numberNames[1] = "one,ONE";

            //remove
            numberNames.Remove(4); // removes UK 
                                   //cities.Remove(5); //throws run-time exception: KeyNotFoundException


            //ContainsKey
            if (numberNames.ContainsKey(5))
            { // check key before removing it
                numberNames.Remove(5);
            }

            //Access element
            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //BitArray

            // Creating a BitArray
            BitArray myBitArr1 = new BitArray(5);

            myBitArr1[0] = true;
            myBitArr1[1] = true;
            myBitArr1[2] = false;
            myBitArr1[3] = true;
            myBitArr1[4] = false;

            BitArray myBitArr2 = new BitArray(5);

            myBitArr2[0] = true;
            myBitArr2[1] = true;
            myBitArr2[2] = false;
            myBitArr2[3] = true;
            myBitArr2[4] = false;

            //set
            myBitArr1.Set(0, false);

            //get
            Console.WriteLine(myBitArr1.Get(1));

            //and(bitwise and)
            myBitArr1.And(myBitArr2);
            Console.WriteLine("AND");
            foreach (bool item in myBitArr1)
                Console.WriteLine(item);

            //or(bitwise or)
            myBitArr1.Or(myBitArr2);
            Console.WriteLine("OR");
            foreach (bool item in myBitArr1)
                Console.WriteLine(item);

            //xor(bitwise xor)
            myBitArr1.Xor(myBitArr2);
            Console.WriteLine("XOR");
            foreach (bool item in myBitArr1)
                Console.WriteLine(item);

            //NOT
            myBitArr1.Not();
            Console.WriteLine("NOT");
            foreach (bool item in myBitArr1)
                Console.WriteLine(item);

            //RightShift
            myBitArr1.RightShift(2);
            Console.WriteLine("RightShift 2");
            foreach (bool item in myBitArr1)
                Console.WriteLine(item);

            //LeftShift
            myBitArr1.LeftShift(2);
            Console.WriteLine("LeftShift 2");
            foreach (bool item in myBitArr1)
                Console.WriteLine(item);

            //SetAll
            myBitArr1.SetAll(true);
            Console.WriteLine("set all true");
            foreach (bool item in myBitArr1)
                Console.WriteLine(item);

        }
    }
}
