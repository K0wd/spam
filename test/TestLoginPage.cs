namespace adam;

public class LoginTests : BaseClass {
    [Test]
    public void CheckValidLoginForBusinessAdmin()
    {
        Steps.Login(BUSINESSADMIN, PASSWORD);
    }
}
