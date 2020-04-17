namespace Decorator.Vehicles.Decorators
{
    public class LeatherSeat : VehicleDecorator
    {
        public LeatherSeat(Vehicle vehicle) : base(vehicle)
        {
        }

        public override void Details()
        {
            _vehicle.Details();
            System.Console.WriteLine("With Leather Seat");
        }
    }
}
