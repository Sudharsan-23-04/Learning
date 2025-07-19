namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public interface IConvertBinaryTree<T>
        {
            BinaryTree<T>? Convert(BinaryTree<T>? root);
        }
        public class InOrderBinaryTreeToDLL<T> : IConvertBinaryTree<T>
        {
            private BinaryTree<T>? _prev = null;
            private BinaryTree<T>? _head = null;

            public BinaryTree<T>? Convert(BinaryTree<T>? root)
            {
                _prev = null;
                _head = null;

                ConvertInOrder(root);

                return _head;
            }

            private void ConvertInOrder(BinaryTree<T>? node)
            {
                if (node is null)
                {
                    return;
                }

                // Left
                ConvertInOrder(node.Left);

                // Process current node
                if (_prev is null)
                {
                    _head = node; 
                }
                else
                {
                    _prev.SetRightChild(node);  
                    node.SetLeftChild(_prev);
                }

                _prev = node;

                // Right
                ConvertInOrder(node.Right);
            }
        }

    }
}
