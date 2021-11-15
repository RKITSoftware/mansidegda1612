using System;

namespace Inheritance
{
    //Single inheritance  
    //base class 
    public class Animal    
    {
        public void Name()
        {
            Console.WriteLine( "I am Animal");
        }
    }
    //derived class  
    public class Dog : Animal   
    {
        //derived class method   
        public void breed()
        {
            Console.WriteLine("I am Husky");
        }
    }

    //Hierarchical inheritance
    //base class 
    class A     
    {
        public void msg()
        {
            Console.WriteLine("this is A class ");
        }
    }
    //derived class 1
    class B : A
    {
        public void info()
        {
            msg();//method of base class 
            Console.WriteLine("this is B class ");
        }
    }
    //derived class 2
    class C : A
    {
        public void getinfo()
        {
            msg();
            Console.WriteLine("this is c class ");
        }
    }

    //Multilevel inheritance
    //base class 
    public class Asia
    {
        public void continentname()
        {
            Console.WriteLine("this is the Asia class");
        }
    }
    //India inherit Asia
    public class India : Asia
    {
        public void countryname()
        {
            continentname();
            Console.WriteLine("this is the India Class");
        }
    }
    //Gujrat inherit India
    public class Gujrat : India
    {
        public void statename()
        {
            continentname();
            countryname();
            Console.WriteLine("this is the Gujrat Class");
        }
    }

    //Multiple inheritance 
    public interface Parent1 //ineterface  1    
    {
        void eyecolor(string color);
    }
    public interface Parent2  //Interface 2    
    {
        void skincolor(string color);
    }
    public class Child : Parent1, Parent2 //implementatin    
    {
        public void eyecolor(string color)
        {
            Console.WriteLine("Child eye color is" + color);
        }
        public void skincolor(string color)
        {
            Console.WriteLine("Child skin color is" + color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Single inheritance  
            //object of Dog(derived) class
            Dog objDog = new Dog();
            //method of base class
            objDog.Name();
            objDog.breed();

            //Hierarchical inheritance
            B objB = new B();
            objB.info();

            C objC = new C();
            objC.getinfo();

            //Multilevel inheritance
            Asia objAsia = new Asia();
            India objIndia = new India();
            Gujrat objGujrat = new Gujrat();

            objAsia.continentname();
            objIndia.countryname();
            objGujrat.statename();

            //Multiple inheritance 
            Child objChild = new Child();
            objChild.eyecolor("blue");
            objChild.eyecolor("brown");

        }
    }
}
