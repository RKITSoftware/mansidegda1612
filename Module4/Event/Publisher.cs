using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Event
{
    //delegate
    public delegate void EventHandler(object sender, EventArgs e);
    public class Publisher : ArrayList
    {
        //event
        public event EventHandler ProdcutAddedInfo;
        protected virtual void OnChanged(EventArgs e)
        {
            if (ProdcutAddedInfo != null) ProdcutAddedInfo(this, e);
        }
        //Add method
        public override int Add(Object Item)
        {
            int added = base.Add(Item);
            OnChanged(EventArgs.Empty);
            return added;
        }
        
    }
}
