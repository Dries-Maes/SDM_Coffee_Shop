﻿namespace SDM_Coffee_Shop
{
    internal class Tea : Beverage
    {
        public int Theine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        public Tea(int theine, bool hasMilk, bool hasSugar)
        {
            Theine = theine;
            HasMilk = hasMilk;
            HasSugar = hasSugar;
        }
    }
}