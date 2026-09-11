using EulerProject.Problem006;

namespace EulerProject.Tests;

public class Problem006Tests
{
    [Fact]
    public void Example_FirstTen_Is2640()
    {
        // (1 + ... + 10)^2 = 3025, 1^2 + ... + 10^2 = 385
        Assert.Equal(2640L, Program.SumSquareDifference(10));
    }

    [Fact]
    public void Answer_FirstOneHundred()
    {
        Assert.Equal(25164150L, Program.SumSquareDifference(100));
    }

    [Theory]
    [InlineData(0)] // both sums are empty
    [InlineData(1)] // 1^2 - 1^2
    public void NoDifference_ReturnsZero(int n)
    {
        Assert.Equal(0L, Program.SumSquareDifference(n));
    }

    [Theory]
    [InlineData(2, 4L)]  // 3^2 - 5
    [InlineData(3, 22L)] // 6^2 - 14
    public void SmallValues(int n, long expected)
    {
        Assert.Equal(expected, Program.SumSquareDifference(n));
    }

    [Theory]
    [InlineData(1_000, 250166416500L)]
    [InlineData(10_000, 2500166641665000L)]
    public void LargeValues_ResultExceedsInt32(int n, long expected)
    {
        Assert.Equal(expected, Program.SumSquareDifference(n));
    }
}
