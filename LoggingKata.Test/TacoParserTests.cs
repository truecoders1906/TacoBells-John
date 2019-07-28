using System;
using Xunit;
using LoggingKata;
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
        [InlineData("Example")]
        public void ShouldParse(string str)
        {

            string expected = "Example";

            string actual = 
            // TODO: Complete Should Parse
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {


            // TODO: Complete Should Fail Parse
        }
    }
}
