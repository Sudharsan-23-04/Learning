namespace Data_strucutures_and_algorithms.Stacks
{
    public partial class Stacks
    {
        //https://leetcode.com/problems/next-greater-element-i/
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            // Map to store next greater element for each number in nums2
            Dictionary<int, int> nextGreaterMap = [];
            Stack<int> stack = new();

            // Traverse nums2 in reverse to build the next greater map
            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                int current = nums2[i];

                // Maintain a decreasing stack
                while (stack.Count > 0 && stack.Peek() <= current)
                {
                    stack.Pop();
                }

                // If stack is not empty, the top is the next greater
                nextGreaterMap[current] = stack.Count > 0 ? stack.Peek() : -1;

                stack.Push(current);
            }

            // Construct result for nums1 using the map
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = nextGreaterMap[nums1[i]];
            }

            return result;
        }

    }
}
