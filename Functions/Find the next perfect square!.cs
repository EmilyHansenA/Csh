using System;
public class Kata
{
    public static long FindNextSquare(long num)
    {
        double res = Math.Sqrt(num);

        if (res % 1 == 0)
        {
            res++;
            res *= res;
            long result = Convert.ToInt64(res);
            return result;
        }

        else return -1;
    }
}