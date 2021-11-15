using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;


namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            //object of Publisher
            Publisher publisher = new Publisher();
            //object of Subscriber
            Subscriber subscriber = new Subscriber(publisher);
            // add new item in array
            publisher.Add(new 
            {
                Name = "Mansi",
            });
            publisher.Add(new 
            {
                Name = "Degda",
            });
            publisher.Add(new 
            {
                Name = "RKIT",
            });
            subscriber.UnSubscribeEvent();
        }
    }
}
