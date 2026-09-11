using System.IO.Pipelines;

namespace EulerProject.Problem003;

public static class Program
{
    /// <summary>
    /// Returns the largest prime factor of <paramref name="number"/>.
    /// A prime number is its own largest prime factor.
    /// </summary>
    public static long LargestPrimeFactor(long number)
    {
        long largest = 1;
        while(number % 2 == 0)
        {
            largest = 2;
            number /= 2;
        }

        for(long div = 3; div*div <= number; div++)
        {
            while(number % div == 0)
            {
                largest = div;
                number /= div;
            }

        }

        return number > 1 ? number : largest;
    }

}
