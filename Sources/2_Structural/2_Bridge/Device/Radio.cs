namespace Bridge.Device
{
    public class Radio : IDevice
    {
        public void TurnOff()
        {
            System.Console.WriteLine("Turn off Radio!");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turn on Radio!");
        }
    }
}
