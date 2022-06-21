int num = Convert.ToInt32(Console.ReadLine());

string output = num < 0 ? "Negative. Number = " + Convert.ToString(num) :
    "Positive. Number = " + Convert.ToString(num);

Console.WriteLine(output);