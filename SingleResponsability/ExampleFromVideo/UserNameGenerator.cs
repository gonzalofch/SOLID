using System.Text;

namespace ExampleFromVideo;

public class UserNameGenerator
{
    public static void Generate(Person user)
    {
        var userName = new StringBuilder("Your username is ")
            .Append(user.FirstName[..1])
            .Append(user.LastName);
        Console.WriteLine(userName.ToString());
    }
}