namespace adam;

public class WorkflowTests {
    private int id;
    IWebDriver webDriver;
    BaseClass baseClass;
    Steps steps;
    Assertion assert;

    [TearDown]
    public void TearDown(){
        webDriver.Close();
        webDriver.Quit();
    }

    [SetUp]
    public void SetUp(){
        baseClass = new BaseClass();
        webDriver = baseClass.webDriver;
        
        steps = new Steps(webDriver);
        steps.GoTo(URL.BASE_URL);

        assert = new Assertion(webDriver);
        assert.IsDisplayed(LoginPage.BUTTON_LOGIN);
    }

    [Test]
    public void CheckIfSalesPersonCanReceiveLeads()
    {
        steps.Login(Credentials.BUSINESSADMIN, Credentials.PASSWORD);
        
        steps.DeleteAllContacts();

        id = steps.CreateContact("SPAM Execute", "Swanston Street, Melbourne VIC, Australia", "SPAM Sales");

        steps.SwitchUser(Credentials.SALESPERSON, Credentials.PASSWORD);

        steps.ViewContact(id);
    }
}
