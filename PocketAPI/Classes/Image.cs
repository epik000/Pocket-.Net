// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using JsonCSharpClassGenerator;

namespace PocketAPI
{

    public class Image
    {
        private JObject __jobject;
        public Image(JObject obj)
        {
            this.__jobject = obj;
        }

        public string ItemId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "item_id"));
            }
        }

        public string ImageId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "image_id"));
            }
        }

        public string Src
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "src"));
            }
        }

        public string Width
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "width"));
            }
        }

        public string Height
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "height"));
            }
        }

        public string Credit
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "credit"));
            }
        }

        public string Caption
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "caption"));
            }
        }

    }
}
