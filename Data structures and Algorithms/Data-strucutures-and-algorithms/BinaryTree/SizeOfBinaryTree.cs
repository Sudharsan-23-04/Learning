namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public int GetSize<T>(BinaryTree<T> root)
        {
            if(root is null)
            {
                return 0;
            }

            return 1 + GetSize(root.Left) + GetSize(root.Right);
        }
    }
}
