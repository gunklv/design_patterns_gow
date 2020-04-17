namespace Proxy
{
    class Program
    {
        static void Main()
        {
            Image image = new ProxyImage("fileName.png");
            image.display();
        }
    }
}
