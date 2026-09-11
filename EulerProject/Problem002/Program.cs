namespace EulerProject.Problem002;

public static class Program
{
    /// <summary>
    /// Returns the sum of the even-valued terms of the Fibonacci sequence 1, 2, 3, 5, 8, ...
    /// whose values do not exceed <paramref name="limit"/> (the limit is inclusive).
    /// </summary>
    public static long SumOfEvenFibonacciNotExceeding(long limit)
    {
        long nMinus1 = 0;
        long nMinus2 = 1;
        long n = 0;
        long sum = 0;
        while((n = nMinus1 + nMinus2) <= limit)
        {
            if(n % 2 == 0)
                sum += n;

            nMinus2 = nMinus1;
            nMinus1 = n;
        }
        return sum;
    }
}
