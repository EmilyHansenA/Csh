using System;
using System.Collections.Generic;
using System.Linq;

namespace StackCalculator
{
    public class StackCalculator
    {
        public static int Calculator(string str)
        {
            var stack = new Stack<int>();
            var dic = new Dictionary<char, Func<int, int, int>>();
            dic['+'] = (a, b) => a + b;
            dic['-'] = (a, b) => a - b;
            dic['*'] = (a, b) => a * b;
            dic['/'] = (a, b) => a / b;

            foreach(char symbol in str)
            {
                if(symbol <='9' && '0' <= symbol)
                {
                    stack.Push(symbol - '0');
                    continue;
                }
                else if (dic.Keys.Contains(symbol))
                {
                    var arg1 = stack.Pop();
                    var arg2 = stack.Pop();
                    stack.Push(dic[symbol] (arg1, arg2));
                }
                else throw new Exception("Symbol not defined" + symbol);
            }
            return stack.Pop();
        }
        static void Main(string[] args)
        {
        }
    }
}
