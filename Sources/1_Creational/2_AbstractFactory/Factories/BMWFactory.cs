using AbstractFactory.Vehicles;

namespace AbstractFactory.Factories
{
    class BMWFactory : IFactory
    {
        public Car CreateCar()
        {
            return new BMWCar();
        }

        public MotorCycle CreateMotorCycle()
        {
            return new BMWMotorCycle();
        }
    }
}
