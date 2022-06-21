using System.Linq;
public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(i => i * 2).ToArray();
    }
}

/*
[1, 2, 3] --> [2, 4, 6]
Каждый элемент массива возводит в квадрат.
*/
