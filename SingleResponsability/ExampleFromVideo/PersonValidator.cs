namespace ExampleFromVideo;

public class PersonValidator
{
    public static bool Validate(Person user)
    {
        //Checks to be sure the first and last names are valid
        if (string.IsNullOrWhiteSpace(user.FirstName))
        {
            StandardMessages.Error("first name");
            return false;
        }

        if (string.IsNullOrWhiteSpace(user.LastName))
        {
            StandardMessages.Error("last name");
            return false;
        }

        return true;
    }

}