using EulerProject.Problem008;

namespace EulerProject.Tests;

public class Problem008Tests
{
    [Fact]
    public void ThousandDigitNumber_HasOneThousandDigits()
    {
        Assert.Equal(1000, Program.ThousandDigitNumber.Length);
        Assert.All(Program.ThousandDigitNumber, c => Assert.InRange(c, '0', '9'));
    }

    [Fact]
    public void Example_FourAdjacentDigits_Is5832()
    {
        // 9 * 9 * 8 * 9
        Assert.Equal(5832L, Program.LargestAdjacentDigitsProduct(Program.ThousandDigitNumber, 4));
    }

    [Fact]
    public void Answer_ThirteenAdjacentDigits()
    {
        Assert.Equal(23514624000L, Program.LargestAdjacentDigitsProduct(Program.ThousandDigitNumber, 13));
    }

    [Theory]
    [InlineData("3829", 1, 9L)]
    [InlineData("0", 1, 0L)]
    public void SingleDigitWindow_ReturnsLargestDigit(string digits, int adjacentCount, long expected)
    {
        Assert.Equal(expected, Program.LargestAdjacentDigitsProduct(digits, adjacentCount));
    }

    [Theory]
    [InlineData("1234", 4, 24L)]
    [InlineData("7", 1, 7L)]
    public void WindowCoversWholeInput(string digits, int adjacentCount, long expected)
    {
        Assert.Equal(expected, Program.LargestAdjacentDigitsProduct(digits, adjacentCount));
    }

    [Theory]
    [InlineData("99111", 2, 81L)] // first window
    [InlineData("11199", 2, 81L)] // last window
    [InlineData("11991", 2, 81L)] // middle window
    public void BestWindowPosition(string digits, int adjacentCount, long expected)
    {
        Assert.Equal(expected, Program.LargestAdjacentDigitsProduct(digits, adjacentCount));
    }

    [Fact]
    public void OnlyAdjacentDigitsAreMultiplied()
    {
        // the two 9s are not adjacent
        Assert.Equal(9L, Program.LargestAdjacentDigitsProduct("9119", 2));
    }

    [Theory]
    [InlineData("12305", 2, 6L)]
    [InlineData("9990999", 3, 729L)]
    [InlineData("9909", 3, 0L)]
    [InlineData("0000", 2, 0L)]
    public void ZerosInInput(string digits, int adjacentCount, long expected)
    {
        Assert.Equal(expected, Program.LargestAdjacentDigitsProduct(digits, adjacentCount));
    }

    [Fact]
    public void ProductExceedsInt32()
    {
        // 9^13
        Assert.Equal(2541865828329L, Program.LargestAdjacentDigitsProduct("9999999999999", 13));
    }
}
