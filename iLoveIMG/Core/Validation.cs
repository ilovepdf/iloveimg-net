using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iLoveIMG.Model.Enums;

namespace iLoveIMG.Core
{
    /// <summary>
    ///     Validation
    /// </summary>
    public class Validation
    {
        /// <summary>
        ///     Rotation
        /// </summary>
        [JsonProperty("server_filename")]
        public String ServerFileName { get; set; }

        /// <summary>
        ///     Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ValidationStatus Status { get; set; }
    }
}
