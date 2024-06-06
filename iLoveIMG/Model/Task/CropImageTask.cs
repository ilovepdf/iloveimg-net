using iLoveIMG.Core;
using iLoveIMG.Model.Enums;
using iLoveIMG.Model.TaskParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Task
{
    public class CropImageTask : iLoveImgTask
    {
        public override String ToolName => EnumExtensions.GetEnumDescription(TaskName.CropImage);

        public ExecuteTaskResponse Process()
        {
            var parameters = new CropParams();

            return base.Process(parameters);
        }

        public ExecuteTaskResponse Process(CropParams parameters)
        {
            if (parameters == null)
            {
                parameters = new CropParams();
            }

            return base.Process(parameters);
        }
    }
}
