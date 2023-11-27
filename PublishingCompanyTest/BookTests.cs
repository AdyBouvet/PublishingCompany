using FluentAssertions;
using PublishingCompany;

namespace PublishingCompanyTest
{
    public class BookTests
    {
        [Fact]
        public void TitleShoudBeSetInContructor()
        {
            Book book = new("Dune", "SomePublisher", "Frank Herbert");
            book.Title.Should().Be("Dune");
        }

        [Fact]
        public void PublisherShoudBeSetInContructor()
        {
            Book book = new("Dune", "SomePublisher", "Frank Herbert");
            book.Publisher.Should().Be("SomePublisher");
        }

        [Fact]
        public void AuthorShoudBeSetInContructor()
        {
            Book book = new("Dune", "SomePublisher", "Frank Herbert");
            book.Author.Should().Be("Frank Herbert");
        }

        [Fact]
        public void PriceShouldBeSetIfValid()
        {
            Book book = new("Dune", "SomePublisher", "Frank Herbert");
            book.SetPrice(100, "NOK");
            book.Price.Should().Be(100);
        }

        [Fact]
        public void CurrencyShouldBeSetIfValid()
        {
            Book book = new("Dune", "SomePublisher", "Frank Herbert");
            book.SetPrice(100, "NOK");
            book.Currency.Should().Be("NOK");
        }

        [Fact]
        public void SetPriceShouldThrowExceptionIfPriceIsLessThanZero()
        {
            Book book = new("Dune", "SomePublisher", "Frank Herbert");
            book.Invoking(x => x.SetPrice(-1, "NOK")).Should().Throw<ArgumentOutOfRangeException>();            
        }

        [Fact]
        public void SetPriceShouldThrowExceptionIfCurrencyLengthIsNotThree()
        {
            Book book = new("Dune", "SomePublisher", "Frank Herbert");
            book.Invoking(x => x.SetPrice(100, "A")).Should().Throw<ArgumentException>();
        }

        [Fact]
        public void ToStringShouldContainTitleAndAuthor()
        {
            Book book = new("Dune", "SomePublisher", "Frank Herbert");
            book.ToString().Should().Be("Dune by Frank Herbert");
        }

    }
}