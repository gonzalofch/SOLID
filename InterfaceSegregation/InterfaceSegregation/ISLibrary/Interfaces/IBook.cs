namespace ISLibrary.Interfaces;

public interface IBook : ILibraryItem
{
    public string Autor { get; set; }
    public int Pages { get; set; }
}