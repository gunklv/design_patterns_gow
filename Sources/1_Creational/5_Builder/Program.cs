namespace Builder
{
    class Program
    {
        static void Main()
        {
            var factory = new VehicleFactory();
            factory.CreateCar();
        }
    }
}
