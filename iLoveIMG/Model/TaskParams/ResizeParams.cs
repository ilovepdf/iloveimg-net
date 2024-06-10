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
        ///     The width in pixels of the area to crop.
        /// </summary>
        [JsonProperty("resize_mode")]
        public ResizeMode ResizeMode { get; set; }

        /// <summary>
        ///     The width in pixels of the area to crop.
        /// </summary>
        [JsonProperty("pixels_width ")]
        public int PixelsWidth { get; set; }

        /// <summary>
        ///     The width in pixels of the area to crop.
        /// </summary>
        [JsonProperty("pixels_height ")]
        public int PixelsHeight { get; set; }

        /// <summary>
        ///     The width in pixels of the area to crop.
        /// </summary>
        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        /// <summary>
        ///     The width in pixels of the area to crop.
        /// </summary>
        [JsonProperty("maintain_ratio ")]
        public bool MaintainRatio { get; set; }

        /// <summary>
        ///     The width in pixels of the area to crop.
        /// </summary>
        [JsonProperty("no_enlarge_if_smaller  ")]
        public bool NoEnlargeIfSmaller { get; set; }

        private void setDefaultValues()
        {
            ResizeMode = ResizeMode.Pixels;
            MaintainRatio = true;
            NoEnlargeIfSmaller = true;
        }
    }
}
