namespace adam;

public partial class Steps
{

    public int CreateContact(string _fullName, string _address) {
        GoTo(URL.V4_CONTACT_URL);

        assert.IsDisplayed(ContactPage.V4_NEW_CONTACT);

        webDriver.FindElement(ContactPage.V4_NEW_CONTACT).Click();

        assert.IsDisplayed(QuoteContactPage.V4_CONTACT_ID);
        webDriver.FindElement(QuoteContactPage.V4_FULL_NAME).SendKeys(_fullName);
        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(_address);

        assert.IsDisplayed(QuoteContactPage.V4_ADDRESS_AUTOCOMPLETE);

        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(Keys.Down);
        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(Keys.Enter);

        assert.IsEnabled(QuoteContactPage.V4_NEW_QUOTE);
        assert.IsEnabled(QuoteContactPage.V4_VIEW_CRM);

        Thread.Sleep(5000);

        return Convert.ToInt32(webDriver.FindElement(QuoteContactPage.V4_CONTACT_ID).Text.Replace("Contact ", ""));

    }
    public int CreateContact(string _fullName, string _address, string _customerRepName) {
        GoTo(URL.V4_CONTACT_URL);

        assert.IsDisplayed(ContactPage.V4_NEW_CONTACT);

        webDriver.FindElement(ContactPage.V4_NEW_CONTACT).Click();

        assert.IsDisplayed(QuoteContactPage.V4_CONTACT_ID);

        ScrollDown(2);
        assert.IsDisplayed(QuoteContactPage.V4_STAFF_ASSIGN);
        webDriver.FindElement(QuoteContactPage.V4_STAFF_ASSIGN).SendKeys(_customerRepName);

        ScrollUp(2);
        webDriver.FindElement(QuoteContactPage.V4_FULL_NAME).SendKeys(_fullName);
        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(_address);

        assert.IsDisplayed(QuoteContactPage.V4_ADDRESS_AUTOCOMPLETE);

        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(Keys.Down);
        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(Keys.Enter);

        assert.IsEnabled(QuoteContactPage.V4_NEW_QUOTE);
        assert.IsEnabled(QuoteContactPage.V4_VIEW_CRM);

        Thread.Sleep(5000);

        return Convert.ToInt32(webDriver.FindElement(QuoteContactPage.V4_CONTACT_ID).Text.Replace("Contact ", ""));
    }

    public void DeleteAllContacts(){
        GoTo(URL.V4_CONTACT_URL);

        try
        {
            assert.IsDisplayed(ContactPage.V4_DELETE_FIRST);
            while(webDriver.FindElement(ContactPage.V4_DELETE_FIRST).Displayed) {
                webDriver.FindElement(ContactPage.V4_DELETE_FIRST).Click();
                webDriver.FindElement(ContactPage.V4_CONFIRM_DELETE).Click();
            }
        }
        catch (Exception)
        {

        }
        
    }
}