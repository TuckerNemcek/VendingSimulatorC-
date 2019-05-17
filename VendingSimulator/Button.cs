using System;
using System.Collections.Generic;
using System.Text;

namespace VendingSimulator
{
    class Button
    {
        public string Name;
        public double Price;
        public bool isLit;

        public string GetButtonStatus()
        {
            string status = "";
            if (isLit) status = "Is Available";
            else status = "is Not Available";
            return this.Name + " $" + this.Price + " " +  status  ;
        } 
    }
}
