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
        public void Given_I_m_on_the_registration_page()
        {
            WebBrowser.Current.GoTo("http://localhost:62988/Register.aspx");
        }
    }
}
