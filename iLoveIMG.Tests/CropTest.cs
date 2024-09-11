using iLoveIMG.Model.Task;
using iLoveIMG.Model.TaskParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Tests
{
    [TestClass]
    public class CropTest : BaseTest
    {
        public CropTest()
        {
            TaskParams = new CropParams
            {
                OutputFileName = @"result.jpg"
            };
        }

        private new CropParams TaskParams { get; }

        protected override Boolean DoRunTask(
            Boolean addFilesByChunks,
            Boolean downloadFileAsByteArray,
            Boolean encryptUsingBuiltinIfNoKeyPresent)
        {
            if (String.IsNullOrWhiteSpace(TaskParams.FileEncryptionKey))
                Task = encryptUsingBuiltinIfNoKeyPresent
                    ? Api.CreateTask<CropImageTask>(null, true)
                    : Api.CreateTask<CropImageTask>();
            else
                Task = Api.CreateTask<CropImageTask>(TaskParams.FileEncryptionKey);

            base.TaskParams = TaskParams;

            var taskWasOk = AddFilesToTask(addFilesByChunks);

            if (taskWasOk)
                taskWasOk = ProcessTask();

            if (taskWasOk)
                taskWasOk = DownloadResult(downloadFileAsByteArray);

            return taskWasOk;
        }

        [TestMethod]
        public void Crop_RightCredentials_ShouldThrowException()
        {
            InitApiWithRightCredentials();

            AddFile($"{Guid.NewGuid()}.jpg", Settings.GoodJpgFile);

            TaskParams.Widht = 300;
            TaskParams.Height = 300;
            TaskParams.X = 2;
            TaskParams.Y = 2;

            Assert.IsTrue(RunTask());
        }
    }
}
