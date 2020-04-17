using System;
using System.Collections;
using Visitor.Shop;
using Visitor.Shop.Items;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            var cart = new ShoppingCart();

            cart.Items.Add(new Banana());
            cart.Items.Add(new Sugar());

            var visitor = new Cashier();

            var finalPrice = 0.0;
            foreach(var e in cart.Items)
            {
                finalPrice += e.Accept(visitor);
            }

            Console.WriteLine($"Final price: {finalPrice}");

            Console.ReadLine();
        }
    }
}
