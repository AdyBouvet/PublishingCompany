using FluentAssertions;
using PublishingCompany.Publication;

namespace PublishingCompanyTest
{
    public class PublicationTests
    {
        [Fact]
        public void TitleShoudBeSetInContructor()
        {
            Publication publication = new("Dune", "SomePublisher");
            publication.Title.Should().Be("Dune");
        }

        [Fact]
        public void PublisherShoudBeSetInContructor()
        {
            Publication publication = new("Dune", "SomePublisher");
            publication.Publisher.Should().Be("SomePublisher");
        }

        [Fact]
        public void ShouldNotBePublishedWhenCreated()
        {
            Publication publication = new("Dune", "SomePublisher");
            publication.Published.Should().Be(false);
        }

        [Fact]
        public void ShouldBePublishedWhenPublished()
        {
            Publication publication = new("Dune", "SomePublisher");
            publication.Publish();
            publication.Published.Should().Be(true);
        }

        [Fact]
        public void ToStringShouldContainTitle()
        {
            Publication publication = new("Dune", "SomePublisher");
            publication.ToString().Should().Be("Dune");
        }

        [Fact]
        public void SetPriceShouldThrowExceptionIfPriceIsLessThanZero()
        {
            Publication publication = new("Dune", "SomePublisher");
            publication.Invoking(x => x.SetPages(-1)).Should().Throw<ArgumentOutOfRangeException>();
        }

    }
}
