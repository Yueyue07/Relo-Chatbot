﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Connector;
using ReloChatBot;

namespace ReloChatBot.Models
{
    public class MiscBot : LuisParser
    {
        // private LuisClient client;
        // private string raw_result;

       public MiscBot(Activity activity,
            string api_endpoint =
                "https://api.projectoxford.ai/luis/v1/application?id=024edd6d-8598-4a3c-b942-05705dfd39b7&subscription-key=ba3ed0b23b714c4f9a8ca0fe2eeddcea&q=")
            : base(activity, api_endpoint)
        {
        }

        public new string Reply
        {
            get { return this.GetReply(); }
        }

        private Dictionary<string, string> IntentDictionary = new Dictionary<string, string>()
        {
            {
                "GetWeather",
                "Here is a link to the weather in [Redmond](https://weather.com/weather/today/l/USWA0367:1:US)"
            },
            {"GetShoppingCenter", "Here is a link to the [Bellevue Square Mall](http://bellevuecollection.com/)"},
            {
                "GetSupplies",
                "LEAP will provide you with a laptop, monitor, keyboard and mouse for use during the program."
            },

            {
                "GetDressCode",
                "The dress code at Microsoft is business casual. Please dress appropriately for a business environment."
            },

            {
                "GetGym",
                "The [ProClub](https://www.proclub.com/) is a few minutes from the north campus, and here is a link to other [gyms in the area](http://www.yelp.com/search?cflt=gyms&find_loc=Redmond%2C+WA)"
            },
            {"None", "I'm sorry. I do not understand your question."},

        };

        private string GetReply()
        {
            return this.IntentDictionary[this.Intent];
        }
    }
}

//using RelochatBot.models;
//var x = new MiscBot("hello world");
//x.raw_result;
