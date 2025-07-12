using SharedProject.Extension;
using System.Collections.Generic;

namespace Data_strucutures_and_algorithms.Stacks
{
    public partial class Stacks
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (IsOpenBracket(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.IsEmpty())
                    {
                        return false;
                    }
                    else if(IsValidClosing(c, stack))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.IsEmpty();
        }

        public static bool IsValidClosing(char c, Stack<char> stack)
        {
            return (c == ')' && stack.Peek() == '(') ||
            (c == '}' && stack.Peek() == '{') ||
            (c == ']' && stack.Peek() == '[');
        }

        public static bool IsOpenBracket(char c)
        {
            return c is '[' or '{' or '(';
        }
    }
}
