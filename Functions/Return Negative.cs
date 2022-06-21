using System;
public static class Kata
{
    public static int MakeNegative(int number)
    {
        return number > 0 ? -number : number;
    }
}

/* 
Принимает число. Сравнивает с нулем. 
Если отрицательное, то возвращает число. 
Если положительное, то возвращает отрицательное.
*/
