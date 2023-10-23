namespace Ex_2012
{
    internal class Program_2012
    {
        static void Main(string[] args)
        {
            int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.10 };
            string[] stringElements = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

            var intTree = new Tree<int>();
            var doubleTree = new Tree<double>();
            var stringTree = new Tree<string>();

            Console.WriteLine("Insert items into tree");

            for (int i = 0; i < 10; i++)
            {
                intTree.InsertNode(intElements[i]);
                doubleTree.InsertNode(doubleElements[i]);
                stringTree.InsertNode(stringElements[i]);
            }

            DisplayTree(intTree, "intTree");
            DisplayTree(doubleTree, "doubleTree");
            DisplayTree(stringTree, "stringTree");

        }

        static void DisplayTree<T>(Tree<T> tree, string name) where T : IComparable<T>
        {
            Console.WriteLine($"\n{name} Data:");
            Console.WriteLine("\nPreorder Traversal:");
            tree.PreorderTraversal();
            Console.WriteLine("\nInorder Traversal:");
            tree.InorderTraversal();
            Console.WriteLine("\nPostOrder Traversal:");
            tree.PostorderTraversal();

        }
    }
}