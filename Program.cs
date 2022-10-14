using System.Collections.Generic;

namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            Console.WriteLine("Use case #1: Create a Simple Linked List");
            Console.WriteLine("Use case #2: Add to LinkedList in reverse");
            Console.WriteLine("Use case #3: Append to LinkedList");

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
                case 2:
                    LinkedList listOne = new LinkedList();
                    listOne.AddReverseData(70);
                    listOne.AddReverseData(30);
                    listOne.AddReverseData(56);
                    listOne.Display();
                    break;
                case 3:
                    LinkedList listTwo = new LinkedList();
                    listTwo.AddAppend(56);
                    listTwo.AddAppend(30);
                    listTwo.AddAppend(70);
                    listTwo.Display();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
        }
    }
}