namespace Singleton
{
    public class EventBus
    {
        private static EventBus _instance;
        private EventBus()
        {

        }

        public static EventBus Instance()
        {
            if (_instance == null)
            {
                _instance = new EventBus();
            }

            return _instance;
        }
    }
}
