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
    public class UpscaleAdvanced
    {
        public void DoTask()
        {
            var api = new iLoveImgApi("PUBLIC_KEY", "SECRET_KEY");

            var task = api.CreateTask<UpscaleImageTask>();

            //add file.
            var file = task.AddFile("/path/to/document.jpg", task.TaskId);

            //set upscale parameters and process files
            var time = task.Process(new UpscaleParams
            {
                Multiplier = 4
            });

            //download output file(s) to specific directory
            task.DownloadFile("path/to/download");
        }
    }
}
