using SharedProject.Extension;

namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static List<List<T>> ZigZagTraversal<T>(BinaryTree<T>? root)
        {
            var result = new List<List<T>>();
            if (root is null)
                return result;

            Stack<BinaryTree<T>> s1 = new(); // Left to Right
            Stack<BinaryTree<T>> s2 = new(); // Right to Left

            s1.Push(root);

            while (s1.Count > 0 || s2.Count > 0)
            {
                var level = new List<T>();

                // Process s1: Left → Right
                while (s1.Count > 0)
                {
                    var node = s1.Pop();
                    level.Add(node.Value);

                    // Push children: left first, then right (reversed in stack)
                    if (node.Left is not null)
                    {
                        s2.Push(node.Left);
                    }

                    if (node.Right is not null)
                    {
                        s2.Push(node.Right);
                    }
                }

                if (level.Count > 0)
                {
                    result.Add(level);
                }

                level = [];

                // Process s2: Right → Left
                while (s2.Count > 0)
                {
                    var node = s2.Pop();
                    level.Add(node.Value);

                    // Push children: right first, then left (reversed in stack)
                    if (node.Right is not null)
                    {
                        s1.Push(node.Right);
                    }

                    if (node.Left is not null)
                    {
                        s1.Push(node.Left);
                    }
                }

                if (level.Count > 0)
                {
                    result.Add(level);
                }
            }

            return result;
        }


    }
}
