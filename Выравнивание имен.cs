using System;
using System.Collections.Generic;


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Sarah", " Some", "   Brpas" };

            Console.WriteLine("Имена разной длины: ");

            foreach (string s in names)
            {
                Console.WriteLine("Имя " + s + " до обработки.");
            }

            List<string> stringToAling = new List<string>();

            for (int i = 0; i < names.Count; i++)
            {
                string TrimmedNames = names[i].Trim();
                stringToAling.Add(TrimmedNames);
            }

            int maxLenght = 0;

            foreach (string s in stringToAling)
            {
                if (s.Length > maxLenght)
                    maxLenght = s.Length;
            }

            for (int i = 0; i < stringToAling.Count; i++)
            {
                stringToAling[i] = stringToAling[i].PadRight(maxLenght + 1);
            }

            Console.WriteLine("Выровненные имена: ");

            foreach (string s in stringToAling)
            {
                Console.WriteLine(s);
            }
        }
    }
}
