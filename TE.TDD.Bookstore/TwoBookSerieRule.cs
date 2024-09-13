namespace TE.TDD.Bookstore;

public class TwoBookSerieRule
{
    private const double Discount = 0.1;

    public double CalculateDiscount(List<Book> bookSerie)
    {
        return bookSerie.Count == 2 ? bookSerie.Sum(b => b.Price) * Discount : 0;
    }
}