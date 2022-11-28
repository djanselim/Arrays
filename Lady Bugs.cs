using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];

            foreach (int index in indexes)
            {
                if(index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }
            string command;

            while((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int ladyBugIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (ladyBugIndex >= field.Length || ladyBugIndex < 0 || field[ladyBugIndex] == 0)
                {
                    continue;
                }
                if(direction == "left")
                {
                    flyLength *= -1;
                }

                int nextMove = ladyBugIndex + flyLength;
                field[ladyBugIndex] = 0;

                while(nextMove < field.Length && nextMove >= 0 && field[nextMove] != 0)
                {
                    nextMove += flyLength;
                }

                if(nextMove < 0 || nextMove >= field.Length)
                {
                    continue;
                }
                field[nextMove] = 1;
            }
            Console.WriteLine(String.Join(" ", field));

        }
    }
}
