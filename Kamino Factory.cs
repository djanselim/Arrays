using System;
using System.Linq;


namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string command;
            int[] DNA = new int[dnaLength];
            int bestDnaSum = 0;
            int bestSample = -1;
            int bestSequence = -1;
            int leftMostStartingIndex = int.MaxValue;
            int sample = 1;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] currDna = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currSequence = 0;
                int endIndex = 0;
                int startIndex = 0;
                int currSum = 0;
                int currBestSequence = 0;
                bool IsBestDna = false;

                for (int i = 0; i < currDna.Length; i++)
                {
                    if (currDna[i] == 0)
                    {
                        currSequence = 0;
                        continue;
                    }
                    currSequence++;
                    if (currSequence >= currBestSequence)
                    {
                        currBestSequence = currSequence;
                        endIndex = i;
                    }
                }
                startIndex = (endIndex - currBestSequence) + 1;
                currSum = currDna.Sum();

                if (currBestSequence == bestSequence)
                {
                    if (startIndex == leftMostStartingIndex)
                    {
                        if (currSum > bestDnaSum)
                        {
                            IsBestDna = true;
                        }
                    }
                    else if (startIndex < leftMostStartingIndex)
                    {
                        IsBestDna = true;
                    }
                }
                else if (currBestSequence > bestSequence)
                {
                    IsBestDna = true;
                }


                if (IsBestDna)
                {
                    DNA = currDna;
                    bestSequence = currBestSequence;
                    leftMostStartingIndex = startIndex;
                    bestSample = sample;
                    bestDnaSum = currSum;
                }
                sample++;
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestDnaSum}.");
            Console.WriteLine(String.Join(" ", DNA));
        }
    }
}
