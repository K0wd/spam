namespace adam;

public partial class Steps : BaseClass
{
    public static void GoTo(string url){
        webDriver.Navigate().GoToUrl(url);
    }
}
