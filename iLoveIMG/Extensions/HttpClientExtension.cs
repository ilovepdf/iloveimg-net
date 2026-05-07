using System;
using System.Net.Http;
using iLoveIMG.Helpers;

namespace iLoveIMG.Extensions
{
    /// <summary>
    /// Synchronous helper extension methods for <see cref="HttpClient"/>.
    /// These are thin wrappers around the async APIs and use TaskHelper to block safely.
    /// Prefer using the async APIs directly when possible.
    /// </summary>
    static class HttpClientExtensions
    {
        /// <summary>Send an <see cref="HttpRequestMessage"/>.</summary>
        public static HttpResponseMessage Send(this HttpClient client, HttpRequestMessage httpRequestMessage)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (httpRequestMessage == null) throw new ArgumentNullException(nameof(httpRequestMessage));
            return TaskHelper.RunAsSync(client.SendAsync(httpRequestMessage));
        }

        /// <summary>Perform a GET request to the specified <see cref="Uri"/>.</summary>
        public static HttpResponseMessage Get(this HttpClient client, Uri uri)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (uri == null) throw new ArgumentNullException(nameof(uri));
            return TaskHelper.RunAsSync(client.GetAsync(uri));
        }

        /// <summary>Perform a POST request to the specified <see cref="Uri"/> with provided content.</summary>
        public static HttpResponseMessage Post(this HttpClient client, Uri uri, HttpContent httpContent)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (uri == null) throw new ArgumentNullException(nameof(uri));
            return TaskHelper.RunAsSync(client.PostAsync(uri, httpContent));
        }

        /// <summary>Perform a PUT request to the specified <see cref="Uri"/> with provided content.</summary>
        public static HttpResponseMessage Put(this HttpClient client, Uri uri, HttpContent httpContent)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (uri == null) throw new ArgumentNullException(nameof(uri));
            return TaskHelper.RunAsSync(client.PutAsync(uri, httpContent));
        }

        /// <summary>Perform a DELETE request to the specified <see cref="Uri"/>.</summary>
        public static HttpResponseMessage Delete(this HttpClient client, Uri uri)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (uri == null) throw new ArgumentNullException(nameof(uri));
            return TaskHelper.RunAsSync(client.DeleteAsync(uri));
        }
    }
}
