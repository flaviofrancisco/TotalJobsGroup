using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace PairingTest.Web.Helpers
{
    public static class HttpClientHelper
    {
        public static string Url { get; set; }

        public static HttpClient GetHttpClient(string url)
        {
            HttpClient client;

            Url = url;
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}