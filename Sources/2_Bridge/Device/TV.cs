namespace Bridge.Device
{
    public class TV : IDevice
    {
        public void TurnOff()
        {
            System.Console.WriteLine("Turn off TV!");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turn on TV!");
        }
    }
}
