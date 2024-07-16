using iLoveIMG.Model.Enums;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.TaskParams
{
    public class UpscaleParams : BaseParams
    {
        /// <summary>
        ///     Constructor
        /// </summary>
         public UpscaleParams()
        {
            setDefaultValues();
        }

        /// <summary>
        ///     Multiplier
        /// </summary>
        [JsonProperty("multiplier ")]
        public int Multiplier { get; set; }

        private void setDefaultValues()
        {
            Multiplier = (int)UpscaleMultiplier.x2;
            
        }
    }
}
