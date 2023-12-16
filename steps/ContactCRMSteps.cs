namespace adam;

public partial class Steps : BaseClass
{
    public static void ViewContact(int id){
        webDriver.Navigate().GoToUrl(BASE_URL + "/app/contact/" + id);

        IsDisplayed(ContactCRMPage.CONTACT_DETAILS);

        Assert.IsTrue(webDriver.Url.Contains(id.ToString()));
    }
}
