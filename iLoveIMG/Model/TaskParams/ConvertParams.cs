using iLoveIMG.Model.Enums;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace iLoveIMG.Model.TaskParams
{
    public class ConvertParams : BaseParams
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public ConvertParams()
        {
            setDefaultValues();
        }

        /// <summary>
        ///     ConvertTo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("to")]
        public ConvertToValues To { get; set; }

        /// <summary>
        ///     ConvertTo
        /// </summary>
        [JsonProperty("gif_time")]
        public int GifTime { get; set; }

        /// <summary>
        ///     ConvertTo
        /// </summary>
        [JsonProperty("gif_loop")]
        public bool GifLoop { get; set; }

        private void setDefaultValues()
        {
            GifTime = 50;
            GifLoop = true;
        }
    }
}
