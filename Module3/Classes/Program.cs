using System;

namespace Classes
{
    class Circle
    {
        public double radius;   // public radius of a circle
    }
    class Box
    {
        private double length;   // private Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }
    }

    class Line
    {
        private double length=0;   // Length of a line

        //default constructor
        public Line()
        {
            Console.WriteLine("Object created");
        }
        //Parameterized constructor
        public Line(double len)
        {
            Console.WriteLine("length = {0}", len);
            length = len;
        }

        //Destructor
        ~Line()
        {
            Console.WriteLine("Object deleted");
        }
        public double getLength()
        {
            return length;
        }
    }

    //Static Class 
    public static class Calculator
    {
        private static int result = 0;

        public static int Sum(int num1, int num2)
        {
            result = num1 + num2;
            return result;
        }

    }

    //Sealed Class
    sealed class triangle
    {
        public double Tbase;
        public double height;

    }

    class Vehicle
    {
        public virtual void show()
        {
            Console.WriteLine("no of wheels : 2");
        }
        public virtual void print()
        {
            Console.WriteLine("Name");
        }
    }

    // inheriting class
    class Car : Vehicle
    {

        // Sealed Display Function
        sealed override public void show()
        {
            Console.WriteLine("no of wheels : 4");
        }
        override public void print()
        {
            Console.WriteLine("Car");
        }
    }
    class Swift : Car
    {

        // can not override show 
        override public void print()
        {
            Console.WriteLine("Swift");
        }
    }

    //abstract Class
    public abstract class person
    {

        // abstract method 
        public abstract void PrintName();

    }
    public class student : person
    {
        public override void PrintName()
        {
            Console.WriteLine("Student");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle objCircle = new Circle();//Declare objCircle of type Circle

            //assign value to objeCircle radius 
            objCircle.radius = 5.0;

            Box objBox = new Box();   // Declare Box1 of type Box
            //print radius of circle
            Console.WriteLine("radius of circle : {0}", objCircle.radius);

            // objbox specification
            objBox.setLength(6.0);
            objBox.setBreadth(7.0);
            objBox.setHeight(5.0);

            // volume of objBox
            Console.WriteLine("Volume of Box : {0}", objBox.getVolume());

            //declare objLine1 and objLine2
            Line objLine1 = new Line();
            Line objLine2 = new Line(10.0);

            Console.WriteLine("Length of line 1 : {0}", objLine1.getLength());
            Console.WriteLine("Length of line 2: {0}", objLine2.getLength());

            //static class members  acsess
            Console.WriteLine("Sum of num1 and num2 :", Calculator.Sum(10,20));


            Vehicle objVehicle = new Vehicle();
            objVehicle.show();
            objVehicle.print();

            Car objCar = new Car();
            objCar.show();
            objCar.print();

            Swift objSwift = new Swift();
            objSwift.show();//print the show method of car class
            objSwift.print();

            student objStudent = new student();
            objStudent.PrintName();
        }
    }
}
