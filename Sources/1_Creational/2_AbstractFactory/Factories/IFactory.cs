using AbstractFactory.Vehicles;

namespace AbstractFactory.Factories
{
    public interface IFactory
    {
        Car CreateCar();

        MotorCycle CreateMotorCycle();
    }
}
