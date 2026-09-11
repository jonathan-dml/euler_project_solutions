using EulerProject.Problem010;

namespace EulerProject.Tests;

public class Problem010Tests
{
    [Fact]
    public void Example_PrimesBelow10_SumTo17()
    {
        // 2 + 3 + 5 + 7
        Assert.Equal(17L, Program.SumOfPrimesBelow(10));
    }

    [Fact]
    public void Answer_PrimesBelowTwoMillion()
    {
        Assert.Equal(142913828922L, Program.SumOfPrimesBelow(2_000_000));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)] // 2 itself is not below 2
    public void NoPrimesBelowLimit_ReturnsZero(int limit)
    {
        Assert.Equal(0L, Program.SumOfPrimesBelow(limit));
    }

    [Theory]
    [InlineData(3, 2L)]
    [InlineData(4, 5L)]
    [InlineData(5, 5L)]   // 5 is not below 5
    [InlineData(6, 10L)]
    [InlineData(11, 17L)] // 11 is not below 11
    [InlineData(12, 28L)]
    public void LimitIsExclusive(int limit, long expected)
    {
        Assert.Equal(expected, Program.SumOfPrimesBelow(limit));
    }

    [Theory]
    [InlineData(26, 100L)] // 1, 9 and 25 are not primes
    [InlineData(30, 129L)]
    public void NonPrimes_AreNotSummed(int limit, long expected)
    {
        Assert.Equal(expected, Program.SumOfPrimesBelow(limit));
    }

    [Theory]
    [InlineData(100, 1060L)]
    [InlineData(1_000, 76127L)]
    public void LargerLimits(int limit, long expected)
    {
        Assert.Equal(expected, Program.SumOfPrimesBelow(limit));
    }
}
