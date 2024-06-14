using iLoveIMG.Model.Enums;

namespace iLoveIMG.Model.Task
{
    public class RepairImageTask: iLoveImgTask
    {
        public override String ToolName => EnumExtensions.GetEnumDescription(TaskName.RepairImage);

    }
}
