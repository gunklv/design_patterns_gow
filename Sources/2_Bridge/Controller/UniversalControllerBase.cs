using Bridge.Device;

namespace Bridge.Controller
{
    public abstract class UniversalControllerBase
    {
        private readonly IDevice _device;
        protected int LifeTime { get; set; } = int.MaxValue;

        public UniversalControllerBase(IDevice device)
        {
            _device = device;
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }

        public void TurnOn()
        {
            LifeTime--;
            _device.TurnOn();
        }
    }
}
