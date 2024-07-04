using DILibrary;

namespace DependencyInversion;

public static class Factory
{
    public static IPerson CreatePerson()
    {
        return new Person();
    }

    public static IChore CreateChore()
    {
        return new Chore(CreateLogger(),CreateEmailer());
    }

    public static ILogger CreateLogger()
    {
        return new Logger();
    }

    public static IMessageSender CreateEmailer()
    {
        return new Emailer();
    }
}