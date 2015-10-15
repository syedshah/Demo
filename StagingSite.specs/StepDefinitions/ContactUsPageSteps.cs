using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace StagingSite.specs
{
    [Binding]
    public class ContactUsPageSteps
    {
        [When]
        public void When_I_fill_in_contactus_form_with_the_following_information(Table table)
        {
            var page = WebBrowser.Current.Page<ContactUsPage>();
            page.Name = table.Rows[1]["value"];
            page.Email = table.Rows[2]["value"];
            page.Message = table.Rows[3]["value"]; 
        }
        
        [When]
        public void When_I_click_the_send_button()
        {
            var p = WebBrowser.Current.Page<ContactUsPage>();
            p.ClickSendButton();
        }
        
        [Then]
        public void Then_I_should_be_able_to_contact_QAWorks_with_the_following_information(Table table)
        {
            var page = WebBrowser.Current.Page<ContactUsPage>();
            Assert..AreEqual(page.Name,  table.Rows[1]["value"]);
            Assert..AreEqual(page.Email,  table.Rows[2]["value"]);
            Assert..AreEqual(page.Message,  table.Rows[3]["value"]);
        }
    }
}
