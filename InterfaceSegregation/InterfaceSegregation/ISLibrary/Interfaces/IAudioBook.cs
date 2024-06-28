namespace ISLibrary.Interfaces;

public interface IAudioBook : ILibraryItem
{
    public int RuntimeInMinutes { get; set; }

}