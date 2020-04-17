using Prototype.Sandwiches;

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            var input = "tuna";

            var tunaSandwichPrototype = new TunaSandwichPrototype();
            var salamiSandwichPrototype = new SalamiSandwichPrototype();


            SandwichPrototype sandwich;
            switch (input)
            {
                case "tuna":
                    sandwich = tunaSandwichPrototype.Clone();
                    break;
                default:
                    sandwich = salamiSandwichPrototype.Clone();
                    break;
            }

            //return sandwich;
        }
    }
}
