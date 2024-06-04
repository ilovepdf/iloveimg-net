using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Exceptions
{
    /// <summary>
    ///     Upload Failed Exception.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [Serializable]
    public class UploadException : System.Exception
    {
        /// <summary>
        ///     Default Constructor
        /// </summary>
        public UploadException()
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        public UploadException(String message) : base(message)
        {
        }

        /// <summary>
        ///     Init a new Instance of the class ILoveIMG.UploadException
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner Exception.</param>
        public UploadException(String message, System.Exception innerException) : base(message, innerException)
        {
        }

#if !NETSTANDARD1_5
        /// <summary>
        ///     Init a new Instance of the class ILoveIMG.UploadException
        /// </summary>
        /// <param name="info"> Serialization Information.</param>
        /// <param name="context"> Streaming Context.</param>
        protected UploadException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}
