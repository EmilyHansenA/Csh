static int SumNums(int num1, int num2)
{
    return num1 + num2;
}

static void PrintResult(int result)
{
    Console.WriteLine("Result num1 + num2 = " + result);
}

int result;
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

result = SumNums(num1, num2);
PrintResult(result);