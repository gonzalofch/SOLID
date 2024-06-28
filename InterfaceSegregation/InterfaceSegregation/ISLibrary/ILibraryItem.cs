namespace ISLibrary;

public interface ILibraryItem
{
    public string LibraryId { get; set; }
    public string Title { get; set; }
    public string Autor { get; set; }
    public int Pages { get; set; }
    public int CheckOutDurationInDays { get; set; }
    public string Borrower { get; set; }
    public DateTime BorrowDate { get; set; }

    public void CheckOut(string borrower);
    public void CheckIn();
    public DateTime GetDueDate();
}