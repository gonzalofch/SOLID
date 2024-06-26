namespace ExampleFromVideo;

public class PersonDataCatcher
{
    public static Person Obtain()
    {
        Console.Write("What is your first name: ");
        string FirstName = Console.ReadLine();

        Console.Write("What is your last name: ");
        string LastName = Console.ReadLine();
        return new Person(FirstName, LastName);
    }
}