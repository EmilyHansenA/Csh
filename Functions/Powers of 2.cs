using System;
using System.Linq;
using System.Numerics;
public class Kata
{
    public static BigInteger[] PowersOfTwo(int n)
    {
        return Enumerable.Range(0, ++n).Select(num => new BigInteger(Math.Pow(2, num))).ToArray();
    }
}

/*
n = 0  ==> [1]        # [2^0]
n = 1  ==> [1, 2]     # [2^0, 2^1]
n = 2  ==> [1, 2, 4]  # [2^0, 2^1, 2^2]

Инициализирует массив степенями двойки.
*/
