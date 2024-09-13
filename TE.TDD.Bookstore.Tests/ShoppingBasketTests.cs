using FluentAssertions;

namespace TE.TDD.Bookstore.Tests;

[TestFixture]
public class ShoppingBasketTests
{
    [Test]
    public void Add_One_Book_To_Basket()
    {
        //Arrange
        var bookToBuy = new Book("FirstBook", 8.0);

        //Act
        ShoppingBasket.AddBook(bookToBuy);
        var result = ShoppingBasket.Items;
        
        //Assert
        result.Should().ContainSingle();
        result.Should().Contain(x => x.Title == "FirstBook");
    }

    [Test]
    public void Calculate_Total_Price()
    {
        
    }
    
}