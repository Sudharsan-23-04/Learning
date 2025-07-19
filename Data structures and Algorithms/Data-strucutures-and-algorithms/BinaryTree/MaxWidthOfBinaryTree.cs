using SharedProject.Extension;

namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static int GetMaxWidth<T>(BinaryTree<T> root)
        {
            if(root is null)
            {
                return 0;
            }

            Queue<(BinaryTree<T> node, int index)> queue = [];

            queue.Enqueue((root, 0));

            var maxWidth = int.MinValue;

            while (!queue.IsEmpty())
            {
                var count = queue.Count;

                var (node, start) = queue.Peek();

                var end = start;

                for(var i = 0; i < count; i++)
                {
                    var (cur, index) = queue.Dequeue();

                    end = index;

                    if(cur.Left is not null)
                    {
                        queue.Enqueue((cur.Left, 2 * index));
                    }

                    if(cur.Right is not null)
                    {
                        queue.Enqueue((cur.Right, 2 * index + 1));
                    }
                }

                var width = end - start + 1;

                maxWidth = Math.Max(maxWidth, width);
            }

            return maxWidth;
        }
    }
}
