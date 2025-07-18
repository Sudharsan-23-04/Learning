namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        //https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/description/
        public static IList<IList<int>> VerticalTraversal(BinaryTree<int> root)
        {
            if (root is null)
                return [];

            Dictionary<int, List<(int level, int val)>> columnMap = [];

            Queue<(BinaryTree<int> node, int hd, int level)> queue = new();
            queue.Enqueue((root, 0, 0));

            int minHd = 0, maxHd = 0;

            while (queue.Count > 0)
            {
                var (node, hd, level) = queue.Dequeue();

                if (!columnMap.TryGetValue(hd, out List<(int level, int val)>? value))
                {
                    value = [];
                    columnMap[hd] = value;
                }

                value.Add((level, node.Value));

                minHd = Math.Min(minHd, hd);
                maxHd = Math.Max(maxHd, hd);

                if (node.Left is not null)
                {
                    queue.Enqueue((node.Left, hd - 1, level + 1));
                }

                if (node.Right is not null)
                {
                    queue.Enqueue((node.Right, hd + 1, level + 1));
                }
            }

            var result = new List<IList<int>>();

            for (int hd = minHd; hd <= maxHd; hd++)
            {
                var entries = columnMap[hd];

                entries.Sort((a, b) =>
                {
                    if (a.level != b.level)
                    {
                        return a.level.CompareTo(b.level);
                    }

                    return a.val.CompareTo(b.val);
                });

                result.Add([.. entries.Select(e => e.val)]);
            }

            return result;
        }


    }
}
