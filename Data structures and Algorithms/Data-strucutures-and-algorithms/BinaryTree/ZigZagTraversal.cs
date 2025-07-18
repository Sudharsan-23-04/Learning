using SharedProject.Extension;

namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static List<List<T>> ZigZagTraversal<T>(BinaryTree<T> root)
        {
            if(root is null)
            {
                return [];
            }

            Queue<BinaryTree<T>> queue = new();

            List<List<T>> result = [];

            int curLevel = 1;

            queue.Enqueue(root);

            while (!queue.IsEmpty())
            {
                var count = queue.Count;

                var curResult = new List<T>();

                for(int i = 0; i < count; i += 1)
                {
                    var cur = queue.Dequeue();

                    curResult.Add(cur.Value);

                    if(cur.Left is not null)
                    {
                        queue.Enqueue(cur.Left);
                    }

                    if(cur.Right is not null)
                    {
                        queue.Enqueue(cur.Right);
                    }
                }

                if(curLevel % 2 == 0)
                {
                    curResult.Reverse();
                }

                result.Add(curResult);

                curLevel++;
            }

            return result;
        }
    }
}
