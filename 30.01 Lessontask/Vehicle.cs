using System;
using System.Collections.Generic;
using System.Text;

namespace _30._01_Lessontask
{
    internal class Vehicle
    {
        protected double _mileage;

        double km;
        public double Mileage => _mileage;

        public virtual void Drive(double km)
        {
            _mileage +=km;
        }

    }
}
