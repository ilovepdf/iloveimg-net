using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Tests
{
    public class BaseElementForTest
    {
        protected BaseElementForTest()
        {
            Rotation = iLoveIMG.Model.Enums.Rotate.Degrees0;
        }

        public String Password { get; set; }
        public iLoveIMG.Model.Enums.Rotate Rotation { get; set; }
    }
}
