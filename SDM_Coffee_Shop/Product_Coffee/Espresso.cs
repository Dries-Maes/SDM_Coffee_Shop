﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SDM_Coffee_Shop
{ 
    internal class Espresso : Coffee
    {
        public Espresso()
        {
            Name = "Espresso";
            Price = 2.99;
            Image = "espresso";
            Description = "Espresso is a coffee-brewing method of Italian origin, in which a small amount of nearly boiling water is forced under 9–10 bars of atmospheric pressure through finely-ground coffee beans. Espresso coffee can be made with a wide variety of coffee beans and roast degrees.";
        }
    }
}