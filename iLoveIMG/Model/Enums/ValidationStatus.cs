using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Enums
{
    /// <summary>
    ///     Validation Status
    /// </summary>
    public enum ValidationStatus
    {
        /// <summary>
        ///     Conformant
        /// </summary>
        [EnumMember(Value = "Conformant")] Conformant,

        /// <summary>
        ///     NonConformant
        /// </summary>
        [EnumMember(Value = "NonConformant")] NonConformant
    }
}
