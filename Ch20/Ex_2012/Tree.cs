namespace Ex_2012
{
    internal class Tree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        // Insert a new node in the binary search tree.
        // If the root node is null, create the root node here.
        // Otherwise, call the insert method of class TreeNode.
        public void InsertNode(T insertValue)
        {
            if (root == null)
            {
                root = new TreeNode<T>(insertValue);
            }
            else
            {
                root.Insert(insertValue);
            }
        }

        // begin preorder traversal
        public void PreorderTraversal()
        {
            PreorderHelper(root);
        }

        // recursive method to perform preorder traversal
        private void PreorderHelper(TreeNode<T> node)
        {
            if (node != null)
            {
                // output node Data              
                Console.Write($"{node.Data} ");

                // traverse left subtree        
                PreorderHelper(node.LeftNode);

                // traverse right subtree        
                PreorderHelper(node.RightNode);
            }
        }

        // begin inorder traversal
        public void InorderTraversal()
        {
            InorderHelper(root);
        }

        // recursive method to perform inorder traversal
        private void InorderHelper(TreeNode<T> node)
        {
            if (node != null)
            {
                // traverse left subtree       
                InorderHelper(node.LeftNode);

                // output node data              
                Console.Write($"{node.Data} ");

                // traverse right subtree       
                InorderHelper(node.RightNode);
            }
        }

        // begin postorder traversal
        public void PostorderTraversal()
        {
            PostorderHelper(root);
        }

        // recursive method to perform postorder traversal
        private void PostorderHelper(TreeNode<T> node)
        {
            if (node != null)
            {
                // traverse left subtree         
                PostorderHelper(node.LeftNode);

                // traverse right subtree         
                PostorderHelper(node.RightNode);

                // output node Data              
                Console.Write($"{node.Data} ");
            }
        }
    }
}
