using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iLoveIMG.Model.Enums;

namespace iLoveIMG.Model.TaskParams
{
    /// <summary>
    ///     Compress Params
    /// </summary>
    public class CompressParams : BaseParams
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public CompressParams()
        {
            setDefaultValues();
        }

        /// <summary>
        ///     Compression Level
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("compression_level")]
        public CompressionLevels CompressionLevel { get; set; }

        private void setDefaultValues()
        {
            CompressionLevel = CompressionLevels.Recommended;
        }
    }
}
