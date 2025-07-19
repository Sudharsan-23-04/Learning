namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public int GetHeight<T>(BinaryTree<T>? root)
        {
            if(root is null)
            {
                return 0;
            }

            return Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1;
        }
    }
}
