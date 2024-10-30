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
    public class ResizeAdvanced
    {
        public void DoTask()
        {
            var api = new iLoveImgApi("PUBLIC_KEY", "SECRET_KEY");

            var task = api.CreateTask<ResizeImageTask>();

            //add file, and specify rotation
            var file = task.AddFile("/path/to/document.jpg", task.TaskId);

            //set resize parameters and process files
            task.Process(new ResizeParams
            {
                ResizeMode = ResizeModeEnum.Percentage.GetEnumMemberValue(),
                Percentage = 120,
                OutputFileName = "OutputFileName.jpg",
                NoEnlargeIfSmaller = true
            });

            //download output file(s) to specific directory
            task.DownloadFile("path/to/download");
        }
    }
}