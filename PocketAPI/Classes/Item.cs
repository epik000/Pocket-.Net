// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using JsonCSharpClassGenerator;

namespace PocketAPI
{

    public class Item
    {
        private JObject __jobject;
        public Item(JObject obj)
        {
            this.__jobject = obj;
        }

        public string ContentLength
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "content_length"));
            }
        }

        public string DatePublished
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "date_published"));
            }
        }

        public string DateResolved
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "date_resolved"));
            }
        }

        public string DomainId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "domain_id"));
            }
        }

        public string Encoding
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "encoding"));
            }
        }

        public string Excerpt
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "excerpt"));
            }
        }

        public string ExtendedItemId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "extended_item_id"));
            }
        }

        public string Favorite
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "favorite"));
            }
        }

        public string GivenUrl
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "given_url"));
            }
        }

        public string GivenTitle
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "given_title"));
            }
        }

        public string HasImage
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "has_image"));
            }
        }

        public string HasVideo
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "has_video"));
            }
        }

        public string InnerdomainRedirect
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "innerdomain_redirect"));
            }
        }

        public string IsArticle
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "is_article"));
            }
        }

        public string IsIndex
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "is_index"));
            }
        }

        public string ItemId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "item_id"));
            }
        }

        public string LoginRequired
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "login_required"));
            }
        }

        public string MimeType
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "mime_type"));
            }
        }

        public string NormalUrl
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "normal_url"));
            }
        }

        public string OriginDomainId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "origin_domain_id"));
            }
        }

        public string ResolvedId
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "resolved_id"));
            }
        }

        public string ResolvedNormalUrl
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "resolved_normal_url"));
            }
        }

        public string ResolvedTitle
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "resolved_title"));
            }
        }

        public string ResolvedUrl
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "resolved_url"));
            }
        }

        public string ResponseCode
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "response_code"));
            }
        }

        public string Status
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "status"));
            }
        }

        public string Title
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "title"));
            }
        }

        public string UsedFallback
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "used_fallback"));
            }
        }

        public string WordCount
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "word_count"));
            }
        }

        //Images xxx
        //Videos xxx 
        //Authors xxx
        //Tags
    }
}
