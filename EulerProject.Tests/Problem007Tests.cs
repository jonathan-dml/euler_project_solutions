using EulerProject.Problem007;

namespace EulerProject.Tests;

public class Problem007Tests
{
    [Fact]
    public void Example_SixthPrime_Is13()
    {
        Assert.Equal(13L, Program.NthPrime(6));
    }

    [Fact]
    public void Answer_10001stPrime()
    {
        Assert.Equal(104743L, Program.NthPrime(10_001));
    }

    [Theory]
    [InlineData(1, 2L)] // the only even prime
    [InlineData(2, 3L)]
    [InlineData(3, 5L)]
    [InlineData(4, 7L)]
    [InlineData(5, 11L)] // 9 is skipped
    [InlineData(9, 23L)]
    [InlineData(10, 29L)] // 25 and 27 are skipped
    public void FirstPrimes(int n, long expected)
    {
        Assert.Equal(expected, Program.NthPrime(n));
    }

    [Theory]
    [InlineData(100, 541L)]
    [InlineData(1_000, 7919L)]
    [InlineData(100_000, 1299709L)]
    public void LargerPositions(int n, long expected)
    {
        Assert.Equal(expected, Program.NthPrime(n));
    }
}
