using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public class Product
    {
        private string _name;
        private double _price;



        public string Name
        {
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value.Length >2 && value.Length<20)
                        _name = value;

                }
            }
            get { return _name; }
        }



        public double Price
        {
            set
            {
                if (value>0)
                {
                    _price = value;
                }
            }
            get { return _price; }


        }
    }
}
