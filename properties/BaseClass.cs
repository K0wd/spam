namespace adam;

public partial class BaseClass
{
    public IWebDriver? webDriver;

    private Uri selenoidUrl = new Uri("http://adam.southeastasia.cloudapp.azure.com:4444/wd/hub");
    private ChromeOptions chromeOptions = new ChromeOptions();

    public BaseClass()
    {
        // chromeOptions.AddArgument("--disable-extensions");
        // chromeOptions.AddArgument("--disable-application-cache");
        // chromeOptions.AddArgument("--disable-plugins");
        chromeOptions.AddArgument("--clear-browser-cache");
        chromeOptions.AddAdditionalOption("selenoid:options", new Dictionary<string, object> {
            [ "enableVNC" ] =  true,
            [ "enableVideo" ] =  true,
            [ "videoName" ] =  "spam-test-run",
            [ "videoFrameRate" ] =  24, 
            [ "videoCodec" ] =  "mpeg4",
            [ "selenidebrowserSize" ] =  "1920x1080",
        });

        webDriver = new RemoteWebDriver(selenoidUrl, chromeOptions);
        webDriver.Manage().Window.Maximize();
    }
}