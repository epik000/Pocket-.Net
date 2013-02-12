using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PocketAPI
{
    public class Pocket
    {
        public string ConsumerKey { get; private set; }
        public string AccessToken { get; private set; }

        public Pocket(string consumerKey, string accessToken)
        {
            ConsumerKey = consumerKey;
            AccessToken = accessToken;
        }

        //Add

        public Item Add(string url)
        {
            return Add(url, null);
        }

        public Item Add(string url, PocketParameterCollection optionalParameters)
        {
            JObject jobject = new JObject { new JProperty("consumer_key", ConsumerKey), 
                new JProperty("access_token", AccessToken),
                new JProperty("url", url)};

            if (optionalParameters != null)
            {
                foreach (var key in optionalParameters.AllKeys)
                {
                    jobject.Add(new JProperty(key, optionalParameters[key]));
                }
            }

            JObject response = Util.PostJson("https://getpocket.com/v3/add", jobject);

            //Add Error Handling
            Item item = new Item(response["item"].ToObject<JObject>());
            return item;
        }

        //Modify

        public bool Modify(PocketAction action)
        {
            PocketAction[] actions = new PocketAction[] { action };
            return Modify(actions).FirstOrDefault();
        }

        public bool[] Modify(PocketAction[] actions)
        {
            JObject jobject = new JObject { new JProperty("consumer_key", ConsumerKey), new JProperty("access_token", AccessToken) };

            JArray jarray = new JArray();

            foreach (PocketAction action in actions)
            {
                JObject jaction = new JObject { new JProperty("action", action.ActionName), new JProperty("item_id", action.ItemId) };
                if (action.Parameters != null)
                {
                    foreach (var key in action.Parameters.AllKeys)
                    {
                        jaction.Add(new JProperty(key, action.Parameters[key]));
                    }
                }
                jarray.Add(jaction);
            }

            jobject.Add("actions", jarray);

            JObject response = Util.PostJson("https://getpocket.com/v3/send", jobject);

            //Add error handling

            List<bool> returnbools = new List<bool>();
            foreach (var result in response["action_results"])
            {
                returnbools.Add(Convert.ToBoolean(result.ToString()));
            }

            return returnbools.ToArray();
        }

        //Retrieve

        public List<Item> Retrieve()
        {
            return Retrieve(null);
        }

        public List<Item> Retrieve(PocketParameterCollection optionalParameters)
        {
            JObject jobject = new JObject { new JProperty("consumer_key", ConsumerKey), new JProperty("access_token", AccessToken) };

            if (optionalParameters != null)
            {
                foreach (var key in optionalParameters.AllKeys)
                {
                    jobject.Add(new JProperty(key, optionalParameters[key]));
                }
            }

            JObject response = Util.PostJson("https://getpocket.com/v3/get", jobject);
            List<Item> items = new List<Item>();

            //Add Error Handling
            foreach (var itemString in response["list"])
            {
                JObject itemJObject = itemString.First.ToObject<JObject>();
                Item item = new Item(itemJObject);
                items.Add(item);
            }

            return items;
        }
    }
}
