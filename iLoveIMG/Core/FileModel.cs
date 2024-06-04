using iLoveIMG.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Core
{
    /// <summary>
    ///     File Model
    /// </summary>
    public class FileModel
    {
        /// <summary>
        ///     Server File name
        /// </summary>
        public String ServerFileName { get; set; }

        /// <summary>
        ///     File name
        /// </summary>
        public String FileName { get; set; }

        /// <summary>
        ///     Rotation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Rotate Rotate { get; set; }

        /// <summary>
        ///     Password
        /// </summary>
        public String Password { get; set; }
    }
}
