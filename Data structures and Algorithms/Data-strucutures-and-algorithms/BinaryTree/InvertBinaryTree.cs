using SharedProject.Extension;

namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static BinaryTree<T>? InvertTree<T>(BinaryTree<T>? root)
        {
            if(root is null)
            {
                return null;
            }

            Queue<BinaryTree<T>> queue = [];

            queue.Enqueue(root);

            while (!queue.IsEmpty())
            {
                var cur = queue.Dequeue();

                cur.SwapChildren();

                if(cur.Left is not null)
                {
                    queue.Enqueue(cur.Left);
                }

                if(cur.Right is not null)
                {
                    queue.Enqueue(cur.Right);
                }
            }

            return root;
        }
    }
}
