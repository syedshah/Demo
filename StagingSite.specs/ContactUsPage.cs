using WatiN.Core;

namespace StagingSite.specs
{
    internal class ContactUsPage : Page
    {
        private const string NameId = "ctl00_MainContent_NameBox";
        private const string EmailId = "ctl00_MainContent_NameBox";
        private const string MessageId = "ctl00_MainContent_MessageBox";
        private const string NameValidationErrorId = "ctl00_MainContent_rfvName";
        private const string EmailValidationErrorId = "ctl00_MainContent_rfvEmailAddress";
        private const string MessageValidationErrorId = "ctl00_MainContent_rfvMessage";

        public string Name
        {
            get
            {
                return this.Document.TextField(Find.ById(NameId)).Text;
            }
            set
            {
                Document.TextField(Find.ById(NameId)).TypeText(value);

                WebBrowser.Current.Eval(string.Format("$('#{0}').keypress()", NameId));
            }
        }

        public string Email
        {
            get
            {
                return this.Document.TextField(Find.ById(EmailId)).Text;
            }
            set
            {
                Document.TextField(Find.ById(EmailId)).TypeText(value);

                WebBrowser.Current.Eval(string.Format("$('#{0}').keypress()", EmailId));
            }
        }

        public string Message
        {
            get
            {
                return this.Document.TextField(Find.ById(MessageId)).Text;
            }
            set
            {
                Document.TextField(Find.ById(MessageId)).TypeText(value);

                WebBrowser.Current.Eval(string.Format("$('#{0}').keypress()", MessageId));
            }
        }

        public string NameValidationErrorText
        {
            get
            {
                return this.Document.List(Find.ById(NameValidationErrorId)).Text;
            }
        }

        public string EmailValidationErrorText
        {
            get
            {
                return this.Document.List(Find.ById(EmailValidationErrorId)).Text;
            }
        }

        public string MessageValidationErrorText
        {
            get
            {
                return this.Document.List(Find.ById(MessageValidationErrorId)).Text;
            }
        }

        public void ClickSendButton()
        {
            Document.Button(Find.ById("ctl00_MainContent_SendButton")).Click();
        }
    }
}
