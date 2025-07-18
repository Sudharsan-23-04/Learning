namespace Data_strucutures_and_algorithms.BinaryTree
{
    public partial class BinaryTreeProblem
    {
        public static void PrintKDistanceNodeFromRoot<T>(BinaryTree<T> root, int distance)
        {
            if(root is null || distance < 0)
            {
                return;
            }

            if(distance == 0)
            {
                Console.WriteLine(root.Value);
            }

            PrintKDistanceNodeFromRoot(root.Left, distance - 1);

            PrintKDistanceNodeFromRoot(root.Right, distance - 1);
        }
    }
}
