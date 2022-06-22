Random random = new Random();

#region Инициализация двумерного массива в коде {}
int[,] array1 = new int[2, 2]
{
    {1, 2},
    {1, 3},
};

int height = array1.GetLength(0);
int width = array1.GetLength(1);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(array1[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(Environment.NewLine);
#endregion

#region Инициализация двумерного массива рандомно
int[,] array2 = new int[2, 2];

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        array2[i, j] = random.Next(100);
    }
}

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(array2[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(Environment.NewLine);
#endregion