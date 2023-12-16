namespace adam;

public class WorkflowTests : BaseClass {
    private int id;

    [Test]
    public void CheckIfSalesPersonCanReceiveLeads()
    {
        Steps.Login(BUSINESSADMIN, PASSWORD);
        
        Steps.DeleteAllContacts();

        id = Steps.CreateContact("SPAM Execute", "Swanston Street, Melbourne VIC, Australia", "SPAM Sales");

        Steps.SwitchUser(SALESPERSON, PASSWORD);

        Steps.ViewContact(id);
    }
}
