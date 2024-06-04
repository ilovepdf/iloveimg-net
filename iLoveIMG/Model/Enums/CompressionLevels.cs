using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Enums
{
    /// <summary>
    ///     Compression Levels
    /// </summary>
    public enum CompressionLevels
    {
        /// <summary>
        ///     Extreme
        /// </summary>
        [EnumMember(Value = "extreme")] Extreme,

        /// <summary>
        ///     Recommended
        /// </summary>
        [EnumMember(Value = "recommended")] Recommended,

        /// <summary>
        ///     Low
        /// </summary>
        [EnumMember(Value = "low")] Low
    }
}
