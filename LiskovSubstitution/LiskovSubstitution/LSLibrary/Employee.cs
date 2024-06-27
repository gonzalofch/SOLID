namespace LSLibrary;

public class Employee : BaseEmployee, IManaged
{
    public IEmployee Manager { get; set; } = null;

    public void AssignManager(IEmployee manager)
    {
        Manager = manager;
    }
}