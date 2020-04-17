namespace Proxy
{
    public class RealImage : Image
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            loadFromDisk(fileName);
        }

        public void display()
        {
        }

        private void loadFromDisk(string fileName)
        {
            System.Console.WriteLine("Displaying " + _fileName);
        }
    }
}
