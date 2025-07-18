namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static long GetMax(BinaryTree<long> root) 
        {
            if(root is null)
            {
                return long.MinValue;
            }

            return 1 + GetMax(root.Left) + GetMax(root.Right);
        }
    }
}
