using FluentAssertions;
using Xunit;

namespace CodeRetreat.Cs
{
    public class SampleTests
    {
        [Fact]
        public void Test()
        {
            true.Should().BeTrue();
        }
    }
}