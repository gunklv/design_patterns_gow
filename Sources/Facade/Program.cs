using System;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            var customer = "Customer";
            var amount = 20000;

            var mortgage = new MortgageSystem();
            var result = mortgage.IsEligible(customer, amount);

            Console.WriteLine(result ? "Approved" : "Rejected");
        }
    }
}
