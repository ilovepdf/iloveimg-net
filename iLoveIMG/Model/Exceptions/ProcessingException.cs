using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Exceptions
{
    /// <summary>
    ///     Processing Failed Exception.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [Serializable]
    public class ProcessingException : Exception
    {
        /// <summary>
        ///     Default Constructor
        /// </summary>
        public ProcessingException()
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        public ProcessingException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Init a new Instance of the class ILoveIMG.ProcessingException
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner Exception.</param>
        public ProcessingException(string message, Exception innerException) : base(message, innerException)
        {
        }

#if !NETSTANDARD1_5
        /// <summary>
        ///     Init a new Instance of the class ILoveIMG.ProcessingException
        /// </summary>
        /// <param name="info"> Serialization Information.</param>
        /// <param name="context"> Streaming Context.</param>
        protected ProcessingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}
