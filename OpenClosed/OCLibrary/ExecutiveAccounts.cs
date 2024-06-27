namespace OCLibrary;

public class ExecutiveAccounts : IAccounts
{
    public EmployeeModel Create(IApplicantModel person)
    {
        EmployeeModel output = new EmployeeModel();
        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@executiveacme.com";
        output.IsManager = true;
        output.IsExecutive = true;
        return output;
    }
}