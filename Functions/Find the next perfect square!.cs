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

/*
121 --> 144
625 --> 676
114 --> -1 since 114 is not a perfect square

Находит у первого числа корень, потом высчитывает у следующего числа от корня квадрат.
*/
