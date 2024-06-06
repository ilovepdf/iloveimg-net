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
        ///     Convert image
        /// </summary>
        [Description("convertimage")] ConvertImage = 1,

        /// <summary>
        ///     Crop image
        /// </summary>
        [Description("cropimage")] CropImage = 2,

        /// <summary>
        ///     Rotate image
        /// </summary>
        [Description("rotateimage")] RotateImage = 3,

        /// <summary>
        ///     Rotate image
        /// </summary>
        [Description("repairimage")] RepairImage = 4,
    }
}
