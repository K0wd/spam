namespace adam;

public class LoginTests {
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
    public void CheckValidLoginForBusinessAdmin()
    {
        steps.Login(Credentials.BUSINESSADMIN, Credentials.PASSWORD);
    }
}
