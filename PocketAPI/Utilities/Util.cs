using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace PocketAPI
{
    class Util
    {
        public static JObject PostJson(string address, JObject jobject)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/json");
                client.Headers.Add("X-Accept", "application/json");
                client.Encoding = System.Text.Encoding.UTF8;
                return JObject.Parse(client.UploadString(address, jobject.ToString()));
            }
        }
    }
}
