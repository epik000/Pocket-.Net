// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using JsonCSharpClassGenerator;

namespace PocketAPI
{

    public class Author
    {
        private JObject __jobject;
        public Author(JObject obj)
        {
            this.__jobject = obj;
        }

        public string AuthorId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "author_id"));
            }
        }

        public string Name
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "name"));
            }
        }

        public string Url
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "url"));
            }
        }

    }
}
