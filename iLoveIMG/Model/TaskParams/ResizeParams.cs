using iLoveIMG.Model.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.TaskParams
{
    public class ResizeParams : BaseParams
    {
        public ResizeParams()
        {
            setDefaultValues();
        }

        /// <summary>
        ///     Resize mode (pixels or percentage)
        /// </summary>
        [JsonProperty("resize_mode")]
        public string ResizeMode { get; set; }

        /// <summary>
        ///    The width in pixels of the resized image.
        /// </summary>
        [JsonProperty("pixels_width ")]
        public int PixelsWidth { get; set; }

        /// <summary>
        ///    The height in pixels of the resized image.
        /// </summary>
        [JsonProperty("pixels_height ")]
        public int PixelsHeight { get; set; }

        /// <summary>
        ///     The percentage value to resize.
        /// </summary>
        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        /// <summary>
        ///     If set as true, resize will keep aspect ratio and images will not be distort.
        /// </summary>
        [JsonProperty("maintain_ratio ")]
        public bool MaintainRatio { get; set; }

        /// <summary>
        ///     Controls if the image can be gigger than the original on resize.
        /// </summary>
        [JsonProperty("no_enlarge_if_smaller  ")]
        public bool NoEnlargeIfSmaller { get; set; }

        private void setDefaultValues()
        {
            ResizeMode = ResizeModeEnum.Pixels.ToString();
            Percentage = 0;
            MaintainRatio = true;
            NoEnlargeIfSmaller = true;
        }
    }
}
