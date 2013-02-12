using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using PocketAPI;

namespace PocketAPIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pocket pocket = new Pocket("Your Consumer Key", "Your Access Token");

            //Add an article
            Item item = pocket.Add("http://en.wikipedia.org/wiki/Pocket_(application)");

            //Retrieve all items
            List<Item> items = pocket.Retrieve();

            //Retrieve all videos
            PocketParameterCollection retrieveParameters = new PocketParameterCollection();
            retrieveParameters.Add("contentType", "video");
            List<Item> conditionalItems = pocket.Retrieve(retrieveParameters);

            //Modify an item          
            PocketAction action = new PocketAction("archive", "229279689", null);
            bool result = pocket.Modify(action);

            //Modify multiple items
            PocketAction action1 = new PocketAction("archive", "229279689", null);
            PocketAction action2 = new PocketAction("archive", "229279689", null);
            PocketAction[] actions = new PocketAction[] { action1, action2 };
            bool[] results = pocket.Modify(actions);
        }
    }
}
