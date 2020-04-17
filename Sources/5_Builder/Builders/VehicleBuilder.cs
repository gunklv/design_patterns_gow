using Builder.Cars;

namespace Builder.Builders
{
    public abstract class VehicleBuilder
    {
        public abstract void BuildEngine();

        public abstract void BuildBody();

        public abstract void BuildWheel();

        public abstract Vehicle BuildVehicle();
    }
}
