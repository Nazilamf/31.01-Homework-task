using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Drink
    {
        private double _alcoholpercent;



        public double AlcoholPercent
        {
            set
            {
                if (value>0 && value<100)
                {
                    _alcoholpercent = value;
                }
            }
            get { return _alcoholpercent; }


        }
    }
}

