using iLoveIMG.Core;
using iLoveIMG.Model.Enums;
using iLoveIMG.Model.Exceptions;
using iLoveIMG.Model.TaskParams;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.Task
{
    public class UpscaleImageTask : iLoveImgTask
    {
        public override String ToolName => EnumExtensions.GetEnumDescription(TaskName.Upscale);

        /// <summary>
        ///     Process the task
        /// </summary>
        /// <returns></returns>
        public ExecuteTaskResponse Process()
        {
            var parameters = new UpscaleParams();

            return base.Process(parameters);
        }

        /// <summary>
        ///     Process the task
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        public ExecuteTaskResponse Process(UpscaleParams parameters)
        {
            if (parameters.Multiplier != 2 && parameters.Multiplier != 4)
            {
                throw new MultiplierException($"Invalid multiplier: {parameters.Multiplier}. Accepted values are 2 and 4.");
            }

            if (parameters == null)
                parameters = new UpscaleParams();

            return base.Process(parameters);
        }
    }
}
