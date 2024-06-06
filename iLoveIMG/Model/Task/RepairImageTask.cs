using iLoveIMG.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Task
{
    public class RepairImageTask: iLoveImgTask
    {
        public override String ToolName => EnumExtensions.GetEnumDescription(TaskName.RepairImage);

    }
}
