﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public abstract class Beverage : IBeverage
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description { get; set; }

        private static int PID = 1;
        public int ID { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        protected Beverage()
        {
            ID = PID;
            PID++;
        }

        public override string ToString()
        {
            string result = $"{Price.ToString()}, {Description}, {ID}, {Image}, {Name}";
            return result;
        }

        public virtual List<Control> GetControls()
        {
            return null;
        }

        public virtual void SetControls(object sender, EventArgs e)
        {
        }
    }
}