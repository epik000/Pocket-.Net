using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketAPI
{
    public class PocketAction
    {
        public string ActionName {get; private set;}
        public string ItemId { get; private set; }
        public PocketParameterCollection Parameters {get; private set;}

        public PocketAction(string actionName, string itemId, PocketParameterCollection parameters)
        {
            ActionName = actionName;
            ItemId = itemId;
            Parameters = parameters;
        }
    }
}
