using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Core
{
    /// <summary>
    ///     Execute Task Response
    /// </summary>
    public class ExecuteTaskResponse
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public ExecuteTaskResponse()
        {
            Validations = new Collection<Validation>();
        }

        /// <summary>
        ///     Validations
        /// </summary>
        [JsonProperty("validations")]
        public Collection<Validation> Validations { get; }

        /// <summary>
        ///     FileSize
        /// </summary>
        [JsonProperty("filesize")]
        public Int64 FileSize { get; set; }

        /// <summary>
        ///     OutputFileSize
        /// </summary>
        [JsonProperty("output_filesize")]
        public Int64 OutputFileSize { get; set; }

        /// <summary>
        ///     Timer
        /// </summary>
        [JsonProperty("timer")]
        public Decimal Timer { get; set; }
    }
}
