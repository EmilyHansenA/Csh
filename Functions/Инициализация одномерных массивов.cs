Random random = new Random();

#region Одномерные массивы

int[] array1 = new int[5];

#region Инициализации массивов

#region Инициализация массива с клавиатуры + вывод его в обратном порядке.
for (int i = 0; i < array1.Length; i++) {
    array1[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Environment.NewLine);
for (int i = array1.Length - 1; i >= 0; i--)
{
    Console.WriteLine(array1[i]);
}
Console.WriteLine(Environment.NewLine);
#endregion

#region Инициализация массива рандомными числами до 100
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = random.Next(100);
}

for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine(array1[i]);
}
Console.WriteLine(Environment.NewLine);
#endregion

#region Инициализация массива числами по порядку по его длине.
array1 = Enumerable.Range(0, 5).ToArray();
foreach (var i in array1)
{
    Console.WriteLine(array1[i]);
}
Console.WriteLine(Environment.NewLine);
#endregion

#region Инициализация массива числами в обратном порядке по его длине.
array1 = Enumerable.Range(0, 5).Reverse().ToArray();
for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine(array1[i]);
}
Console.WriteLine(Environment.NewLine);
#endregion
#endregion
#endregion