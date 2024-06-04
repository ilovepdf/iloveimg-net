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
    public enum ConvertToValues
    {
        /// <summary>
        ///     png
        /// </summary>
        [EnumMember(Value = "png")] PNG,

        /// <summary>
        ///     Gif
        /// </summary>
        [EnumMember(Value = "gif")] GIF,
        
        /// <summary>
        ///     jpg
        /// </summary>
        [EnumMember(Value = "jpg")] JPG,
        
        /// <summary>
        ///     GifAnimation
        /// </summary>
        [EnumMember(Value = "gif_animation ")] GIFAnimation,
        
        /// <summary>
        ///     heic
        /// </summary>
        [EnumMember(Value = "heic")] HEIC
    }
}
