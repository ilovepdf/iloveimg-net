using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Core
{
    /// <summary>
    ///     Upload Task Response
    /// </summary>
    public class UploadTaskResponse
    {
        /// <summary>
        ///     Server file name
        /// </summary>
        [JsonProperty("server_filename")]
        public String ServerFileName { get; set; }
    }
}
