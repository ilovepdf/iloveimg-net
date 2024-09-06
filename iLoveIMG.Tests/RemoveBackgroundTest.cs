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
    public class RemoveBackgroundTest : BaseTest
    {
        public RemoveBackgroundTest()
        {
            TaskParams = new RemoveBackgroundParams
            {
                OutputFileName = @"result.jpg"
            };
        }

        private new RemoveBackgroundParams TaskParams { get; }

        protected override Boolean DoRunTask(
            Boolean addFilesByChunks,
            Boolean downloadFileAsByteArray,
            Boolean encryptUsingBuiltinIfNoKeyPresent)
        {
            if (String.IsNullOrWhiteSpace(TaskParams.FileEncryptionKey))
                Task = encryptUsingBuiltinIfNoKeyPresent
                    ? Api.CreateTask<RemoveBackgroundImageTask>(null, true)
                    : Api.CreateTask<RemoveBackgroundImageTask>();
            else
                Task = Api.CreateTask<RemoveBackgroundImageTask>(TaskParams.FileEncryptionKey);

            base.TaskParams = TaskParams;

            var taskWasOk = AddFilesToTask(addFilesByChunks);

            if (taskWasOk)
                taskWasOk = ProcessTask();

            if (taskWasOk)
                taskWasOk = DownloadResult(downloadFileAsByteArray);

            return taskWasOk;
        }

        [TestMethod]
        public void RemoveBackground_RightCredentials_ShouldThrowException()
        {
            InitApiWithRightCredentials();

            AddFile($"{Guid.NewGuid()}.pdf", Settings.GoodJpgFile);

            Assert.IsTrue(RunTask());
        }
    }
}
