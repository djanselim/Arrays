using System;
using System.Linq;
namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] evenRows = new int[rows];
            int[] oddRows = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenRows[i] = numbers[0];
                    oddRows[i] = numbers[1];
                }
                else
                {
                    oddRows[i] = numbers[0];
                    evenRows[i] = numbers[1];

                }
            }
            Console.WriteLine(String.Join(" ", evenRows));
            Console.WriteLine(String.Join(" ", oddRows));

        }
    }
}
