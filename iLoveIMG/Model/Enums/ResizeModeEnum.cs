using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Enums
{
    public enum ResizeModeEnum
    {
        // <summary>
        ///     pixels
        /// </summary>
        [EnumMember(Value = "pixels")] Pixels,

        // <summary>
        ///     percentage
        /// </summary>
        [EnumMember(Value = "percentage")]Percentage
    }
}
