using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.Json
{
    public static class JsonHelper
    {
        public static string Serialize(object data) 
        {
            return JsonConvert.SerializeObject(data);
        }

        public static T Deserialize<T>(string data) 
        {
            var objectToReturn = JsonConvert.DeserializeObject(data);
            return (T)objectToReturn;
        }

    }
}
