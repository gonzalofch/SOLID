﻿namespace OCLibrary;

public class ManagerAccounts : IAccounts
{
    public EmployeeModel Create(IApplicantModel person)
    {       
        EmployeeModel output = new EmployeeModel();
        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@manageracme.com";
        output.IsManager = true;
        return output;
    }
}