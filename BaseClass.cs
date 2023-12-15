namespace adam;

public class BaseClass
{
    public const string BUSINESSADMIN = "spam";
    public const string BA_PASSWORD = "SolarPlus123!";

    public const string BASE_URL = "https://go.solarplus.co";
    public static IWebDriver webDriver;


    private static Uri selenoidUrl = new Uri("http://adam.southeastasia.cloudapp.azure.com:4444/wd/hub");
    private static ChromeOptions chromeOptions = new ChromeOptions();
    private static WebDriverWait? wait;

    [SetUp]
    public void Setup()
    {
        Hashtable selenoidOptions = new Hashtable {
            { "enableVNC", true },
            { "selenide.browserSize", "1920x1080" }
        };
        chromeOptions.AddAdditionalOption("selenoid:options", selenoidOptions);

        webDriver = new RemoteWebDriver(selenoidUrl, chromeOptions);
        webDriver.Manage().Window.Maximize();
    }

    public static void IsDisplayed(By element){
        wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));

        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
        Assert.IsTrue(webDriver.FindElement(element).Displayed);
    }
}
