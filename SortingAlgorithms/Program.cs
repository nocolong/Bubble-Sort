using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading file..");
            int[] list = readFromFile();
            Console.WriteLine("File loaded.");
            Console.WriteLine("Choose a sorting algorithm");
            Console.WriteLine();
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bubbleSort(list);
                    break;
                case "2":
                    insertionSort(list);
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        static int[] readFromFile()
        {
          
                string fileContents = File.ReadAllText("C:\\dev\\data\\unsorted-numbers.txt");

                string[] numbersAsStrings = fileContents.Split(',');

                int[] numbers = new int[numbersAsStrings.Length];

                for (int i = 0; i < numbersAsStrings.Length; i++)
                {
                    numbers[i] = int.Parse(numbersAsStrings[i]);
                }

                return numbers;
            

        }

        static void bubbleSort(int[] list)
        {
            printList("Unsorted List", list);

            // implement bubble sort here
            for (int i = list.Length - 1; i > 0; i--) //loop backwards through
            {
                for (int j = 0; j < i; j++)             //bubble up
                {
                    if (list[j] > list[j + 1])          //if out of order..
                    {
                        int temp = list[j];             //then swap
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            printList("Sorted list", list);
        }

        static void insertionSort(int[] list)
        {
            printList("Unsorted List", list);

            // implement insertion sort here
            int temp, j;
            for(int i = 1; i < list.Length; i++)
            {
                temp = list[i];
                j = i - 1;
                while(j >=0 && list[j] > temp)
                {
                    list[j + 1] = temp;
                    {
                        list[j + 1] = list[j];
                        j--;
                    }
                    list[j + 1] = temp;
                }
            }

            printList("Sorted list", list);
        }

        static void printList(string listName, int[] list)
        {
            Console.WriteLine("-- " + listName + " --");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + ", ");
            }
            Console.WriteLine();
            

        }
    }
}
