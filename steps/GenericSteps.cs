namespace adam;

public partial class BaseClass : Credentials
{
    public static void GoTo(string url){
        webDriver.Navigate().GoToUrl(url);
    }
}
