namespace ISLibrary.Interfaces;

public interface IDVD : ILibraryItem
{
    public List<string> Actors { get; set; }
    public int RuntimeInMinutes { get; set;  }
}