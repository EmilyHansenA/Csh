using System.Linq;
public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(i => i * 2).ToArray();
    }
}