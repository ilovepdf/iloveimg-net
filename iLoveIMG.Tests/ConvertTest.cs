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
    public class ConvertTest : BaseTest
    {
        public ConvertTest()
        {
            TaskParams = new ConvertParams
            {
                OutputFileName = @"result.jpg"
            };
        }

        private new ConvertParams TaskParams { get; }

        protected override Boolean DoRunTask(
            Boolean addFilesByChunks,
            Boolean downloadFileAsByteArray,
            Boolean encryptUsingBuiltinIfNoKeyPresent)
        {
            if (String.IsNullOrWhiteSpace(TaskParams.FileEncryptionKey))
                Task = encryptUsingBuiltinIfNoKeyPresent
                    ? Api.CreateTask<ConvertImageTask>(null, true)
                    : Api.CreateTask<ConvertImageTask>();
            else
                Task = Api.CreateTask<ConvertImageTask>(TaskParams.FileEncryptionKey);

            base.TaskParams = TaskParams;

            var taskWasOk = AddFilesToTask(addFilesByChunks);

            if (taskWasOk)
                taskWasOk = ProcessTask();

            if (taskWasOk)
                taskWasOk = DownloadResult(downloadFileAsByteArray);

            return taskWasOk;
        }

        [TestMethod]
        public void Convert_RightCredentials_ShouldThrowException()
        {
            InitApiWithRightCredentials();

            AddFile($"{Guid.NewGuid()}.jpg", Settings.GoodJpgFile);

            TaskParams.OutputFileName = Settings.GoodPngFile;

            Assert.IsTrue(RunTask());
        }
    }
}
