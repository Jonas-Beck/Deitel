namespace Ex_1903.Classes
{
    internal class DoubleLinkedList
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public DoubleLinkedList(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public DoubleLinkedList() : this("list") { }

        public void Insert(object referenceNode, object insertItem)
        {
            // Get reference node from method FindReferenceNode() 
            ListNode node = FindReferenceNode(referenceNode);

            // Insert insertItem before referencenode
            ListNode previous = node.Previous;
            if (previous == null)
            {
                // Insert new listnode as firstnode
                firstNode = node.Previous = new ListNode(insertItem, null, node);
            }
            else
            {
                // Insert new listnode between 2 nodes 
                previous.Next = node.Previous = new ListNode(insertItem, previous, node);
            }
        }

        public void InsertAfter(Object referenceNode, object insertItem)
        {

            // Get reference node from method FindReferenceNode() 
            ListNode node = FindReferenceNode(referenceNode);

            // Insert InsertItem after referencenode
            ListNode next = node.Next;

            if (next == null)
            {
                // Insert new listnode as lastnode
                lastNode = node.Next = new ListNode(insertItem, node, null);
            }
            else
            {
                // Insert new lsitnode between 2 nodes
                next.Previous = node.Next = new ListNode(insertItem, node, next);
            }

        }

        public void Delete(Object referenceNode)
        {

            // Get reference node from method FindReferenceNode() 
            ListNode node = FindReferenceNode(referenceNode);


            // IF reference is firstNode
            if (node == firstNode)
            {
                firstNode = node.Next;
                node.Next.Previous = null;
            } // if reference is last node
            else if (node == lastNode)
            {
                lastNode = node.Previous;
                node.Previous.Next = null;
            }
            else
            {
                ListNode next = node.Next;
                ListNode previous = node.Previous;

                next.Previous = previous;
                previous.Next = next;
            }
        }

        public ListNode FindReferenceNode(Object referenceNode)
        {

            // Check linkedlist isnt empty
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }
            else
            {
                // Variable for current node
                ListNode current = firstNode;

                do
                {
                    // Check if current node == reference Node
                    if (ReferenceEquals(current.Data, referenceNode))
                    {
                        return current;
                    }

                    // Increment current to next node in list
                    current = current.Next;

                    // Continue until current == null
                } while (current != null);

            }
            // Throw exception if referenceNode isnt in list
            throw new ArgumentException("ReferenceNode not found in the list");
        }




        // Insert object at front of List. If List is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                firstNode = firstNode.Previous = new ListNode(insertItem, null, firstNode);
            }
        }

        // Insert object at end of List. If List is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem, lastNode, null);
            }
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }


    }
}
