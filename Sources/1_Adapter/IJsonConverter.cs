using System;

namespace Adapter
{
    public interface IJsonConverter
    {
        string JsonConvert(Object o);
    }
}
