using System.Text;

namespace ExampleFromVideo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my application!");

//ask for user information
        Person user = new Person();

        Console.Write("What is your first name: ");
        user.FirstName = Console.ReadLine();

        Console.Write("What is your last name: ");
        user.LastName = Console.ReadLine();

//Checks to be sure the first and last names are valid
        if (string.IsNullOrWhiteSpace(user.FirstName))
        {
            Console.WriteLine("You did not give us a valid first name!");
            Console.ReadLine();
            return;
        }

        if (string.IsNullOrWhiteSpace(user.LastName))
        {
            Console.WriteLine("Ypu did not give us a valid last name!");
            Console.ReadLine();
            return;
        }

//Create a username for the person
        Console.WriteLine(new StringBuilder().Append("Your username is ")
            .Append(user.FirstName.Substring(0, 1))
            .Append(user.LastName)
            .ToString());
    }
}