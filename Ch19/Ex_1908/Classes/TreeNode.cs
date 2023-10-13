namespace Ex_1908.Classes
{
    internal class TreeNode
    {
        // automatic property LeftNode
        public TreeNode LeftNode { get; set; }

        // automatic property Data
        public int Data { get; private set; }

        // automatic property RightNode
        public TreeNode RightNode { get; set; }

        // initialize Data and make this a leaf node
        public TreeNode(int nodeData)
        {
            Data = nodeData;
        }

        // insert TreeNode into Tree that contains nodes;
        // ignore duplicate values
        public void Insert(int insertValue)
        {
            if (insertValue < Data) // insert in left subtree
            {
                // insert new TreeNode
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode(insertValue);
                }
                else // continue traversing left subtree
                {
                    LeftNode.Insert(insertValue);
                }
            }
            else if (insertValue > Data) // insert in right subtree
            {
                // insert new TreeNode
                if (RightNode == null)
                {
                    RightNode = new TreeNode(insertValue);
                }
                else // continue traversing right subtree
                {
                    RightNode.Insert(insertValue);
                }
            }
        }
    }
}
