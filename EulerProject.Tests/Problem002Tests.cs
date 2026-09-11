using EulerProject.Problem002;

namespace EulerProject.Tests;

public class Problem002Tests
{
    [Fact]
    public void Example_FirstTenTerms_EvenTermsSumTo44()
    {
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 -> 2 + 8 + 34
        Assert.Equal(44L, Program.SumOfEvenFibonacciNotExceeding(89));
    }

    [Fact]
    public void Answer_TermsNotExceedingFourMillion()
    {
        Assert.Equal(4613732L, Program.SumOfEvenFibonacciNotExceeding(4_000_000));
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(1L)] // the sequence starts with 1, 2: 1 is odd
    public void NoEvenTermsWithinLimit_ReturnsZero(long limit)
    {
        Assert.Equal(0L, Program.SumOfEvenFibonacciNotExceeding(limit));
    }

    [Theory]
    [InlineData(2L, 2L)]
    [InlineData(8L, 10L)]
    [InlineData(34L, 44L)]
    [InlineData(144L, 188L)]
    public void TermEqualToLimit_IsIncluded(long limit, long expected)
    {
        Assert.Equal(expected, Program.SumOfEvenFibonacciNotExceeding(limit));
    }

    [Theory]
    [InlineData(7L, 2L)]
    [InlineData(33L, 10L)]
    [InlineData(143L, 44L)]
    public void TermAboveLimit_IsExcluded(long limit, long expected)
    {
        Assert.Equal(expected, Program.SumOfEvenFibonacciNotExceeding(limit));
    }

    [Theory]
    [InlineData(3L, 2L)]
    [InlineData(5L, 2L)]
    [InlineData(13L, 10L)]
    [InlineData(21L, 10L)]
    [InlineData(89L, 44L)]
    public void OddTerms_AreNotSummed(long limit, long expected)
    {
        Assert.Equal(expected, Program.SumOfEvenFibonacciNotExceeding(limit));
    }

    [Fact]
    public void LargeLimit_ResultExceedsInt32()
    {
        Assert.Equal(478361013020L,Program.SumOfEvenFibonacciNotExceeding(1_000_000_000_000));
    }
}
