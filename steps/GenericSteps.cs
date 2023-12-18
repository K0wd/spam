namespace adam;

public partial class Steps
{
    readonly IWebDriver? webDriver;
    Assertion assert;

    public Steps(IWebDriver? webDriver) {
        this.webDriver = webDriver;
        assert = new Assertion(this.webDriver);
    }
    public void GoTo(string url){
        webDriver.Navigate().GoToUrl(url);
    }

    public void ScrollUp(int numberOfScrolls=1){
        IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
        for (int i = 0; i < numberOfScrolls; i++)
        {
            js.ExecuteScript("window.scrollBy(0, -500);");
        }
    }

    public void ScrollDown(int numberOfScrolls=1){
        IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
        for (int i = 0; i < numberOfScrolls; i++)
        {
            js.ExecuteScript("window.scrollBy(0, 500);");
        }
    }
    public void ScrollIntoView(By elemenet){
        IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;

        IWebElement elementToScrollTo = webDriver.FindElement(elemenet);
        js.ExecuteScript("arguments[0].scrollIntoView();", elementToScrollTo);
    }
}
