using System.Text;

namespace ExampleFromVideo;

class Program
{
    static void Main(string[] args)
    {
        StandardMessages.Welcome();

        Person user = PersonDataCatcher.Obtain();   
        
//Checks to be sure the first and last names are valid
        if (string.IsNullOrWhiteSpace(user.FirstName))
        {
            StandardMessages.Error("first name");
            Console.ReadLine();
            return;
        }

        if (string.IsNullOrWhiteSpace(user.LastName))
        {
            StandardMessages.Error("last name");
            Console.ReadLine();
            return;
        }

//Create a username for the person
        Console.WriteLine(new StringBuilder().Append("Your username is ")
            .Append(user.FirstName.Substring(0, 1))
            .Append(user.LastName)
            .ToString());
        
        Operations.ExitProgram();
    }
}