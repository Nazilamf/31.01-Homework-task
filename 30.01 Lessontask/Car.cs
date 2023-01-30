using System;
using System.Collections.Generic;
using System.Text;

namespace _30._01_Lessontask
{
    internal class Car:Vehicle
    {
        public double _fuelcapacity;

        public Car(double fuelcapacity)
        {
            this._fuelcapacity = fuelcapacity;
        }
        private double _currentfuel;
        public double Fuelforkm;


        public double Fuelcapacity
        {
            set 
            {
                if (value>0 && Currentfuel<=value) 
                    _fuelcapacity = value;    

            }
            get => _fuelcapacity; 
        } 

        public double Currentfuel => _currentfuel;
       



        public void AddFuel(int fuel)
        {
            if (_currentfuel+fuel<=_fuelcapacity)
            {
                _currentfuel+= fuel;
            }
           
        }


        public override void Drive(double km)
        {

            double neededfuel = km*Fuelforkm;
            if(_currentfuel>=neededfuel) 
            {
                _currentfuel -= neededfuel;
            }
            base.Drive(km); 
        }


    }
}
