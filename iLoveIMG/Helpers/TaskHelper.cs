using System;
using System.Net.Http;

namespace iLoveIMG.Helpers
{
    public static class TaskHelper
    {
        public static HttpResponseMessage RunAsSync(Task<HttpResponseMessage> taskForRun)
        {
            if (taskForRun == null) return null;

            var callAsyncTask = Task.Run(() => taskForRun);
            callAsyncTask.Wait();
            return callAsyncTask.Result;
        }

        public static string RunAsSync(Task<string> taskForRun)
        {
            if (taskForRun == null) return null;

            var callAsyncTask = Task.Run(() => taskForRun);
            callAsyncTask.Wait();
            return callAsyncTask.Result;
        }

        public static byte[] RunAsSync(Task<byte[]> taskForRun)
        {
            if (taskForRun == null) return null;

            var callAsyncTask = Task.Run(() => taskForRun);
            callAsyncTask.Wait();
            return callAsyncTask.Result;
        }
    }
}
