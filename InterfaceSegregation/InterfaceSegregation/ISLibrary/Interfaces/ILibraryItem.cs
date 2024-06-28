namespace ISLibrary.Interfaces;

public interface ILibraryItem
{
    public string LibraryId { get; set; } //necesario
    public string Title { get; set; } //necesario
    // public string Autor { get; set; } //depende del tipo de item
    // public int Pages { get; set; }//depende del tipo de item
    // public int CheckOutDurationInDays { get; set; } //cualidad diferente que puede ser extraida a otra interfaz
    // public string Borrower { get; set; } //cualidad diferente que puede ser extraida a otra interfaz
    // public DateTime BorrowDate { get; set; } //cualidad diferente que puede ser extraida a otra interfaz
    //
    // public void CheckOut(string borrower); //cualidad diferente que puede ser extraida a otra interfaz
    // public void CheckIn(); //cualidad diferente que puede ser extraida a otra interfaz
    // public DateTime GetDueDate(); //cualidad diferente que puede ser extraida a otra interfaz
}