using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.ZhuNaAPI.Utility
{
    public interface ISerializer
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string json);
    }
}
