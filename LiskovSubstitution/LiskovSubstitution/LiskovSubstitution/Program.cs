using System.Text;
using LSLibrary;

namespace LiskovSubstitution;

class Program
{
    static void Main(string[] args)
    {
        Manager accountingVp = new Manager();
        accountingVp.FirstName = "Emma";
        accountingVp.LastName = "Stone";
        accountingVp.CalculatePerHourRate(4);

        Employee emp = new CEO();
        emp.FirstName = "TIm";
        emp.LastName = "Corey";
        emp.AssignManager(accountingVp);
        emp.CalculatePerHourRate(2);
    
        Console.WriteLine(new StringBuilder().Append(emp.FirstName)
            .Append("'s salary is $")
            .Append(emp.Salary)
            .Append("/hour.")
            .ToString());
        Console.ReadLine();
    }
}