using iLoveIMG.Model.Enums;
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
    public class ResizeTest : BaseTest
    {
        public ResizeTest()
        {
            TaskParams = new ResizeParams
            {
                OutputFileName = @"result.jpg"
            };
        }

        private new ResizeParams TaskParams { get; set; }

        protected override Boolean DoRunTask(
            Boolean addFilesByChunks,
            Boolean downloadFileAsByteArray,
            Boolean encryptUsingBuiltinIfNoKeyPresent)
        {
            if (String.IsNullOrWhiteSpace(TaskParams.FileEncryptionKey))
                Task = encryptUsingBuiltinIfNoKeyPresent
                    ? Api.CreateTask<ResizeImageTask>(null, true)
                    : Api.CreateTask<ResizeImageTask>();
            else
                Task = Api.CreateTask<ResizeImageTask>(TaskParams.FileEncryptionKey);

            base.TaskParams = TaskParams;

            var taskWasOk = AddFilesToTask(addFilesByChunks);

            if (taskWasOk)
                taskWasOk = ProcessTask();

            if (taskWasOk)
                taskWasOk = DownloadResult(downloadFileAsByteArray);

            return taskWasOk;
        }

        [TestMethod]
        public void Resize_RightCredentials_ShouldThrowException()
        {
            InitApiWithRightCredentials();

            AddFile($"{Guid.NewGuid()}.jpg", Settings.GoodJpgFile);

            TaskParams.ResizeMode = ResizeModeEnum.Percentage.GetEnumMemberValue();
            TaskParams.Percentage = 120;
            

            Assert.IsTrue(RunTask());
        }
    }
}
