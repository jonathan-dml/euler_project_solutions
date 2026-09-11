namespace EulerProject.Problem001;

public static class Program
{
    /// <summary>
    /// Returns the sum of all natural numbers strictly below <paramref name="limit"/>
    /// that are multiples of 3 or 5. Numbers that are multiples of both are counted once.
    /// </summary>
    public static long SumOfMultiplesOf3Or5Below(int limit)
    {
        long sum = 0;
        for(int n = 3; n < limit; n++)
        {
            if(n % 3 == 0 || n % 5 == 0)
            {
                sum += n;
            }
        }
        return sum;
    }
}
