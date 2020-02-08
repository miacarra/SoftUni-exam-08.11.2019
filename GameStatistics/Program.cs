using System;

namespace GameStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            string playerName = Console.ReadLine();
            if (minutes == 0)
            {
                Console.WriteLine($"Match has just began!");
            }
            if (minutes >0 &&minutes <45)
            {
                Console.WriteLine($"First half time.");
            }
            if (minutes >= 45)
            {
                Console.WriteLine($"Second half time.");
            }
            if (minutes >= 1 && minutes <= 10)
            {
                if (minutes % 2 == 0)
                {
                    Console.WriteLine($"{playerName} missed a penalty.");
                    Console.WriteLine($"{playerName} was injured after the penalty.");
                }
                else
                {
                    Console.WriteLine($"{playerName} missed a penalty.");
                }
            }
            if (minutes > 10 && minutes <= 35)
            {
                if (minutes % 2 ==1)
                {
                    Console.WriteLine($"{ playerName} received yellow card.");
                    Console.WriteLine($"{ playerName} got another yellow card.");
                }
                else
                {
                    Console.WriteLine($"{ playerName} received yellow card.");
                }
            }
            if (minutes > 35 && minutes < 45)
            {
                  
            Console.WriteLine($"{playerName} SCORED A GOAL!!!");
                
            }
            if (minutes >45 && minutes <= 55)
            {
                if (minutes % 2 == 0)
                {
                    Console.WriteLine($"{playerName} got a freekick.");
                    Console.WriteLine($"{playerName} missed the freekick.");
            
                }
                else
                {
                    Console.WriteLine($"{playerName} got a freekick.");
                }
            }
            if (minutes > 55 && minutes <= 80)
            {
                if (minutes % 2 == 1)
                {
                    Console.WriteLine($"{playerName} missed a shot from corner.");
                    Console.WriteLine($"{ playerName} has been changed with another player.");
                }
                else
                {
                    Console.WriteLine($"{playerName} missed a shot from corner.");
                }
            }
            if (minutes > 80 && minutes <= 90)
            { 
                    Console.WriteLine($"{playerName} SCORED A GOAL FROM PENALTY !!!");

            }
        }
    }
}
