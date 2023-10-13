using Ex_1903.Classes;

namespace Ex_1903
{
    internal class Program_1903
    {
        static void Main(string[] args)
        {

            // Empty List
            DoubleLinkedList list = new DoubleLinkedList();
            list.Display();

            // Insert objects into list
            var person1 = new Person("Jonas");
            var person2 = new Person("Beck");
            list.InsertAtFront(person1);
            list.InsertAtFront(person2);
            list.Display();

            // Insert person3 before person1
            var person3 = new Person("middle");
            list.Insert(person1, person3);
            list.Display();

            // Insert person4 after person1
            var person4 = new Person("last");
            list.InsertAfter(person1, person4);
            list.Display();

            // Delete person3 from list
            list.Delete(person3);
            list.Display();

            // Delete Person4 from list
            list.Delete(person4);
            list.Display();

        }
    }
}