using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Exceptions
{
    public class MultiplierException : Exception
    {
        public MultiplierException(string message) : base(message) { }
    }
}
