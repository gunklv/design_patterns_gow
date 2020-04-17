namespace Adapter.Common
{
    public class JsonAdapter : IJsonConverter
    {
        private readonly _3rdPartyJsonConverter jsonConverter = new _3rdPartyJsonConverter();
        public string JsonConvert(object o)
        {
            return jsonConverter.Convert(o);
        }
    }
}
