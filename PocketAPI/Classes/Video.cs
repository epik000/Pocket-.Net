// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using JsonCSharpClassGenerator;

namespace PocketAPI
{

    public class Video
    {
        private JObject __jobject;
        public Video(JObject obj)
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

        public string VideoId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "video_id"));
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

        public string Type
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "type"));
            }
        }

        public string Vid
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "vid"));
            }
        }

    }
}
