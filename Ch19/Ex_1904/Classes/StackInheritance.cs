namespace Ex_1904.Classes
{
    internal class StackInheritance : List
    {
        public StackInheritance() : base("Stack") { }

        public void Push(object dataValue)
        {
            InsertAtBack(dataValue);
        }

        public void Pop()
        {
            RemoveFromBack();
        }
    }
}
