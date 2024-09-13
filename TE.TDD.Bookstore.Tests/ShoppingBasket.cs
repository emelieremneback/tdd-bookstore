namespace TE.TDD.Bookstore.Tests;

public static class ShoppingBasket
{
    public static List<Book> Items { get; } = [];
    public static void AddBook(Book bookToBuy)
    {
        Items.Add(bookToBuy);
    }
}