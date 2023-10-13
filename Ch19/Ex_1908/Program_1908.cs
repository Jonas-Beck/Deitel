using Ex_1908.Classes;

namespace Ex_1908
{
    internal class Program_1908
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] intArray = { 27, 13, 6, 17, 42, 33, 48 };

            Console.Write("Inserting Values: ");
            foreach (int i in intArray)
            {
                tree.InsertNode(i);
                Console.Write($"{i} ");
            }


            Console.Write("\nLevelorder Traversal: ");
            tree.LevelOrderTraversal();

        }
    }
}