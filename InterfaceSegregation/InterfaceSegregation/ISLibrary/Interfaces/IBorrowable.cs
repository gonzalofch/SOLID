namespace ISLibrary.Interfaces;

public interface IBorrowable
{
    public string Borrower { get; set; }
    public DateTime BorrowDate { get; set; }
    public int CheckOutDurationInDays { get; set; }
    
    public void CheckOut(string borrower);
    public void CheckIn();
    public DateTime GetDueDate();
}