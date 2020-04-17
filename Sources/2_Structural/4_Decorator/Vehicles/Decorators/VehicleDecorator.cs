namespace Decorator.Vehicles.Decorators
{
    public class VehicleDecorator : Vehicle
    {
        protected readonly Vehicle _vehicle;

        public VehicleDecorator(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public override void Details()
        {
            _vehicle.Details();
        }
    }
}
