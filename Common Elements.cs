using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstRow = Console.ReadLine().Split().ToArray();
            string[] secondRow = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < firstRow.Length; i++)
            {
                for (int j = 0; j < secondRow.Length; j++)
                {
                    if (firstRow[i] == secondRow[j])
                    {
                        Console.Write(firstRow[i] + " ");
                    }
                }
            }
        }
    }
}
