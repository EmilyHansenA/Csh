using System;
using System.Collections.Generic;

namespace CheckBrakets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check("(([])[])"));
            Console.WriteLine(Check("((][])"));
            Console.WriteLine(Check("((("));
            Console.WriteLine(Check("(x)"));
        }
        public static bool Check(string str)
        {
            var stack = new Stack<char>();
            foreach (var e in str)
            {
                switch (e)
                {
                    case '[':
                    case '(':
                        stack.Push(e);
                        break;

                    case ']':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '[') return false;
                        break;

                    case ')':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '(') return false;
                        break;
                    default:
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
