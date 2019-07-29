using System;
using Xunit;
namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }
        [Theory]
        [InlineData("34.073638,-84.677017, Taco Bell Acwort... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("33.470013, -86.816966, Taco Bell Birmingham / ... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth/... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("30.906033,-87.79328,Taco Bell Bay Minett... (Free trial * Add to Cart for a full POI info)")]
        public void ShouldParse(string str)
        {
            // Arrange
            TacoParser location = new TacoParser();
            // Act
            ITrackable actual = location.Parse(str);
            // Assert
            Assert.NotNull(actual);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // Arrange
            TacoParser Location = new TacoParser();
            // Act
            ITrackable actual = Location.Parse(str);
            // Assert
            Assert.Null(actual);
        }
    }
}