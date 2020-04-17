using Decorator.Vehicles;
using Decorator.Vehicles.Decorators;
using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            var car = new Car();

            var extended1 = new Navigation(car);
            var extended2 = new LeatherSeat(extended1);

            extended2.Details();

            Console.ReadLine();
        }
    }
}
