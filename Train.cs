using System;
using System.Linq;
namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] numbers = new int[lines];
            int totalSum = 0;

            for (int i = 0; i < lines; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                totalSum += numbers[i];
                
            }
            Console.WriteLine(String.Join(" ", numbers));
            Console.WriteLine(totalSum);


        }
    }
}
