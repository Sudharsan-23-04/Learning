namespace Data_strucutures_and_algorithms.Stacks
{
    public partial class Stacks
    {
        //https://leetcode.com/problems/maximal-rectangle/description/
        public static int MaximalRectangle(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return 0;

            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[] heights = new int[cols];
            int max = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r][c] == '1')
                        heights[c] += 1;
                    else
                        heights[c] = 0;
                }

                max = Math.Max(max, LargestRectangleArea(heights));
            }

            return max;
        }

    }
}
