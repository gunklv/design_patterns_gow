using Adapter.Common;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            converter(new JsonAdapter());
        }

        private static string converter(IJsonConverter converter)
        {
            return converter.JsonConvert(new object());
        }
    }
}
