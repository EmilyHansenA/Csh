using System.Globalization;

NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
{
    NumberDecimalSeparator = "."
};

#region Convert str1 to int
string str1 = "1";
int num = Convert.ToInt32(str1);
Console.WriteLine(num);
#endregion

#region Convert str2 to double
string str2 = "2.9";
double num2 = Convert.ToDouble(str2, numberFormatInfo);
Console.WriteLine(num2);
#endregion

#region Parse str3 to int
string str3 = "3";
int num3 = int.Parse(str3);
Console.WriteLine(num3);
#endregion

#region Try/catch parse str4 to int
string str4 = "4fdsfds";
try
{
    int num4 = int.Parse(str4);
    Console.WriteLine("Number = " + num4);
}
catch (Exception)
{
    Console.WriteLine("Exception");
}
#endregion

#region TryParse str5 to int with if/else
string str5 = "5sfd";
int num5;
bool result = int.TryParse(str5, out num5);
if (result)
    Console.WriteLine("Number = " + num5);
else Console.WriteLine(result);
#endregion
