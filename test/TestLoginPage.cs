namespace adam;

public class Login : BaseClass{
    [Test]
    public void CheckValidLogin()
    {
        webDriver.Navigate().GoToUrl(BASE_URL);

        webDriver.FindElement(ObjectMappingLoginPage.TEXT_USERNAME).SendKeys("solarone");
        webDriver.FindElement(ObjectMappingLoginPage.TEXT_PASSWORD).SendKeys("S0lar4U");

        webDriver.FindElement(ObjectMappingLoginPage.BUTTON_LOGIN).Click();

        IsDisplayed(ObjectMappingDashboardPage.HEADER_DASHBOARD);
        IsDisplayed(ObjectMappingDashboardPage.HEADER_DASHBOARD);
    }
}
