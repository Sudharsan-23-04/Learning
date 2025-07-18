using SharedProject.Extension;

namespace Data_strucutures_and_algorithms.Stacks
{
    public partial class Stacks
    {
        public static string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (!stack.IsEmpty() && stack.Peek() == c)
                {
                    stack.Pop(); 
                }
                else
                {
                    stack.Push(c);
                }
            }

            var result = new string([.. stack.Reverse()]);
            return result;
        }

    }
}
