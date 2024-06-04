using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Enums
{
    /// <summary>
    ///     iLovelImg errors
    /// </summary>
    public enum BadRequestErrors
    {
        /// <summary>
        ///     Upload error
        /// </summary>
        [Description("UploadError")] UploadError,

        /// <summary>
        ///     Processing error
        /// </summary>
        [Description("ProcessingError")] ProcessingError,

        /// <summary>
        ///     Download error
        /// </summary>
        [Description("DownloadError")] DownloadError,


        /// <summary>
        /// StartError
        /// </summary>
        [Description("StartError")] StartError,
    }
}
