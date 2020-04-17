using Builder.Cars;

namespace Builder.Builders
{
    public class CarBuilder : VehicleBuilder
    {
        private Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public override void BuildBody()
        {
            car.Body = "Car Body";
        }

        public override void BuildEngine()
        {
            car.Engine = "Car Engine";
        }

        public override void BuildWheel()
        {
            car.Wheel = "Car Wheel";
        }

        public override Vehicle BuildVehicle()
        {
            var result = car;
            car = new Car();
            return result;
        }
    }
}
