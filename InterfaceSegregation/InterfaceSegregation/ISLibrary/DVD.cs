﻿namespace ISLibrary;

public class DVD : ILibraryItem
{
    public string LibraryId { get; set; }
    public string Title { get; set; }
    public string Autor { get; set; } = "";
    public int Pages { get; set; }
    public int CheckOutDurationInDays { get; set; } = 14;
    public string Borrower { get; set; }
    public DateTime BorrowDate { get; set; }
    public List<string> Actors { get; set; }
    public int RuntimeInMinutes { get; set; }

    public void CheckOut(string borrower)
    {
        Borrower = borrower;
        BorrowDate = DateTime.Now;
    }

    public void CheckIn()
    {
        Borrower = "";
    }

    public DateTime GetDueDate()
    {
        return BorrowDate.AddDays(CheckOutDurationInDays);
    }
}