using FluentAssertions;

namespace TE.TDD.Bookstore.Tests;

//Discount
//5% rabatt om man köper 2 olika böcker

[TestFixture]
public class TwoBookSerieRuleTests
{
    private const string Title = "title";
    private const double BookPrice = 8.0;
    private Book _firstBook = new("FirstBook", BookPrice);
    private Book _secondBook = new("SecondBook", BookPrice);
    private Book _thirdBook = new("ThirdBook", BookPrice);


    [Test]
    public void One_Book_Gives_No_10_Procent_Discount()
    {
        const double expectedDiscount = 0;
        var rule = new TwoBookSerieRule();

        var result = rule.CalculateDiscount([_firstBook]);

        result.Should().Be(expectedDiscount);
    }
    
    [Test]
    public void Two_Different_Books_Gives_10_Procent_Discount()
    {
        const double expectedDiscount = BookPrice*2*0.1;

        var rule = new TwoBookSerieRule();

        var result = rule.CalculateDiscount([_firstBook, _secondBook]);

        result.Should().Be(expectedDiscount);
    }
    
    [Test]
    public void Three_Book_Gives_No_10_Procent_Discount()
    {
        const double expectedDiscount = 0;
        var bookSerie = new List<Book> { _firstBook, _secondBook, _thirdBook };
        var rule = new TwoBookSerieRule();

        var result = rule.CalculateDiscount(bookSerie);

        result.Should().Be(expectedDiscount);
    }
}