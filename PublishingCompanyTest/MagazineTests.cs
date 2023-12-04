using FluentAssertions;

namespace PublishingCompanyTest
{
    public class MagazineTests
    {

        // Title should be set in constructor
        [Fact]
        public void TitleShouldBeSetInContructor()
        {
            Magazine magazine = new("Hør og se", "Yep", 1);
            magazine.Title.Should().Be("Hør og se");
        }

        // Publisher should be set in constructor

        [Fact]
        public void PublisherShouldBeSetInContructor()
        {
            Magazine magazine = new("Hør og se", "Yep", 1);
            magazine.Publisher.Should().Be("Yep");
        }

        // Volume should be a combination of volume and year
        // Example 4-2023 (volume-year)

        [Fact]
        public void VolumShouldBeCombinationOfVolumAndYear()
        {
            Magazine magazine = new("Hør og se", "Yep", 1);
            magazine.Volume.Should().Be("1-" + DateTime.Now.Year);
        }

        [Fact]
        public void SubscriptionCostShouldBeSetCorrectly()
        {
            Magazine magazine = new("Hør og se", "Yep", 1);
            magazine.SetSubscriptionCost(120);
            magazine.SubscriptionCost.Should().Be(120);
        }

        [Fact]
        public void ToStringShouldReturnTitleAndVolume()
        {
            Magazine magazine = new("Hør og se", "Yep", 1);
            magazine.ToString().Should().Be($"Hør og se 1-{DateTime.Now.Year}");
        }

    }
}
