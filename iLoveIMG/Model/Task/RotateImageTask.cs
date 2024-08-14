using iLoveIMG.Model.Enums;

namespace iLoveIMG.Model.Task
{
    public class RotateImageTask : iLoveImgTask
    {
        public override String ToolName => EnumExtensions.GetEnumDescription(TaskName.RotateImage);

    }
}
