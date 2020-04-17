namespace Decorator.Vehicles.Decorators
{
    public class Navigation : VehicleDecorator
    {
        public Navigation(Vehicle vehicle) : base(vehicle)
        {
        }

        public override void Details()
        {
            _vehicle.Details();
            System.Console.WriteLine("With Navigation");
        }
    }
}
