using Command.Commands;
using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            var kitchen = new Kitchen();

            var cook1 = new Cook1();
            var cook2 = new Cook2();

            kitchen.AddRequest(new BakeSteakCommand(cook1));
            kitchen.AddRequest(new CreateHamburgerCommand(cook2));

            kitchen.Cook();

            Console.ReadLine();
        }
    }
}
