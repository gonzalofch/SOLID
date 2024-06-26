using System.Text;

namespace ExampleFromVideo;

public class UserNameGenerator
{
    public static string Generate(Person user)
    {
        var userName =new StringBuilder().Append("Your username is ")
            .Append(user.FirstName[..1])
            .Append(user.LastName)
            .ToString();
        return userName;
    }
}