using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Enums
{
    /// <summary>
    ///     Available tasks
    /// </summary>
    public enum TaskName
    {
        /// <summary>
        ///     Compress image
        /// </summary>
        [Description("compressimage")] CompressImage = 0,

        /// <summary>
        ///     Conver image
        /// </summary>
        [Description("convertimage")] ConvertImage = 1,
    }
}
