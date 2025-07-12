using SharedProject.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strucutures_and_algorithms.Stacks
{
    public partial class Stacks
    {
        //https://leetcode.com/problems/basic-calculator/description/
        public static int Calculate(string s)
        {
            Stack<int> stack = new();
            int result = 0;
            int number = 0;
            int sign = 1;
            for (int i = 0; i < s.Length; i++)
            {
                var cur = s[i];

                if (char.IsDigit(cur))
                {
                    number = number * 10 + cur.ToInt();
                }

                else if (s[i] is '+' or '-')
                {
                    result += sign * number;
                    sign = s[i] is '+' ? 1 : -1;
                    number = 0;
                }

                else if (s[i] is '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    result = 0;
                    sign = 1;
                }

                else if (s[i] is ')')
                {
                    result += sign * number;
                    number = 0;
                    result *= stack.Pop();
                    result += stack.Pop();
                }
            }

            return result + sign * number;
        }
    }
}
