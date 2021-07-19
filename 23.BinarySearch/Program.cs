using System;

namespace _23.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                //enter array elements
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            //print array
            Console.WriteLine(string.Join(" ", arr));
            //to print array sorted ascending
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
            //print sorted array
            Console.WriteLine("Here is the sorted array: ");
            Console.WriteLine(string.Join(" ", arr));
            Console.Write("For which number you search: ");
            int n = int.Parse(Console.ReadLine());
            int ind = Array.BinarySearch(arr, n);
            //print the number you searched for
            if (ind >= 0) 
                Console.Write("Number is on {0} index.", ind);
            else 
                Console.Write("Number wasn't found.");
        }
    }
}
