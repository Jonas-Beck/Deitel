namespace Ex_1908.Classes
{
    internal class Tree
    {
        private TreeNode root;

        // Insert a new node in the binary search tree.
        // If the root node is null, create the root node here.
        // Otherwise, call the insert method of class TreeNode.
        public void InsertNode(int insertValue)
        {
            if (root == null)
            {
                root = new TreeNode(insertValue);
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
        private void PreorderHelper(TreeNode node)
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
        private void InorderHelper(TreeNode node)
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
        private void PostorderHelper(TreeNode node)
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
        public void LevelOrderTraversal()
        {

            var queue = new QueueInheritance();

            // Insert Root node in queue
            queue.Enqueue(root);

            while (!queue.IsEmpty())
            {
                // Remove node and store data in treeNode
                var treeNode = (TreeNode)queue.Dequeue();

                // Display nodes value
                Console.Write($"{treeNode.Data} ");

                // Add node children to queue
                if (treeNode.LeftNode != null)
                    queue.Enqueue(treeNode.LeftNode);
                if (treeNode.RightNode != null)
                    queue.Enqueue(treeNode.RightNode);
            }
        }
    }
}
