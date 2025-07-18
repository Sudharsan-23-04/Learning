using SharedProject.Extension;

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

        public void LevelOrderTravesal(BinaryTree<T> root)
        {
            if(root is null)
            {
                return;
            }

            Queue<BinaryTree<T>> queue = [];

            queue.Enqueue(root);

            while (!queue.IsEmpty())
            {
                var cur = queue.Dequeue();

                Console.WriteLine(cur.Value);

                if(cur.Left is not null)
                {
                    queue.Enqueue(cur.Left);
                }

                if(cur.Right is not null)
                {
                    queue.Enqueue(cur.Right);
                }
            }
        }

        public void LevelOrderTravesalLineByLine(BinaryTree<T> root)
        {
            if (root is null)
            {
                return;
            }

            Queue<BinaryTree<T>> queue = [];

            queue.Enqueue(root);

            while (!queue.IsEmpty())
            {
                var count = queue.Count;

                List<T> level = [];

                for(int i =0; i < count; i += 1)
                {
                    var cur = queue.Dequeue();

                    level.Add(cur.Value);

                    if(cur.Left is not null)
                    {
                        queue.Enqueue(cur.Left);
                    }

                    if (cur.Right is not null)
                    {
                        queue.Enqueue(cur.Right);
                    }
                }

                Console.WriteLine(string.Join(",", level));
            }
        }
    }
}
