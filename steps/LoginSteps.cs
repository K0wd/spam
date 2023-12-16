namespace adam;

public partial class Steps : BaseClass
{
    public static void Login(string _username, string _password) {
        webDriver.FindElement(LoginPage.TEXT_USERNAME).SendKeys(_username);
        webDriver.FindElement(LoginPage.TEXT_PASSWORD).SendKeys(_password);

        webDriver.FindElement(LoginPage.BUTTON_LOGIN).Click();

        IsDisplayed(DashboardPage.HEADER_DASHBOARD);
    }

    public static void SwitchUser(string _username, string _password) {
        webDriver.Navigate().GoToUrl(BASE_URL);

        IsDisplayed(DashboardPage.APP_LAUNCHER);

        webDriver.FindElement(DashboardPage.APP_LAUNCHER).Click();

        for (int i = 0; i < 5; i++)
        {
            webDriver.FindElement(DashboardPage.APP_LAUNCHER).SendKeys(Keys.Down);
        }
        webDriver.FindElement(DashboardPage.APP_LAUNCHER).SendKeys(Keys.Enter);

        IsDisplayed(LoginPage.BUTTON_LOGIN);

        Login(_username, _password);
    }
}
