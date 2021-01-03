using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreeMet2.Utils
{
    public static class HttpMethod
    {
        public static string HttpGet(string baseUri,string uri,IDictionary<string,string> headers = null)
        {
            var serviceUrl = string.Format("{0}/{1}", baseUri, uri);

            var request = (HttpWebRequest)WebRequest.Create(serviceUrl);

            if (headers != null && headers.Count > 0)
            {
                SetRequestHeaders(request,headers);
            }

            var myResponse = (HttpWebResponse)request.GetResponse();

            var reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

            var returnXml = reader.ReadToEnd();

            reader.Close();

            myResponse.Close();

            return returnXml;
        }

        private static void SetRequestHeaders(HttpWebRequest request,IDictionary<string,string> headers)
        {
            foreach (var header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }
        }
    }
}
