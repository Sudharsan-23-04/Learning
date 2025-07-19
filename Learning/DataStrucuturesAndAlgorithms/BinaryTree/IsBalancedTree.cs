namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static bool IsBalancedTree<T>(BinaryTree<T>? root)
        {
            return CheckHeight(root) != -1;
        }

        private static int CheckHeight<T>(BinaryTree<T>? node)
        {
            if (node == null)
            {
                return 0;
            }

            int lh = CheckHeight(node.Left);
            if (lh == -1) return -1;

            int rh = CheckHeight(node.Right);
            if (rh == -1) return -1;

            if (Math.Abs(lh - rh) > 1)
            {
                return -1;
            }

            return Math.Max(lh, rh) + 1;
        }
    }
}
