namespace Data_strucutures_and_algorithms.BinaryTree
{
    public class BinaryTreeTraversal<T>
    {
        public void InOrderTravesal(BinaryTree<T> root)
        {
            if(root is null)
            {
                return;
            }

            InOrderTravesal(root.Left);

            Console.WriteLine(root.Value);

            InOrderTravesal(root.Right);
        }

        public void PreOrderTravesal(BinaryTree<T> root)
        {
            if (root is null)
            {
                return;
            }
            Console.WriteLine(root.Value);

            InOrderTravesal(root.Left);

            InOrderTravesal(root.Right);
        }

        public void PostOrderTravesal(BinaryTree<T> root)
        {
            if (root is null)
            {
                return;
            }

            InOrderTravesal(root.Left);

            InOrderTravesal(root.Right);

            Console.WriteLine(root.Value);
        }
    }
}
