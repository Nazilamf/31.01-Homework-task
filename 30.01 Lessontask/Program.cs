using System;

namespace _30._01_Lessontask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.FullName = "Leyla";
            std1.Age = 20;

            Console.WriteLine($"FullName:{std1.FullName} - Age:{std1.Age}");


            Vehicle vh = new Vehicle();
            vh.Drive(20);
            vh.Drive(30);


            Console.WriteLine(vh.Mileage);

            Car cr1 = new Car(50);
            

            cr1.AddFuel(20);
            cr1.AddFuel(30);
            cr1.AddFuel(10);

            Console.WriteLine(cr1.Currentfuel);
                
        }
    }
}
