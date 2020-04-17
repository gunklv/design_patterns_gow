using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            var input = new Currency(77500);

            var atm = new ATM();

            atm.Dispenser.dispense(input);

            Console.ReadLine();
        }
    }
}
