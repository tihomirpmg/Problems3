using System;
using System.Linq;

namespace _8.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number to calculate the factorial: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            Console.WriteLine("recursively or iteratively");
            string type = Console.ReadLine();
            do
            {
                switch (type)
                {
                    case "recursively":
                        if (n == 1)
                            Console.WriteLine(1);
                        else
                            fact = fact * n;
                        n--;
                        break;
                        case "iteratively":
                        for (int i = 1; i < n; i++)
                        {
                            fact = fact*n;
                            n--;
                        }
                        break;
                }
            } while (n > 1);
            Console.WriteLine(fact);
        }
    }
}
