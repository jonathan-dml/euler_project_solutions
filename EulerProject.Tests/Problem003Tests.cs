using EulerProject.Problem003;

namespace EulerProject.Tests;

public class Problem003Tests
{
    [Fact]
    public void Example_13195_Is29()
    {
        // 13195 = 5 * 7 * 13 * 29
        Assert.Equal(29L, Program.LargestPrimeFactor(13195));
    }

    [Fact]
    public void Answer_600851475143()
    {
        Assert.Equal(6857L, Program.LargestPrimeFactor(600851475143));
    }

    [Theory]
    [InlineData(2L)]
    [InlineData(3L)]
    [InlineData(5L)]
    [InlineData(29L)]
    [InlineData(104729L)]
    [InlineData(1000000007L)]
    public void PrimeNumber_IsItsOwnLargestPrimeFactor(long prime)
    {
        Assert.Equal(prime, Program.LargestPrimeFactor(prime));
    }

    [Theory]
    [InlineData(4L, 2L)]
    [InlineData(8L, 2L)]
    [InlineData(1024L, 2L)]
    [InlineData(9L, 3L)]
    [InlineData(81L, 3L)]
    [InlineData(49L, 7L)]
    [InlineData(121L, 11L)]
    [InlineData(999966000289L, 999983L)] // 999983^2
    public void PowerOfAPrime_ReturnsThatPrime(long number, long expected)
    {
        Assert.Equal(expected, Program.LargestPrimeFactor(number));
    }

    [Theory]
    [InlineData(14L, 7L)]
    [InlineData(26L, 13L)]
    [InlineData(2000000014L, 1000000007L)] // 2 * 1000000007
    public void LargestFactorAboveSquareRoot_IsFound(long number, long expected)
    {
        Assert.Equal(expected, Program.LargestPrimeFactor(number));
    }

    [Theory]
    [InlineData(6L, 3L)]
    [InlineData(12L, 3L)]   // 2^2 * 3
    [InlineData(360L, 5L)]  // 2^3 * 3^2 * 5
    [InlineData(1001L, 13L)] // 7 * 11 * 13
    public void RepeatedAndMixedFactors(long number, long expected)
    {
        Assert.Equal(expected, Program.LargestPrimeFactor(number));
    }

    [Fact]
    public void Int64MaxValue()
    {
        // 9223372036854775807 = 7^2 * 73 * 127 * 337 * 92737 * 649657
        Assert.Equal(649657L, Program.LargestPrimeFactor(long.MaxValue));
    }
}
