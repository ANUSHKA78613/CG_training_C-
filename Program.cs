using System;
using System.Collections.Generic;
using LibrarySystem;
using ItemAlias = LibrarySystem.Items;

class Program
{
    static void Main()
    {
       
        ItemAlias.Book book = new ItemAlias.Book
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemID = 101
        };

        ItemAlias.Magazine magazine = new ItemAlias.Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemID = 201
        };

        book.DisplayItemDetails();
        Console.WriteLine("Late Fee for 3 days: " + book.CalculateLateFee(3));
        Console.WriteLine();

        magazine.DisplayItemDetails();
        Console.WriteLine("Late Fee for 3 days: " + magazine.CalculateLateFee(3));
        Console.WriteLine();

     
        IReservable reservable = book;
        INotifiable notifiable = book;

        reservable.Reserve();
        notifiable.Notify("Your reserved book is ready for pickup.");
        Console.WriteLine();

     
        List<LibraryItem> items = new List<LibraryItem>();
        items.Add(book);
        items.Add(magazine);

        foreach (LibraryItem item in items)
        {
            item.DisplayItemDetails();
        }

        Console.WriteLine("Method selection happens at runtime.\n");

      
        LibraryAnalytics.TotalBorrowedItems += 5;
        LibraryAnalytics.DisplayAnalytics();
        Console.WriteLine();

       
        LibrarySystem.Users.Member member = new LibrarySystem.Users.Member
        {
            Name = "Anushka",
            Role = UserRole.Member
        };

        book.Status = ItemStatus.Borrowed;

        Console.WriteLine("User Role: " + member.Role);
        Console.WriteLine("Item Status: " + book.Status);
        Console.WriteLine();

   
        if (member.Role == UserRole.Admin)
            Console.WriteLine("Admin Alert: System maintenance scheduled.");
        else
            Console.WriteLine("Member Notification: Your borrowed item is due tomorrow.");

        ItemAlias.eBook ebook = new ItemAlias.eBook
        {
            Title = "Digital C#",
            Author = "Tech Author",
            ItemID = 301
        };

        ebook.Download();
    }
}
