using System;
using System.Linq;

namespace _6EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entered = Console.ReadLine();

            int[] Arr = entered.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            int ExistElement = 0;

            bool isExistElement = true;
            for (int i = 0; i < Arr.Length; i++)
            {
                int CurrentIndex = i;
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += Arr[j];
                }
                for (int k = i + 1; k < Arr.Length; k++)
                {
                    rightSum += Arr[k];
                }
                if (leftSum == rightSum)
                {
                    ExistElement = CurrentIndex;
                    isExistElement = true;
                    break;
                }
                else
                {
                    isExistElement = false;
                }
            }


            if (isExistElement)
            {
                Console.WriteLine(ExistElement);
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
