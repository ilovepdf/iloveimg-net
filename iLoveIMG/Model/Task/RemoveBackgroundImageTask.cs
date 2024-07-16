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
    /// <summary>
    ///     RemoveBackground Images
    /// </summary>
    public class RemoveBackgroundImageTask : iLoveImgTask
    {
        /// <inheritdoc />
        public override String ToolName => EnumExtensions.GetEnumDescription(TaskName.RemoveBackground);

        /// <summary>
        ///     Process the task
        /// </summary>
        /// <returns></returns>
        public ExecuteTaskResponse Process()
        {
            var parameters = new RemoveBackgroundParams();

            return base.Process(parameters);
        }

        /// <summary>
        ///     Process the task
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        public ExecuteTaskResponse Process(RemoveBackgroundParams parameters)
        {
            if (parameters == null)
                parameters = new RemoveBackgroundParams();

            return base.Process(parameters);
        }
    }
}
