using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace iLoveIMG.Helpers
{
    public static class TaskHelper
    {

        public static T RunAsSync<T>(Task<T> taskForRun)
        {
            if (taskForRun == null) return default;
            return taskForRun.ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public static HttpResponseMessage RunAsSync(Task<HttpResponseMessage> taskForRun)
        {
            return RunAsSync<HttpResponseMessage>(taskForRun);
        }

        public static string RunAsSync(Task<string> taskForRun)
        {
            return RunAsSync<string>(taskForRun);
        }

        public static byte[] RunAsSync(Task<byte[]> taskForRun)
        {
            return RunAsSync<byte[]>(taskForRun);
        }
    }
}
