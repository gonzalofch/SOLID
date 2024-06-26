using System.Text;

namespace ExampleFromVideo;

class Program
{
    static void Main(string[] args)
    {
        StandardMessages.Welcome();
        Person user = PersonDataCatcher.Obtain();

        if (!PersonValidator.Validate(user))
        {
            Operations.ExitProgram();
            return;
        }

        UserNameGenerator.Generate(user);
        Operations.ExitProgram();
    }
}