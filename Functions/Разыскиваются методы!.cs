static string GetLastHalf(string text)
{
    text = text.Substring(text.Length / 2);
    string s = text.Replace(" ", String.Empty);
    return s;
}

Console.WriteLine(GetLastHalf("I love CSharp!"));
Console.WriteLine(GetLastHalf("1234567890"));
Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));