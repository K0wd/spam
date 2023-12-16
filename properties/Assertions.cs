namespace adam;

public partial class BaseClass : Credentials
{
    public static void ScrollUp(int numberOfScrolls=1){
        IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
        for (int i = 0; i < numberOfScrolls; i++)
        {
            js.ExecuteScript("window.scrollBy(0, -500);");
        }
    }

    public static void ScrollDown(int numberOfScrolls=1){
        IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
        for (int i = 0; i < numberOfScrolls; i++)
        {
            js.ExecuteScript("window.scrollBy(0, 500);");
        }
    }
    public static void ScrollIntoView(By elemenet){
        IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;

        IWebElement elementToScrollTo = webDriver.FindElement(elemenet);
        js.ExecuteScript("arguments[0].scrollIntoView();", elementToScrollTo);
    }
    public static void IsDisplayed(By element){
        wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));

        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));

        Assert.IsTrue(webDriver.FindElement(element).Displayed);
    }

    public static void IsEnabled(By element){
        wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));

        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));

        Assert.IsTrue(webDriver.FindElement(element).Enabled);
    }
}