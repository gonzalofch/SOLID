namespace LSLibrary;

public interface IManaged :IEmployee
{
    IEmployee Manager { get; set; }
    public void AssignManager(Employee manager);
}