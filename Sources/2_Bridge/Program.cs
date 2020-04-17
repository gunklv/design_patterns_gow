using Bridge.Controller;
using Bridge.Device;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();

            var controller = new UniversalController(tv);

            controller.TurnOn();
            controller.TurnOff();
        }
    }
}
