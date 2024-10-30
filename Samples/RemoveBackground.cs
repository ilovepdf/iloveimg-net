using iLoveIMG.Core;
using iLoveIMG.Model.Task;
using iLoveIMG.Model.TaskParams;

namespace Samples
{
    public class RemoveBackground
    {
        public void DoTask()
        {
            var api = new iLoveImgApi("PUBLIC_KEY", "SECRET_KEY");

            var task = api.CreateTask<RemoveBackgroundImageTask>();

            //add file, and specify rotation
            var file = task.AddFile("/path/to/document.png", task.TaskId);

            //set remove background parameters and process files
            var time = task.Process(new RemoveBackgroundParams
            {
                OutputFileName = "TestingOutfileName.png"
            });

            //download output file(s) to specific directory
            task.DownloadFile("path/to/download");
        }
    }
}