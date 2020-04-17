using Bridge.Device;

namespace Bridge.Controller
{
    public class UniversalController : UniversalControllerBase
    {
        public UniversalController(IDevice device) : base(device)
        {
        }
    }
}
