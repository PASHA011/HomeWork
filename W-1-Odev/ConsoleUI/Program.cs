using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Audi();
            Console.WriteLine(car.Brand);
            
        }
    }
}
