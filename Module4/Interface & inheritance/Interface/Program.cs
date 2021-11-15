using System;

namespace Interface
{
    //interface
    public interface myInterface1
    {
        // interface members
        void getdata(string name,int age);
        void printdata();
    }

    public interface myInterface2
    {
        // interface members
        void getCompny(string company);
        void printCompny();
    }

    //class implement interface
    public class Student : myInterface1
    {
        string name;
        int age;

        //implementation of interface members
        //public getdata method of interface
        public void getdata(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //public printdata method of interface
        public void printdata()
        {
            Console.WriteLine("Name:" + this.name);
            Console.WriteLine("Age:" + this.age);
        }
    }
    //Class Employee implement two interfaces 
    public class Employee : myInterface1, myInterface2
    {
        string name;
        int age;
        string company;

        //implementation of myInterface1 members

       
        public void getdata(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printdata()
        {
            Console.WriteLine("Name:" + this.name);
            Console.WriteLine("Age:" + this.age);
            Console.WriteLine("Company:" + this.company);
        }

        //implementation of myInterface2 members
        public void getCompny(string company)
        {
            this.company = company;
        }
        //Explicit implementation
        void myInterface2.printCompny()
        {
            Console.WriteLine("Company:" + this.company);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //object of class student
            Student objStudent = new Student();
            Console.WriteLine("Student");
            objStudent.getdata("Mansi",20);
            objStudent.printdata();

            //object of class Employee
            Employee objEmployee = new Employee();
            Console.WriteLine("Employee");
            objEmployee.getdata("Mansi",20);
            objEmployee.getCompny("RKIT");
            objEmployee.printdata();
            //error
            //objEmployee.printCompny();
        }
    }
}

