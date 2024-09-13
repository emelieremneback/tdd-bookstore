namespace TE.TDD.Bookstore;

public class Book(string title, double price)
{
    public string Title { get; } = title;
    public double Price { get; } = price;
}