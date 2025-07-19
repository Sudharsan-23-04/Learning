namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {

        public class BurnALeafNode<T>
        {
            private readonly Dictionary<BinaryTree<T>, BinaryTree<T>> _parentMap = [];

            public void BuildParentMap(BinaryTree<T>? node, BinaryTree<T>? parent)
            {
                if (node is null)
                    return;

                if (parent is not null)
                    _parentMap.TryAdd(node, parent);

                BuildParentMap(node.Left, node);
                BuildParentMap(node.Right, node);
            }

            private IEnumerable<BinaryTree<T>> GetUnvisitedNeighbors(BinaryTree<T> node, HashSet<BinaryTree<T>> visited)
            {
                if (node.Left is not null && !visited.Contains(node.Left))
                {
                    yield return node.Left;
                }

                if (node.Right is not null && !visited.Contains(node.Right))
                {
                    yield return node.Right;
                }

                if (_parentMap.TryGetValue(node, out var parent) && !visited.Contains(parent))
                {
                    yield return parent;
                }
            }

            public int BurnALeafNodeTime(BinaryTree<T> root, BinaryTree<T> leaf)
            {
                ArgumentNullException.ThrowIfNull(root, nameof(root));
                ArgumentNullException.ThrowIfNull(leaf, nameof(leaf));

                BuildParentMap(root, null);

                Queue<(BinaryTree<T> node, int time)> queue = [];
                HashSet<BinaryTree<T>> visited = [];

                queue.Enqueue((leaf, 0));
                visited.Add(leaf);

                int maxTime = 0;

                while (queue.Count > 0)
                {
                    var (node, time) = queue.Dequeue();

                    maxTime = Math.Max(maxTime, time);

                    foreach (var neighbor in GetUnvisitedNeighbors(node, visited))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue((neighbor, time + 1));
                    }
                }

                return maxTime;
            }
        }




    }
}
