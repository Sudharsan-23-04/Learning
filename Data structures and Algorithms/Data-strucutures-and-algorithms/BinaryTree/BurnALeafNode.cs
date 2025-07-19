namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {

        public class BurnALeafNode<T>
        {
            public int BurnALeafNodeTime(BinaryTree<T> root, BinaryTree<T> leaf)
            {
                ArgumentNullException.ThrowIfNull(root);
                ArgumentNullException.ThrowIfNull(leaf);

                var nodeMap = TreeUtils.BuildNodeMap(root);

                var queue = new Queue<(BinaryTree<T> Node, int Time)>();
                var visited = new HashSet<BinaryTree<T>>();

                queue.Enqueue((leaf, 0));
                visited.Add(leaf);

                int maxTime = 0;

                while (queue.Count > 0)
                {
                    var (node, time) = queue.Dequeue();
                    maxTime = Math.Max(maxTime, time);

                    if (!nodeMap.TryGetValue(node, out var neighbors))
                        continue;

                    foreach (var neighbor in neighbors)
                    {
                        if (neighbor == null || visited.Contains(neighbor))
                            continue;

                        visited.Add(neighbor);
                        queue.Enqueue((neighbor, time + 1));
                    }
                }

                return maxTime;
            }
        }
    }
}
