using Builder.Cars;

namespace Builder.Builders
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        private MotorCycle motorCycle;

        public MotorCycleBuilder()
        {
            motorCycle = new MotorCycle();
        }

        public override void BuildBody()
        {
            motorCycle.Body = "Motor Body";
        }

        public override void BuildEngine()
        {
            motorCycle.Engine = "Motor Engine";
        }

        public override void BuildWheel()
        {
            motorCycle.Wheel = "Motor Wheel";
        }

        public override Vehicle BuildVehicle()
        {
            var result = motorCycle;
            motorCycle = new MotorCycle();
            return result;
        }
    }
}
