﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingSite.specs
{
    using TechTalk.SpecFlow;

    using WatiN.Core;

    public static class WebBrowser
    {
        private const string Key = "browser";

        public static IE Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey(Key))
                {
                    var ie = new IE();

                    // for demo purposes
                    ie.AutoClose = false;
                    //ie.BringToFrontForDemo();

                    ScenarioContext.Current[Key] = ie;
                }

                return ScenarioContext.Current[Key] as IE;
            }
        }
    }
}
