using AbstractFactory.Vehicles;

namespace AbstractFactory.Factories
{
    public class AudiFactory : IFactory
    {
        public Car CreateCar()
        {
            return new AudiCar();
        }

        public MotorCycle CreateMotorCycle()
        {
            return new AudiMotorCycle();
        }
    }
}
