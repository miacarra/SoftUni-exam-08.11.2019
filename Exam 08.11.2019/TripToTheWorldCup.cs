using System;

namespace Exam_08._11._2019
{
    class TripToTheWorldCup
    {
        static void Main(string[] args)
        {
            double firstFlight = double.Parse(Console.ReadLine());
            double secondFlight = double.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int matchCount = int.Parse(Console.ReadLine());
            double percentageDiscount = double.Parse(Console.ReadLine());

            double ticketPrices = (6*firstFlight) + (6*secondFlight);
            double totalticketPrice = ticketPrices - (ticketPrices * (percentageDiscount / 100));
            double matchesPrice =( matchCount * ticketPrice)*6;
            double totalCosts = totalticketPrice + matchesPrice;
            Console.WriteLine($"Total sum: {totalCosts:f2} lv.");
            Console.WriteLine($"Each friend has to pay {(totalCosts/6):f2} lv.");
      



        }
    }
}
