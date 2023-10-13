using Ex_1904.Classes;

namespace Ex_1904
{
    internal class Program_1904
    {
        static void Main(string[] args)
        {

            StackInheritance stack = new StackInheritance();
            stack.Display();
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Stack push({i})");
                stack.Push(i);
                stack.Display();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Stack Pop()");
                stack.Pop();
                stack.Display();
            }

        }
    }
}