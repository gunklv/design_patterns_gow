using System;

namespace Iterator
{
    class Program
    {
        static void Main()
        {
            var storage = new Storage<int>();
            storage._list.Add(1);
            storage._list.Add(2);
            storage._list.Add(3);

            foreach (var e in storage)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
