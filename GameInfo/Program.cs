using System;

namespace GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int matchesPlayed = int.Parse(Console.ReadLine());
            int matchesBreaksCounter = 0;
            int matchWithGoalsCounter = 0;
            double totalPlayTime = 0;


            for (int i = 1; i <= matchesPlayed; i++)
            {
                double matchDuration = double.Parse(Console.ReadLine());
                totalPlayTime += matchDuration;
                if (matchDuration >= 90 && matchDuration < 120)
                {
                    matchesBreaksCounter++;
                }
                if (matchDuration > 120)
                {
                    matchWithGoalsCounter++;
                }

            }
            Console.WriteLine($"{teamName} has played {totalPlayTime} minutes. Average minutes per game: {(totalPlayTime / matchesPlayed):f2}");
            Console.WriteLine($"Games with penalties: {matchWithGoalsCounter}");
            Console.WriteLine($"Games with additional time: { matchesBreaksCounter}");
        }
    }
}
