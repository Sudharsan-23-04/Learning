using SharedProject.Extension;

namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static List<T> DistanceKFromTarget<T>(BinaryTree<T> root, BinaryTree<T> target, int distance)
        {
            if (root == null || target == null)
                return [];

            var nodeMap = TreeUtils.BuildNodeMap(root);

            var queue = new Queue<(BinaryTree<T> Node, int Dist)>();
            var visited = new HashSet<BinaryTree<T>>();
            var result = new List<T>();

            queue.Enqueue((target, 0));
            visited.Add(target);

            while (queue.Count > 0)
            {
                var (current, dist) = queue.Dequeue();

                if (dist == distance)
                {
                    result.Add(current.Value);
                    continue;
                }

                if (!nodeMap.TryGetValue(current, out var neighbors))
                    continue;

                foreach (var neighbor in neighbors)
                {
                    if (neighbor is null || visited.Contains(neighbor))
                        continue;

                    visited.Add(neighbor);
                    queue.Enqueue((neighbor, dist + 1));
                }
            }

            return result;
        }
    }
}
