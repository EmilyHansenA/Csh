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