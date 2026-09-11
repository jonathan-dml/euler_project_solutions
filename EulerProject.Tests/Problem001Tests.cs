using EulerProject.Problem001;

namespace EulerProject.Tests;

public class Problem001Tests
{
    [Fact]
    public void Example_MultiplesBelow10_SumTo23()
    {
        Assert.Equal(23L, Program.SumOfMultiplesOf3Or5Below(10));
    }

    [Fact]
    public void Answer_MultiplesBelow1000()
    {
        Assert.Equal(233168L, Program.SumOfMultiplesOf3Or5Below(1000));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)] // 3 itself is not below 3
    public void NoMultiplesBelowLimit_ReturnsZero(int limit)
    {
        Assert.Equal(0L, Program.SumOfMultiplesOf3Or5Below(limit));
    }

    [Theory]
    [InlineData(4, 3L)]
    [InlineData(5, 3L)]   // 5 is not below 5
    [InlineData(6, 8L)]   // 3 + 5
    [InlineData(7, 14L)]  // 3 + 5 + 6
    [InlineData(11, 33L)] // 3 + 5 + 6 + 9 + 10
    public void LimitIsExclusive(int limit, long expected)
    {
        Assert.Equal(expected, Program.SumOfMultiplesOf3Or5Below(limit));
    }

    [Theory]
    [InlineData(15, 45L)]  // 3 + 5 + 6 + 9 + 10 + 12
    [InlineData(16, 60L)]  // 15 is a multiple of both 3 and 5
    [InlineData(31, 225L)] // 15 and 30 are multiples of both 3 and 5
    public void MultiplesOfBoth3And5_AreCountedOnce(int limit, long expected)
    {
        Assert.Equal(expected, Program.SumOfMultiplesOf3Or5Below(limit));
    }

    [Fact]
    public void LargeLimit_ResultExceedsInt32()
    {
        Assert.Equal(2333316668L, Program.SumOfMultiplesOf3Or5Below(100_000));
    }
}
