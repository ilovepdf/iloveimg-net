using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Core
{
    /// <summary>
    ///     Delete Task Response
    /// </summary>
    public class DeleteTaskResponse
    {
        /// <summary>
        ///     Upload Status
        /// </summary>
        [JsonProperty("upload_status")]
        public String UploadStatus { get; set; }
    }
}
