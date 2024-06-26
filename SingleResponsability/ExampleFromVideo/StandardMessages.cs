namespace ExampleFromVideo;

public class StandardMessages
{
    public static void Welcome()
    {
        Console.WriteLine("Welcome to my application!");
    }

    public static void Error(string fieldName)
    {
        Console.WriteLine($"You did not give us a valid {fieldName}!");
    }
}