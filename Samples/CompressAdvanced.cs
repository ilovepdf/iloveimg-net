using iLoveIMG.Core;
using iLoveIMG.Model.Enums;
using iLoveIMG.Model.Task;
using iLoveIMG.Model.TaskParams;

namespace Samples
{
    public class CompressAdvanced
    {
        public void DoTask()
        {
            var api = new iLoveImgApi("PUBLIC_KEY", "SECRET_KEY");

            var task = api.CreateTask<CompressImageTask>();

            //add file, and specify rotation
            var file = task.AddFile("/path/to/document.jpg", task.TaskId);

            //set compress parameters and process files
            var time = task.Process(new CompressParams
            {
                CompressionLevel = CompressionLevels.Low,
                OutputFileName = "low"
            });

            //download output file(s) to specific directory
            task.DownloadFile("path/to/download");
        }
    }
}
