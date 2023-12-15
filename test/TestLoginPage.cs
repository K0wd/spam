namespace adam;

public class LoginTests : BaseClass{
    [Test]
    public void CheckValidLogin()
    {
        webDriver.Navigate().GoToUrl(BASE_URL);

        webDriver.FindElement(LoginPage.TEXT_USERNAME).SendKeys(BUSINESSADMIN);
        webDriver.FindElement(LoginPage.TEXT_PASSWORD).SendKeys(BA_PASSWORD);

        webDriver.FindElement(LoginPage.BUTTON_LOGIN).Click();

        IsDisplayed(DashboardPage.HEADER_DASHBOARD);
    }
}
