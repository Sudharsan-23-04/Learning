namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public class DiameterOfBinaryTree
        {
            private int _diameter = 0;

            public int GetDiameter<T>(BinaryTree<T>? root)
            {
                ComputeHeight(root); 
                return _diameter;
            }

            private int ComputeHeight<T>(BinaryTree<T>? node)
            {
                if (node is null)
                {
                    return 0;
                }

                int leftHeight = ComputeHeight(node.Left);
                int rightHeight = ComputeHeight(node.Right);

                // Update diameter at this node
                int localDiameter = leftHeight + rightHeight + 1;
                _diameter = Math.Max(_diameter, localDiameter);

                // Return height to parent call
                return 1 + Math.Max(leftHeight, rightHeight);
            }
        }



    }
}
