using SharedProject.Extension;

namespace Data_strucutures_and_algorithms.Stacks
{
    public partial class Stacks
    {
        //https://leetcode.com/problems/largest-rectangle-in-histogram/
        public static int LargestRectangleArea(int[] heights)
        {
            var stack = new Stack<int>();
            int max = int.MinValue;
            for(int i = 0; i < heights.Length; i++)
            {
                while (!stack.IsEmpty() && heights[stack.Peek()] >= heights[i])
                {
                    var cur = stack.Pop();
                    int width = stack.IsEmpty() ? i : i - stack.Peek() - 1;
                    var res = heights[cur] * width;
                    max = Math.Max(max, res);
                }
                stack.Push(i);
            }

            while (!stack.IsEmpty())
            {
                var cur = stack.Pop();
                int width = stack.IsEmpty() ? heights.Length : heights.Length - stack.Peek() - 1;
                var res = heights[cur] * width;
                max = Math.Max(max, res);
            }
            return max;
        }
    }
}
