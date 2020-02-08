using System;

namespace GroupStage
{
    class GroupStage
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int matchesCount = int.Parse(Console.ReadLine());
            int goalsWinnedCounter = 0;
            int goalsReceivedCounter = 0;
            int point = 0;

            for (int i = 1; i <= matchesCount; i++)
            {
                int goalsWinned = int.Parse(Console.ReadLine());
                int goalsReceived = int.Parse(Console.ReadLine());
                goalsWinnedCounter += goalsWinned;
                goalsReceivedCounter += goalsReceived;
            
                if (goalsWinned > goalsReceived)
                {
                    point += 3;
                }
                else if (goalsWinned == goalsReceived)
                {
                    point += 1;
                }
             }
            if (goalsWinnedCounter >= goalsReceivedCounter)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {point} points.");
                Console.WriteLine($"Goal difference: {(goalsWinnedCounter - goalsReceivedCounter)}.");
            }
            else 
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {(goalsWinnedCounter - goalsReceivedCounter)}.");

            }

        
        }
    }
}
