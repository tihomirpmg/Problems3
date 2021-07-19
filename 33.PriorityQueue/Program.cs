using System;
using System.Collections;
using System.Collections.Generic;

namespace _33.PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
                string addOrRemove;
                Queue elem = new Queue();
            do
            {
                Console.WriteLine("add or remove elements?");
                Console.WriteLine("Type add or remove:");
                addOrRemove = Console.ReadLine();
                if (addOrRemove == "add")
                {
                    Console.WriteLine("How many element you will add in queue:");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Each on new line!");
                    for (int i = 0; i < n; i++)
                    {
                        int p = int.Parse(Console.ReadLine());
                        elem.Enqueue(p);
                    }
                }
                else if (addOrRemove == "remove")
                {
                    Console.WriteLine("Remove {0}", elem.Dequeue());
                }
                foreach (Object obj in elem)
                {
                    Console.Write(" "+obj);
                }
                Console.WriteLine();
                Console.WriteLine("The number of elements in the Queue is: " + elem.Count);
            } 
            while (addOrRemove != "end");
            Console.WriteLine("End");
        }
    }
}
