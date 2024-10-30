using iLoveIMG.Core;
using iLoveIMG.Model.Enums;
using iLoveIMG.Model.Task;
using iLoveIMG.Model.TaskParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    public class RotateImage
    {
        public void DoTask()
        {
            var api = new iLoveImgApi("PUBLIC_KEY", "SECRET_KEY");

            var task = api.CreateTask<RotateImageTask>();

            //add file, and specify rotation. Rotate tool has no options, just set rotation property in file.
            var file = task.AddFile("/path/to/document.jpg", task.TaskId, Rotate.Degrees90);

            task.Process(null);

            //download output file(s) to specific directory
            task.DownloadFile("path/to/download");
        }
    }
}
