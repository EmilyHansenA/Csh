Random random = new Random();

#region Инициализация двумерного массива в коде {}
int[,] array1 = new int[2, 2]
{
    {1, 2},
    {1, 3},
};

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(Environment.NewLine);
#endregion

#region Инициализация двумерного массива рандомно
int[,] array2 = new int[2, 2];

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = random.Next(100);
    }
}

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write(array2[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(Environment.NewLine);
#endregion