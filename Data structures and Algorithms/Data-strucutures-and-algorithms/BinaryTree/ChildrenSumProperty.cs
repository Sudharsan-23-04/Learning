namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static bool IsChilderSumProperty(BinaryTree<int>? root)
        {
            if (root is null || root.IsLeaf)
            {
                return true;
            }


            int leftValue = root.Left?.Value ?? 0;
            int rightValue = root.Right?.Value ?? 0;

            bool isChilderSumProperty = root.Value == leftValue + rightValue;

            return isChilderSumProperty && IsChilderSumProperty(root.Left) && IsChilderSumProperty(root.Right);
        }
    }
}
