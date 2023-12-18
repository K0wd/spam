namespace adam;

public partial class Steps
{
    public void Login(string _username, string _password) {
        assert.IsDisplayed(LoginPage.BUTTON_LOGIN);

        webDriver.FindElement(LoginPage.TEXT_USERNAME).SendKeys(_username);
        webDriver.FindElement(LoginPage.TEXT_PASSWORD).SendKeys(_password);

        webDriver.FindElement(LoginPage.BUTTON_LOGIN).Click();

        assert.IsDisplayed(DashboardPage.HEADER_DASHBOARD);
    }

    public void SwitchUser(string _username, string _password) {
        webDriver.Navigate().GoToUrl(URL.BASE_URL);

        assert.IsDisplayed(DashboardPage.APP_LAUNCHER);

        webDriver.FindElement(DashboardPage.APP_LAUNCHER).Click();

        for (int i = 0; i < 5; i++)
        {
            webDriver.FindElement(DashboardPage.APP_LAUNCHER).SendKeys(Keys.Down);
        }
        webDriver.FindElement(DashboardPage.APP_LAUNCHER).SendKeys(Keys.Enter);

        assert.IsDisplayed(LoginPage.BUTTON_LOGIN);

        Login(_username, _password);
    }
}
