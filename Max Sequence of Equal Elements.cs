using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longestSequence = 0;
            int currentSequence = 0;
            int element = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentSequence++;
                }   
                else
                {
                    currentSequence = 0;
                }
                if(currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    element = numbers[i];
                }
             
            }
            for (int i = 0; i <= longestSequence; i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}
//2 1 1 2 3 3 2 2 2 1