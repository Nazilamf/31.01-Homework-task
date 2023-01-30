using System;
using Lesson1;
using Lesson2;

namespace _31._01_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lesson2.Drink drink1 = new Lesson2.Drink();
            drink1.AlcoholPercent =90;
            Console.WriteLine(drink1.AlcoholPercent);

            Lesson1.Product product = new Lesson1.Product();
            product.Name = "Sirab";
            product.Price = 2;
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
        }
    }
}
