using iLoveIMG.Core;
using iLoveIMG.Model.Task;
using iLoveIMG.Model.TaskParams;

namespace Samples
{
    public class CropAdvanced
    {
        public void DoTask()
        {
            var api = new iLoveImgApi("PUBLIC_KEY", "SECRET_KEY");

            var task = api.CreateTask<CropImageTask>();

            //add file, and specify rotation
            var file = task.AddFile("/path/to/document.jpg", task.TaskId);

            //set crop parameters and process files
            var time = task.Process(new CropParams
            {
                Widht = 300,
                Height = 300,
                X = 2,
                Y = 2,
                OutputFileName = "OutputFileName.jpg"
            });

            //download output file(s) to specific directory
            task.DownloadFile("path/to/download");

        }
    }
}


