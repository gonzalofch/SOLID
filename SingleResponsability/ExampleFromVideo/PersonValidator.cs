namespace ExampleFromVideo;

public class PersonValidator
{
    public static bool Validate(Person user)
    {
        if (string.IsNullOrWhiteSpace(user.FirstName))
        {
            StandardMessages.DisplayError("first name");
            return false;
        }

        if (string.IsNullOrWhiteSpace(user.LastName))
        {
            StandardMessages.DisplayError("last name");
            return false;
        }

        return true;
    }
}