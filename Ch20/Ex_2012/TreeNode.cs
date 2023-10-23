namespace Ex_2012
{
    internal class TreeNode<T> where T : IComparable<T>
    {
        // automatic property LeftNode
        public TreeNode<T> LeftNode { get; set; }

        // automatic property Data
        public T Data { get; private set; }

        // automatic property RightNode
        public TreeNode<T> RightNode { get; set; }

        // initialize Data and make this a leaf node
        public TreeNode(T nodeData)
        {
            Data = nodeData;
        }

        // insert TreeNode into Tree that contains nodes;
        // ignore duplicate values
        public void Insert(T insertValue)
        {
            if (insertValue.CompareTo(Data) < 0) // insert in left subtree
            {
                // insert new TreeNode
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode<T>(insertValue);
                }
                else // continue traversing left subtree
                {
                    LeftNode.Insert(insertValue);
                }
            }
            else if (insertValue.CompareTo(Data) > 0) // insert in right subtree
            {
                // insert new TreeNode
                if (RightNode == null)
                {
                    RightNode = new TreeNode<T>(insertValue);
                }
                else // continue traversing right subtree
                {
                    RightNode.Insert(insertValue);
                }
            }
        }
    }
}
