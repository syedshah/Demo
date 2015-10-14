using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingSite.specs
{
    using TechTalk.SpecFlow;

    [Binding]
    public class NavigationSteps
    {
        [Given]
        public void Given_I_am_on_the_QAWorks_Staging_Site()
        {
            WebBrowser.Current.GoTo("http://staging.qaworks.com:1403/contact.aspx");
        }
    }
}
