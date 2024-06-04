using iLoveIMG.Core;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Helpers
{
    public static class InitialValueHelper
    {
        public static IEnumerable<KeyValuePair<string, string>> GetInitialValues(object element, string keyPrefix)
        {
            // Serializing and deserializing to get properties from derived class, since those properties only available in runtime.
            var json = JsonConvert.SerializeObject(element, new KeyValuePairConverter());
            var paramArray = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            return paramArray.Keys.Select(
                paramKey =>
                {
                    var key = string.IsNullOrEmpty(keyPrefix) ?
                        StringHelpers.Invariant($"{paramKey}") :
                        StringHelpers.Invariant($"{keyPrefix}[{paramKey}]");

                    return new KeyValuePair<string, string>(key, paramArray[paramKey]);
                });
        }
    }
}
