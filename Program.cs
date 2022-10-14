﻿using System.Collections.Generic;

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
            Console.WriteLine("Use case #4: Insert 30 between 56 and 70 in linkedlist");
            Console.WriteLine("Use case #5: Delete first element in linkedlist");
            Console.WriteLine("Use case #6: Delete last element in linkedlist");

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
                case 4:
                    LinkedList listThree = new LinkedList();
                    listThree.AddAppend(56);
                    listThree.AddAppend(70);
                    listThree.Display();
                    listThree.Insert(2, 30);
                    Console.WriteLine("----------After insert operation----------");
                    listThree.Display();
                    break;
                case 5:
                    LinkedList listFour = new LinkedList();
                    listFour.AddAppend(56);
                    listFour.AddAppend(30);
                    listFour.AddAppend(70);
                    listFour.Display();
                    listFour.PopFirst();
                    Console.WriteLine("----------After popping first element----------");
                    listFour.Display();
                    break;
                case 6:
                    LinkedList listFive = new LinkedList();
                    listFive.AddAppend(56);
                    listFive.AddAppend(30);
                    listFive.AddAppend(70);
                    listFive.Display();
                    listFive.PopLast();
                    Console.WriteLine("----------After popping first element----------");
                    listFive.Display();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
        }
    }
}