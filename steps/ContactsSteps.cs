namespace adam;

public partial class Steps : BaseClass
{

    public static int CreateContact(string _fullName, string _address) {
        GoTo(V4_CONTACT_URL);

        IsDisplayed(ContactPage.V4_NEW_CONTACT);

        webDriver.FindElement(ContactPage.V4_NEW_CONTACT).Click();

        IsDisplayed(QuoteContactPage.V4_CONTACT_ID);
        webDriver.FindElement(QuoteContactPage.V4_FULL_NAME).SendKeys(_fullName);
        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(_address);

        IsDisplayed(QuoteContactPage.V4_ADDRESS_AUTOCOMPLETE);

        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(Keys.Down);
        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(Keys.Enter);

        IsEnabled(QuoteContactPage.V4_NEW_QUOTE);
        IsEnabled(QuoteContactPage.V4_VIEW_CRM);

        Thread.Sleep(5000);

        return Convert.ToInt32(webDriver.FindElement(QuoteContactPage.V4_CONTACT_ID).Text.Replace("Contact ", ""));

    }
    public static int CreateContact(string _fullName, string _address, string _customerRepName) {
        GoTo(V4_CONTACT_URL);

        IsDisplayed(ContactPage.V4_NEW_CONTACT);

        webDriver.FindElement(ContactPage.V4_NEW_CONTACT).Click();

        IsDisplayed(QuoteContactPage.V4_CONTACT_ID);

        ScrollDown(2);
        IsDisplayed(QuoteContactPage.V4_STAFF_ASSIGN);
        webDriver.FindElement(QuoteContactPage.V4_STAFF_ASSIGN).SendKeys(_customerRepName);

        ScrollUp(2);
        webDriver.FindElement(QuoteContactPage.V4_FULL_NAME).SendKeys(_fullName);
        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(_address);

        IsDisplayed(QuoteContactPage.V4_ADDRESS_AUTOCOMPLETE);

        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(Keys.Down);
        webDriver.FindElement(QuoteContactPage.V4_ADDRESS).SendKeys(Keys.Enter);

        IsEnabled(QuoteContactPage.V4_NEW_QUOTE);
        IsEnabled(QuoteContactPage.V4_VIEW_CRM);

        Thread.Sleep(5000);

        return Convert.ToInt32(webDriver.FindElement(QuoteContactPage.V4_CONTACT_ID).Text.Replace("Contact ", ""));
    }

    public static void DeleteAllContacts(){
        GoTo(V4_CONTACT_URL);

        try
        {
            IsDisplayed(ContactPage.V4_DELETE_FIRST);
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