namespace Ex_1903.Classes
{
    internal class ListNode
    {
        // automatic read-only property Data
        public object Data { get; private set; }

        // automatic property Next
        public ListNode Next { get; set; }
        public ListNode Previous { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(object dataValue) : this(dataValue, null, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(object dataValue, ListNode previous, ListNode next)
        {
            Data = dataValue;
            Next = next;
            Previous = previous;
        }
    }
}
