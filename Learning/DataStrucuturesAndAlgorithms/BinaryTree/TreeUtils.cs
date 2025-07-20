namespace Data_strucutures_and_algorithms.BinaryTree
{
    public static class TreeUtils
    {
        public static Dictionary<BinaryTree<T>, List<BinaryTree<T>?>> BuildNodeMap<T>(BinaryTree<T>? root)
        {
            var map = new Dictionary<BinaryTree<T>, List<BinaryTree<T>?>>();
            Build(root, null, map);
            return map;
        }

        private static void Build<T>(
            BinaryTree<T>? node,
            BinaryTree<T>? parent,
            Dictionary<BinaryTree<T>, List<BinaryTree<T>?>> map)
        {
            if (node is null)
            {
                return;
            }

            map[node] = [node.Left, node.Right, parent];

            Build(node.Left, node, map);
            Build(node.Right, node, map);
        }
    }
}
