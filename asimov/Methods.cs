using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace asimov
{
    internal class Methods
    {
        public static string host = "http://localhost:8080";
        public static CookieContainer cookieContainer = new CookieContainer();
        
        public JObject postRequest(string url, string json)
        {
            string api = host + url;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(api);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.CookieContainer = cookieContainer;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var data = (JObject)JsonConvert.DeserializeObject<dynamic>(result);
                return data;
            }
        }

        // make get request
        public JObject getRequest(string url)
        {
            string api = host + url;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(api);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.CookieContainer = cookieContainer;

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var data = (JObject)JsonConvert.DeserializeObject<dynamic>(result);
                return data;
            }
        }
    }
}
