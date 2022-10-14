namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            Console.WriteLine("Use case #1: Create a Simple Linked List");

            Console.Write("Please select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LinkedList<int> list = new LinkedList<int>();
                    list.AddLast(56);
                    list.AddLast(70);
                    list.AddLast(30);
                    foreach (int item in list)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
        }
    }
}