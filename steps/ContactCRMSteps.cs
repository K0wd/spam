namespace adam;

public partial class Steps
{
    public void ViewContact(int id){
        webDriver.Navigate().GoToUrl(URL.BASE_URL + "/app/contact/" + id);

        assert.IsDisplayed(ContactCRMPage.CONTACT_DETAILS);

        Assert.IsTrue(webDriver.Url.Contains(id.ToString()));
    }
}
