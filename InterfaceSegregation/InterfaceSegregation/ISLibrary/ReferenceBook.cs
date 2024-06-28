using ISLibrary.Interfaces;

namespace ISLibrary;

public class ReferenceBook : IBook
{
    public string LibraryId { get; set; }
    public string Title { get; set; }
    public string Autor { get; set; }
    public int Pages { get; set; }
}