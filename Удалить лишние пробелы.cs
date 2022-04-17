using System;
using System.Collections.Generic;


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            while (s.Contains("  ")) {
                s = s.Replace("  ", " "); 
            }

            Console.WriteLine(s);
        }
    }
}
