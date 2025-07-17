using SharedProject.Extension;

namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public class DistanceKProblem<T>
        {
            private readonly Dictionary<BinaryTree<T>, BinaryTree<T>> _parentMap = [];

            public void BuildParentMap(BinaryTree<T> node, BinaryTree<T>? parent)
            {
                if (node is null)
                {
                    return;
                }

                if (parent is not null)
                {
                    _parentMap.TryAdd(node, parent);
                }

                BuildParentMap(node.Left, node);
                BuildParentMap(node.Right, node);
            }

            public List<T> DistanceKFromTarget(BinaryTree<T> root, BinaryTree<T> target, int distance)
            {
                if (root is null)
                    return [];

                BuildParentMap(root, null);

                Queue<(BinaryTree<T>, int)> queue = [];
                HashSet<BinaryTree<T>> visited = [];
                List<T> result = [];

                // Enqueue target node
                queue.Enqueue((target, 0));
                visited.Add(target);

                while (!queue.IsEmpty())
                {
                    var (current, dist) = queue.Dequeue();

                    if (dist == distance)
                    {
                        result.Add(current.Value);
                    }
                    else if (dist < distance)
                    {
                        foreach (var neighbor in GetNeighbors(current))
                        {
                            if (visited.Add(neighbor))
                            {
                                queue.Enqueue((neighbor, dist + 1));
                            }
                        }
                    }
                }

                return result;
            }

            private IEnumerable<BinaryTree<T>> GetNeighbors(BinaryTree<T> node)
            {
                if (node.Left is not null)
                {
                    yield return node.Left;
                }

                if (node.Right is not null)
                {
                    yield return node.Right;
                }

                if (_parentMap.TryGetValue(node, out var parent))
                {
                    yield return parent;
                }
            }
        }
    }
}
