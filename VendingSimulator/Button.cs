﻿using System;
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
            return this.Name + " $" + this.Price + " " +  this.isLit  ;
        }
    }
}