namespace adam;

public static class ContactPage {
    public static By V4_NEW_CONTACT = By.XPath("//*[@id='app']/div/div/div[1]/a[1]");
    public static By V4_CONTACTS_TABLE = By.XPath("//*[@id='app']/div/div/div[2]/div[3]/div[3]/div[1]/table");
    public static By V4_DELETE_FIRST = By.XPath("//*[@id='app']/div/div/div[2]/div[3]/div[3]/div[1]/table/tbody/tr[1]/td[9]/div/div[3]/button");
    public static By V4_CONFIRM_DELETE = By.XPath("//*[@id='app']/div[2]/div/div/div[3]/button[2]");
}