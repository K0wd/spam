namespace adam;

public partial class BaseClass
{
    public static IWebDriver webDriver;

    private static Uri selenoidUrl = new Uri("http://adam.southeastasia.cloudapp.azure.com:4444/wd/hub");
    private static ChromeOptions chromeOptions = new ChromeOptions();
    private static WebDriverWait? wait;

    [SetUp]
    public void Setup()
    {
        Hashtable selenoidOptions = new Hashtable {
            { "enableVNC", true },
            { "enableVideo", true },
            { "videoName", "spam-test-run"},
            { "videoFrameRate", 30 }, 
            { "videoCodec", "mpeg4"},
            { "selenide.browserSize", "1920x1080" },
        };
        chromeOptions.AddArgument("--disable-extensions");
        chromeOptions.AddArgument("--clear-browser-cache");
        chromeOptions.AddArgument("--disable-application-cache");
        chromeOptions.AddArgument("--disable-plugins");
        chromeOptions.AddAdditionalOption("selenoid:options", selenoidOptions);

        webDriver = new RemoteWebDriver(selenoidUrl, chromeOptions);
        webDriver.Manage().Window.Maximize();
        webDriver.Navigate().GoToUrl(BASE_URL);

        IsDisplayed(LoginPage.BUTTON_LOGIN);
    }
}
