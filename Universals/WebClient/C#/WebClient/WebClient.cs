using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace WebClient
{
    /// <summary>
    /// Provides a universal way to make HTTP requests
    /// </summary>
    public class WebClient
    {
        private HttpClient _client = new HttpClient();
        public void GetAsyncString(string URL, Action<string> handler)
        {
            _client.GetStringAsync(URL).ContinueWith(resp => handler(resp.Result));
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
