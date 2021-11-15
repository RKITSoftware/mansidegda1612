using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class Subscriber
    {
        //object of Publisher
        private Publisher publishers;
        public Subscriber(Publisher publisher)
        {
            this.publishers = publisher;
            //Add event
            publishers.ProdcutAddedInfo += publishers_ProdcutAddedInfo;
        }
        //logic of publishers_ProdcutAddedInfo event
        void publishers_ProdcutAddedInfo(object sender, EventArgs e)
        {
            if (sender == null)
            {
                Console.WriteLine("No New Product Added.");
                return;
            }
            Console.WriteLine("A New Prodct Added.");
        }
        public void UnSubscribeEvent()
        {
            //remove event
            publishers.ProdcutAddedInfo -= publishers_ProdcutAddedInfo;
        }
    }
}
