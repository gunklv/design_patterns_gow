using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            var inputBrand = "Audi";

            IFactory factory;
            switch (inputBrand)
            {
                case "Audi":
                    factory = new AudiFactory();
                    break;
                default:
                    factory = new BMWFactory();
                    break;
            }

            var car = factory.CreateCar();
            var motorCycle = factory.CreateMotorCycle();
        }
    }
}
