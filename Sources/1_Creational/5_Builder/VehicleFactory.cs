using Builder.Builders;
using Builder.Cars;

namespace Builder
{
    public class VehicleFactory
    {
        private readonly CarBuilder carBuilder = new CarBuilder();
        private readonly MotorCycleBuilder motorCycleBuilder = new MotorCycleBuilder();

        public Vehicle CreateCar()
        {
            return carBuilder.BuildVehicle();
        }


        public Vehicle CreateMotorCycle()
        {
            return motorCycleBuilder.BuildVehicle();
        }
    }
}
