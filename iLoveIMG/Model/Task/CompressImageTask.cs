using iLoveIMG.Core;
using iLoveIMG.Model.Enums;
using iLoveIMG.Model.TaskParams;
using System.Diagnostics.CodeAnalysis;

namespace iLoveIMG.Model.Task
{
    /// <summary>
    ///     Compress PDFs
    /// </summary>
    public class CompressImageTask : iLoveImgTask
    {
        /// <inheritdoc />
        public override String ToolName => EnumExtensions.GetEnumDescription(TaskName.CompressImage);

        /// <summary>
        ///     Process the task
        /// </summary>
        /// <returns></returns>
        public ExecuteTaskResponse Process()
        {
            var parameters = new CompressParams();

            return base.Process(parameters);
        }

        /// <summary>
        ///     Process the task
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        public ExecuteTaskResponse Process(CompressParams parameters)
        {
            if (parameters == null)
                parameters = new CompressParams();

            return base.Process(parameters);
        }
    }
}
