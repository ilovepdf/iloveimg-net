using iLoveIMG.Core;
using iLoveIMG.Model.Task;

namespace Samples
{
    public class CompressBasic
    {
        public void DoTask()
        {
            var api = new iLoveImgApi("PUBLIC_KEY", "SECRET_KEY");

            var task = api.CreateTask<CompressImageTask>();

            //add file, and specify rotation
            var file = task.AddFile("/path/to/document.jpg", task.TaskId);

            //proces added files
            //time var will contains information about time spent in process
            var time = task.Process();

            //download output file(s) to specific directory
            task.DownloadFile("path/to/download");
        }
    }
}
