using EulerProject.Problem004;

namespace EulerProject.Tests;

public class Problem004Tests
{
    [Fact]
    public void Example_TwoDigitNumbers_Is9009()
    {
        // 9009 = 91 * 99
        Assert.Equal(9009L, Program.LargestPalindromeProduct(2));
    }

    [Fact]
    public void Answer_ThreeDigitNumbers()
    {
        Assert.Equal(906609L, Program.LargestPalindromeProduct(3));
    }

    [Fact]
    public void OneDigitNumbers_SingleDigitProductIsAPalindrome()
    {
        // 81, 72, 64, ... are not palindromes; 9 = 1 * 9 = 3 * 3 is
        Assert.Equal(9L, Program.LargestPalindromeProduct(1));
    }

    [Fact]
    public void FourDigitNumbers()
    {
        // 99000099 = 9901 * 9999
        Assert.Equal(99000099L, Program.LargestPalindromeProduct(4));
    }
}
