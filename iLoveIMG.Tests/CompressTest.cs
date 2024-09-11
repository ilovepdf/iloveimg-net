using iLoveIMG.Core;
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
    public class CompressTest : BaseTest
    {
        public CompressTest()
        {
            TaskParams = new CompressParams
            {
                OutputFileName = @"result.jpg"
            };
        }

        private new CompressParams TaskParams { get; }

        protected override Boolean DoRunTask(
            Boolean addFilesByChunks,
            Boolean downloadFileAsByteArray,
            Boolean encryptUsingBuiltinIfNoKeyPresent)
        {
            if (String.IsNullOrWhiteSpace(TaskParams.FileEncryptionKey))
                Task = encryptUsingBuiltinIfNoKeyPresent
                    ? Api.CreateTask<CompressImageTask>(null, true)
                    : Api.CreateTask<CompressImageTask>();
            else
                Task = Api.CreateTask<CompressImageTask>(TaskParams.FileEncryptionKey);

            base.TaskParams = TaskParams;

            var taskWasOk = AddFilesToTask(addFilesByChunks);

            if (taskWasOk)
                taskWasOk = ProcessTask();

            if (taskWasOk)
                taskWasOk = DownloadResult(downloadFileAsByteArray);

            return taskWasOk;
        }

        [TestMethod]
        public void Compress_RightCredentials_ShouldThrowException()
        {
            InitApiWithRightCredentials();

            AddFile($"{Guid.NewGuid()}.jpg", Settings.GoodJpgFile);

            Assert.IsTrue(RunTask());
        }
    }
}
