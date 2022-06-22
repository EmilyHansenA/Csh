int[] array1 = new int[5] { 1, 1, 24, 5, 91 };

//Оригинальные элементы массива
int[] result1 = array1.Distinct().ToArray();
for (int i = 0; i < result1.Length; i++)
{
    Console.WriteLine(result1[i]);
}
Console.WriteLine(Environment.NewLine);

//Сортировка массива по возрастанию
int[] result2 = array1.OrderBy(i => i).ToArray();
for (int i = 0; i < result2.Length; i++)
{
    Console.WriteLine(result2[i]);
}
Console.WriteLine(Environment.NewLine);

//Сумма четных элементов массива
Console.WriteLine(array1.Where(i => i % 2 == 0).Sum());
Console.WriteLine(Environment.NewLine);

//Найти первый элемент массива меньше 70
int result3 = Array.Find(array1, i => i < 70);
Console.WriteLine(result3);
Console.WriteLine(Environment.NewLine);
