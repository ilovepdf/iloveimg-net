using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.TaskParams
{
    public class CropParams : BaseParams
    {
        public CropParams()
        {
            setDefaultValues();
        }


        /// <summary>
        ///     The width in pixels of the area to crop.
        /// </summary>
        [JsonProperty("width")]
        public int Widht { get; set; }

        /// <summary>
        ///     The height in pixels of the area to crop.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        ///     The horizontal point where start to crop.
        /// </summary>
        [JsonProperty("x")]
        public int X { get; set; }

        /// <summary>
        ///     The vertical point where start to crop.
        /// </summary>
        [JsonProperty("y")]
        public int Y { get; set; }

        private void setDefaultValues()
        {
            X = 0;
            Y = 0;
        }
    }
}
