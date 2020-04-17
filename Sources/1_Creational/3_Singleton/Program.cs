namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventBus = EventBus.Instance();

            //eventBus.Publish(...);
        }
    }
}
