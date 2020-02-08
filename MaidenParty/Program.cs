using System;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double maidenPartyBudget = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int artRoses = int.Parse(Console.ReadLine());
            int keyKeepers = int.Parse(Console.ReadLine());
            int drawings = int.Parse(Console.ReadLine());
            int souvenirs = int.Parse(Console.ReadLine());
            int pcsCount = loveLetters + artRoses + keyKeepers + drawings + souvenirs;
            double incomes = (loveLetters * 0.6) + (artRoses * 7.2) + (keyKeepers * 3.6) + (drawings * 18.2) + (souvenirs * 22);
           double  netIncome = 0;
            if (pcsCount > 15)
            {
                incomes -= incomes * 0.35;
                netIncome = incomes * 0.9;
            }
            else
            {
                incomes= (loveLetters * 0.6) + (artRoses * 7.2) + (keyKeepers * 3.6) + (drawings * 18.2) + (souvenirs * 22);
                netIncome = incomes * 0.9;
            }
            if ( netIncome>=maidenPartyBudget)
            {
                Console.WriteLine($"Yes! {(netIncome - maidenPartyBudget):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(maidenPartyBudget-netIncome):f2} lv needed.");
            }

            


        
        }
    }
}
