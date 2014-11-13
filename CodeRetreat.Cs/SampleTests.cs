using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace CodeRetreat.Cs
{
    public class SampleTests
    {
        [Fact]
        public void Test()
        {
            true.Should().BeTrue();
        }

        [Theory]
        [InlineData(true), InlineData(true)]
        public void Theory(bool input)
        {
            input.Should().BeTrue();
        }
    }
}