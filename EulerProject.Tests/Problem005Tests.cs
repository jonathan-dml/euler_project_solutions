using EulerProject.Problem005;

namespace EulerProject.Tests;

public class Problem005Tests
{
    [Fact]
    public void Example_OneToTen_Is2520()
    {
        Assert.Equal(2520L, Program.SmallestMultiple(10));
    }

    [Fact]
    public void Answer_OneToTwenty()
    {
        Assert.Equal(232792560L, Program.SmallestMultiple(20));
    }

    [Theory]
    [InlineData(1, 1L)]
    [InlineData(2, 2L)]
    [InlineData(3, 6L)]
    public void SmallRanges(int n, long expected)
    {
        Assert.Equal(expected, Program.SmallestMultiple(n));
    }

    [Theory]
    [InlineData(4, 12L)]   // not 1 * 2 * 3 * 4 = 24
    [InlineData(5, 60L)]
    [InlineData(6, 60L)]   // 6 = 2 * 3 adds no new factor
    [InlineData(7, 420L)]
    [InlineData(8, 840L)]  // 8 = 2^3 needs one more 2
    [InlineData(9, 2520L)] // 9 = 3^2 needs one more 3
    public void ResultIsSmallestCommonMultiple_NotProduct(int n, long expected)
    {
        Assert.Equal(expected, Program.SmallestMultiple(n));
    }

    [Theory]
    [InlineData(21)] // 21 = 3 * 7
    [InlineData(22)] // 22 = 2 * 11
    public void NumbersWithoutNewFactors_DoNotChangeResult(int n)
    {
        Assert.Equal(232792560L, Program.SmallestMultiple(n));
    }

    [Fact]
    public void ResultExceedsInt32()
    {
        Assert.Equal(5354228880L, Program.SmallestMultiple(23));
    }
}
