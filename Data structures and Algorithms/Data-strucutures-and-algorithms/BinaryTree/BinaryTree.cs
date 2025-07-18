using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTree<T>
    {
        public T Value { get; private set; }

        public BinaryTree<T>? Left { get; private set; }

        public BinaryTree<T>? Right {  get; private set; }

        public BinaryTree(T value)
        {
            Value = value;
        }

        public BinaryTree(T value, BinaryTree<T>? left = null, BinaryTree<T>? right = null)
        {
            Value = value;
            if(left is not null)
            {
                Left = left;
            }
            if(right is not null)
            {
                Right = right;
            }
        }

        public bool IsLeaf => Left is null && Right is null;

        public void SwapChildren()
        {
            (Right, Left) = (Left, Right);
        }

    }
}
