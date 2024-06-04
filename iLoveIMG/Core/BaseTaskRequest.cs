using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Core
{
    /// <summary>
    ///     Base class for requests.
    /// </summary>
    public class BaseTaskRequest
    {
        /// <summary>
        ///     Initialize properties
        /// </summary>
        public BaseTaskRequest()
        {
            initFields();
        }

        /// <summary>
        ///     Upload form data to the server
        /// </summary>
        public Dictionary<String, Object> FormData { get; private set; }

        private void initFields()
        {
            FormData = new Dictionary<String, Object>();
        }
    }
}
