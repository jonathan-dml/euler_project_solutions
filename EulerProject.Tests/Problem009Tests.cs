using EulerProject.Problem009;

namespace EulerProject.Tests;

public class Problem009Tests
{
    [Fact]
    public void Example_3_4_5_SumsTo12()
    {
        Assert.Equal(60L, Program.SpecialPythagoreanTripletProduct(12));
    }

    [Fact]
    public void Answer_SumOf1000()
    {
        Assert.Equal(31875000L, Program.SpecialPythagoreanTripletProduct(1000));
    }

    [Theory]
    [InlineData(30, 780L)]  // 5, 12, 13
    [InlineData(40, 2040L)] // 8, 15, 17
    [InlineData(56, 4200L)] // 7, 24, 25
    public void UniquePrimitiveTriplet(int sum, long expected)
    {
        Assert.Equal(expected, Program.SpecialPythagoreanTripletProduct(sum));
    }

    [Theory]
    [InlineData(24, 480L)]  // 6, 8, 10
    [InlineData(36, 1620L)] // 9, 12, 15
    public void UniqueNonPrimitiveTriplet(int sum, long expected)
    {
        Assert.Equal(expected, Program.SpecialPythagoreanTripletProduct(sum));
    }
}
