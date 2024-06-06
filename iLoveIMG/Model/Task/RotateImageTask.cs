using iLoveIMG.Core;
using iLoveIMG.Model.Enums;
using iLoveIMG.Model.TaskParams;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Task
{
    public class RotateImageTask : iLoveImgTask
    {
        public override String ToolName => EnumExtensions.GetEnumDescription(TaskName.RotateImage);

    }
}
