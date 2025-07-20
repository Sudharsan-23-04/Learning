using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public BinaryTree<T>? LeastCommonAncestor<T>(BinaryTree<T>? root, T n1, T n2)
        {
            if (root is null)
            {
                return null;
            }

            var isEqualToN1 = EqualityComparer<T>.Default.Equals(root.Value, n1);
            var isEqualToN2 = EqualityComparer<T>.Default.Equals(root.Value, n2);

            if (isEqualToN1 || isEqualToN2)
            {
                return root;
            }

            var leftNode = LeastCommonAncestor(root.Left, n1, n2);
            var rightNode = LeastCommonAncestor(root.Right, n1, n2);

            if (leftNode is not null && rightNode is not null)
            {
                return root;
            }

            return leftNode ?? rightNode;
        }

    }
}
