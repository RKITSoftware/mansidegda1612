using System;
using System.IO;

namespace File_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 
            string path = "D:\\placemant\\RKIT training\\module 4\\File Operations\\sample.txt";
            string pathcopy = "D:\\placemant\\RKIT training\\module 4\\File Operations\\samplecopy.txt";
            string pathbackup = "D:\\placemant\\RKIT training\\module 4\\File Operations\\backup.txt";
            string pathdemo = "D:\\placemant\\RKIT training\\module 4\\File Operations\\demo.txt";

            var Myfile = File.Create(@path);
            //close file
            Myfile.Close();

            string myLines = "My Name is Mansi Degda ,I am from Rajkot.";

            //open and AppendAll text
            File.AppendAllText(@path, myLines);

            //Exists
            if (File.Exists(@path))
                Console.WriteLine("file exists");

            //copy
            File.Copy(@path, @pathcopy);

            //WriteAllText it override the existing text
            myLines = "hello From RKIT";
            File.WriteAllText(@path, myLines);

            //ReadAlltext
            string data = File.ReadAllText(@path);
            Console.WriteLine(data);

            //Replace
            File.Replace(@path, @pathcopy, @pathbackup);

            //Move
            File.Move(@pathbackup, @"D:\placemant\RKIT training\module 4\File Operations\bin\backup.txt");

            //Delete
            File.Delete(@"D:\placemant\RKIT training\module 4\File Operations\bin\backup.txt");

            //Encrypt
            File.Encrypt(@pathcopy);

            //Decrypt
            File.Decrypt(@pathcopy);

            //StreamWriter
            StreamWriter sw = File.CreateText(@pathdemo);
            for (int i = 1; i <= 10; i++)
            {
                sw.WriteLine(i);
            }
            //close StreamWriter
            sw.Close();

            //StreamReader 
            StreamReader sr = File.OpenText(@pathdemo);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

        }
    }
}
