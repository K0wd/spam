namespace adam;

public partial class Assertion
{
    readonly IWebDriver webDriver;
    private static WebDriverWait? wait;

    public Assertion(IWebDriver webDriver) {
        this.webDriver = webDriver;
    }
    public void IsDisplayed(By element){
        wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
        
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));

        Assert.IsTrue(webDriver.FindElement(element).Displayed);
    }

    public void IsEnabled(By element){
        wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));

        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));

        Assert.IsTrue(webDriver.FindElement(element).Enabled);
    }
}